using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SedapMakan
{
    public partial class AdminForm : Form
    {
        private string email;
        public AdminForm(string userEmail)
        {
            email = userEmail;
            InitializeComponent();
            lblWelcome.Text = "Welcome Admin: " + email;
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var username = txtUser.Text.Trim();
            var pass = txtPass.Text.Trim();
            var role = cmbRole.Text;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Email, Password, Role, Balance) VALUES (@e,@p,@r,0)", conn);
                cmd.Parameters.AddWithValue("@e", username);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("User added");
            LoadUsers();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null) return;
            string selected = listUsers.SelectedItem.ToString();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Email=@e", conn);
                cmd.Parameters.AddWithValue("@e", selected);
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
        }

        private void LoadUsers()
        {
            listUsers.Items.Clear();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Email FROM Users", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listUsers.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
    }
}
