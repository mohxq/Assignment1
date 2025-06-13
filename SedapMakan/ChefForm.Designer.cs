namespace SedapMakan
{
    partial class ChefForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;

        private void InitializeComponent()
        {
            lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(12, 9);
            lblWelcome.Text = "";
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(lblWelcome);
            this.Text = "Chef Panel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
