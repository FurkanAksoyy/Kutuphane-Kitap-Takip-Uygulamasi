using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Kütüphane_Kitap_Takip_Uygulaması
{
    public partial class RegisterForm : Form
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["LibraryConn"].ConnectionString;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all required fields (First/Last Name, Username, Password, Email).",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var first = txtFirstName.Text.Trim();
            var last = txtLastName.Text.Trim();
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;      // TODO: hash fonksiyonu ekle
            var email = txtEmail.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var bdate = dtpBirthDate.Value.Date;
            var type = cmbUserType.SelectedItem.ToString() == "Member" ? 'M' : 'A';

            string sql = @"
                INSERT INTO Users
                    (FirstName, LastName,
                     Username, [Password], UserType,
                     Email, Phone, BirthDate)
                VALUES
                    (@fn,@ln,
                     @u,@p,@t,
                     @e,@ph,@bd)";

            try
            {
                using (var conn = new SqlConnection(cs))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fn", first);
                    cmd.Parameters.AddWithValue("@ln", last);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);
                    cmd.Parameters.AddWithValue("@t", type);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@ph", phone);
                    cmd.Parameters.AddWithValue("@bd", bdate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
