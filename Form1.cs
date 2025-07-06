using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Kütüphane_Kitap_Takip_Uygulaması
{
    public partial class Form1 : Form
    {
        private readonly string cs =
            ConfigurationManager
                .ConnectionStrings["LibraryConn"]
                .ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;
            var hashed = pass; // TODO: gerçekte hash fonksiyonu kullan

            using (var conn = new SqlConnection(cs))
            using (var cmd = new SqlCommand(
                "SELECT UserType, UserID FROM Users WHERE Username=@u AND [Password]=@p", conn))
            {
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", hashed);

                try
                {
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            var type = rdr.GetString(0)[0];
                            var id = rdr.GetInt32(1);
                            this.Hide();
                            if (type == 'M')
                                new MemberPanel(id).Show();
                            else
                                new AdminPanel().Show();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Connection error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var frm = new RegisterForm())
                frm.ShowDialog();
        }
    }
}
