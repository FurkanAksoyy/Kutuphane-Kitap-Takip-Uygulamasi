using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Kütüphane_Kitap_Takip_Uygulaması
{
    public partial class AdminPanel : Form
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadCounts();
            LoadBooksAdmin();
            LoadMembers();
            LoadReservations();
        }

        private void LoadCounts()
        {
            lblTotalBooks.Text = $"Books: {GetScalar("SELECT COUNT(*) FROM Books")}";
            lblTotalMembers.Text = $"Members: {GetScalar("SELECT COUNT(*) FROM Users")}";
            lblTotalReservations.Text = $"Reservations: {GetScalar("SELECT COUNT(*) FROM Reservations")}";
        }

        private int GetScalar(string sql)
        {
            using (var conn = new SqlConnection(cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void LoadBooksAdmin()
        {
            using (var conn = new SqlConnection(cs))
            using (var adapter = new SqlDataAdapter(
                "SELECT BookID, Title, Author, ISBN, TotalCopies, Available FROM Books", conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvBooksAdmin.DataSource = dt;
            }
        }

        private void LoadMembers()
        {
            using (var conn = new SqlConnection(cs))
            using (var adapter = new SqlDataAdapter(
                "SELECT UserID, Username, UserType FROM Users", conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void LoadReservations()
        {
            const string sql = @"
                SELECT R.ReservationID, U.Username, B.Title,
                       R.ReservedDate, R.DueDate, R.ReturnedDate
                FROM Reservations R
                JOIN Users U ON R.UserID = U.UserID
                JOIN Books B ON R.BookID = B.BookID";

            using (var conn = new SqlConnection(cs))
            using (var adapter = new SqlDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvReservationsAdmin.DataSource = dt;
            }
        }

        private void dgvBooksAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooksAdmin.CurrentRow == null) return;
            var row = dgvBooksAdmin.CurrentRow;
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtAuthor.Text = row.Cells["Author"].Value.ToString();
            txtISBN.Text = row.Cells["ISBN"].Value.ToString();
            txtTotalCopies.Text = row.Cells["TotalCopies"].Value.ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTotalCopies.Text.Trim(), out int tc))
            {
                MessageBox.Show("Total Copies must be a number.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(cs))
            using (var cmd = new SqlCommand(@"
                INSERT INTO Books (Title, Author, ISBN, TotalCopies, Available)
                VALUES (@t,@a,@i,@tc,@tc)", conn))
            {
                cmd.Parameters.AddWithValue("@t", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtAuthor.Text.Trim());
                cmd.Parameters.AddWithValue("@i", txtISBN.Text.Trim());
                cmd.Parameters.AddWithValue("@tc", tc);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCounts();
            LoadBooksAdmin();
            ClearBookFields();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBooksAdmin.CurrentRow == null) return;
            int bookId = Convert.ToInt32(dgvBooksAdmin.CurrentRow.Cells["BookID"].Value);

            if (!int.TryParse(txtTotalCopies.Text.Trim(), out int tc))
            {
                MessageBox.Show("Total Copies must be a number.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(cs))
            using (var cmd = new SqlCommand(@"
                UPDATE Books
                   SET Title=@t, Author=@a, ISBN=@i, TotalCopies=@tc
                 WHERE BookID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@t", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtAuthor.Text.Trim());
                cmd.Parameters.AddWithValue("@i", txtISBN.Text.Trim());
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@id", bookId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCounts();
            LoadBooksAdmin();
            ClearBookFields();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooksAdmin.CurrentRow == null) return;
            int bookId = Convert.ToInt32(dgvBooksAdmin.CurrentRow.Cells["BookID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this book?",
                                "Confirm",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (var conn = new SqlConnection(cs))
            using (var cmd = new SqlCommand("DELETE FROM Books WHERE BookID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", bookId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCounts();
            LoadBooksAdmin();
            ClearBookFields();
        }

        private void ClearBookFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            txtTotalCopies.Clear();
        }
    }
}
