namespace SarasaviLibrary.UI
{
    partial class BookRegistrationForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtBookNumber;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Button BtnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.TxtBookNumber = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TxtBookNumber
            this.TxtBookNumber.Location = new System.Drawing.Point(12, 12);
            this.TxtBookNumber.Name = "TxtBookNumber";
            this.TxtBookNumber.Size = new System.Drawing.Size(260, 20);
            this.TxtBookNumber.PlaceholderText = "Enter Book Number";

            // TxtTitle
            this.TxtTitle.Location = new System.Drawing.Point(12, 38);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(260, 20);
            this.TxtTitle.PlaceholderText = "Enter Book Title";

            // BtnRegister
            this.BtnRegister.Location = new System.Drawing.Point(12, 64);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

            // BookRegistrationForm
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.TxtBookNumber);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.BtnRegister);
            this.Name = "BookRegistrationForm";
            this.Text = "Register Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
