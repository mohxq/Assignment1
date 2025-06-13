using System;
using System.Windows.Forms;

namespace SedapMakan
{
    public partial class CustomerForm : Form
    {
        private string email;
        public CustomerForm(string userEmail)
        {
            email = userEmail;
            InitializeComponent();
            lblWelcome.Text = "Welcome Customer: " + email;
        }
    }
}
