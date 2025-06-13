using System;
using System.Windows.Forms;

namespace SedapMakan
{
    public partial class ManagerForm : Form
    {
        private string email;
        public ManagerForm(string userEmail)
        {
            email = userEmail;
            InitializeComponent();
            lblWelcome.Text = "Welcome Manager: " + email;
        }
    }
}
