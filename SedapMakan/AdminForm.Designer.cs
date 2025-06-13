namespace SedapMakan
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblWelcome;

        private void InitializeComponent()
        {
            listUsers = new System.Windows.Forms.ListBox();
            btnAddUser = new System.Windows.Forms.Button();
            btnRemoveUser = new System.Windows.Forms.Button();
            txtUser = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // listUsers
            listUsers.Location = new System.Drawing.Point(12, 72);
            listUsers.Size = new System.Drawing.Size(260, 140);
            // txtUser
            txtUser.Location = new System.Drawing.Point(12, 27);
            // txtPass
            txtPass.Location = new System.Drawing.Point(12, 46);
            txtPass.PasswordChar = '*';
            // cmbRole
            cmbRole.Location = new System.Drawing.Point(150, 27);
            cmbRole.Items.AddRange(new object[] { "Admin", "Manager", "Chef", "Customer" });
            // btnAddUser
            btnAddUser.Location = new System.Drawing.Point(197, 46);
            btnAddUser.Size = new System.Drawing.Size(75,23);
            btnAddUser.Text = "Add";
            btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // btnRemoveUser
            btnRemoveUser.Location = new System.Drawing.Point(12, 218);
            btnRemoveUser.Size = new System.Drawing.Size(260,23);
            btnRemoveUser.Text = "Remove Selected";
            btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(12, 9);
            lblWelcome.Text = "";
            // AdminForm
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(lblWelcome);
            this.Controls.Add(listUsers);
            this.Controls.Add(txtUser);
            this.Controls.Add(txtPass);
            this.Controls.Add(cmbRole);
            this.Controls.Add(btnAddUser);
            this.Controls.Add(btnRemoveUser);
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
