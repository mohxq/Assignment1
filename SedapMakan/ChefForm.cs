using System;
using System.Windows.Forms;

namespace SedapMakan
{
    public partial class ChefForm : Form
    {
        private string email;
        public ChefForm(string userEmail)
        {
            email = userEmail;
            InitializeComponent();
            lblWelcome.Text = "Welcome Chef: " + email;
        }
    }
}
