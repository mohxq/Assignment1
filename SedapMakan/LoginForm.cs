using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SedapMakan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string role = null;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Role FROM Users WHERE Email=@e AND Password=@p", conn);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", password);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    role = result.ToString();
                }
            }
            if (role == null)
            {
                MessageBox.Show("Invalid credentials");
                return;
            }
            this.Hide();
            Form f;
            if (role == "Admin")
            {
                f = new AdminForm(email);
            }
            else if (role == "Manager")
            {
                f = new ManagerForm(email);
            }
            else if (role == "Chef")
            {
                f = new ChefForm(email);
            }
            else
            {
                f = new CustomerForm(email);
            }
            f.Show();
        }
    }
}
