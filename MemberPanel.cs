using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Kütüphane_Kitap_Takip_Uygulaması
{
    public partial class MemberPanel : Form
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;
        private readonly int _userId;

        public MemberPanel(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void MemberPanel_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadMyReservations();
        }

        private void LoadBooks(string searchTerm = "")
        {
            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    string sql = @"SELECT BookID, Title, Author, ISBN, Available
                                   FROM Books" +
                                 (string.IsNullOrEmpty(searchTerm)
                                    ? ""
                                    : " WHERE Title LIKE @s OR Author LIKE @s OR ISBN LIKE @s");

                    using (var adapter = new SqlDataAdapter(sql, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                            adapter.SelectCommand.Parameters.AddWithValue("@s", $"%{searchTerm}%");

                        var dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBooks.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void LoadMyReservations()
        {
            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    string sql = @"
                        SELECT R.ReservationID, B.Title, B.Author,
                               R.ReservedDate, R.DueDate, R.ReturnedDate
                        FROM Reservations R
                        JOIN Books B ON R.BookID = B.BookID
                        WHERE R.UserID = @uid";

                    using (var adapter = new SqlDataAdapter(sql, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@uid", _userId);

                        var dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMyReservations.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading your reservations:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
            => LoadBooks(txtSearch.Text.Trim());

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book first.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            int avail = Convert.ToInt32(dgvBooks.CurrentRow.Cells["Available"].Value);

            if (avail < 1)
            {
                MessageBox.Show("No copies available.",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                    
                    using (var cmdCount = new SqlCommand(
                        "SELECT COUNT(*) FROM Reservations WHERE UserID=@u AND ReturnedDate IS NULL", conn))
                    {
                        cmdCount.Parameters.AddWithValue("@u", _userId);
                        int active = (int)cmdCount.ExecuteScalar();
                        if (active >= 3)
                        {
                            MessageBox.Show("You already have 3 active reservations.",
                                            "Info",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            return;
                        }
                    }
                    
                    using (var tran = conn.BeginTransaction())
                    {
                        using (var cmdRes = new SqlCommand(
                            @"INSERT INTO Reservations
                              (UserID, BookID, ReservedDate, DueDate)
                              VALUES (@u,@b,GETDATE(),DATEADD(day,14,GETDATE()))", conn, tran))
                        {
                            cmdRes.Parameters.AddWithValue("@u", _userId);
                            cmdRes.Parameters.AddWithValue("@b", bookId);
                            cmdRes.ExecuteNonQuery();
                        }
                        using (var cmdUpd = new SqlCommand(
                            "UPDATE Books SET Available = Available - 1 WHERE BookID = @b", conn, tran))
                        {
                            cmdUpd.Parameters.AddWithValue("@b", bookId);
                            cmdUpd.ExecuteNonQuery();
                        }
                        tran.Commit();
                    }
                }

                MessageBox.Show("Book reserved successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadBooks(txtSearch.Text.Trim());
                LoadMyReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reserving book:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dgvMyReservations_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvMyReservations.Rows[e.RowIndex];
            if (row.Cells["ReturnedDate"].Value == DBNull.Value
                && DateTime.TryParse(row.Cells["DueDate"].Value?.ToString(), out var due)
                && due < DateTime.Now)
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }
    }
}
