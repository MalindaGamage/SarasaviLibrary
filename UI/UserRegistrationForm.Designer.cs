namespace SarasaviLibrary.UI
{
    partial class UserRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtUserNumber;
        private System.Windows.Forms.TextBox TxtName;
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
            this.TxtUserNumber = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TxtUserNumber
            this.TxtUserNumber.Location = new System.Drawing.Point(12, 12);
            this.TxtUserNumber.Name = "TxtUserNumber";
            this.TxtUserNumber.Size = new System.Drawing.Size(260, 20);
            this.TxtUserNumber.PlaceholderText = "Enter User Number";

            // TxtName
            this.TxtName.Location = new System.Drawing.Point(12, 38);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(260, 20);
            this.TxtName.PlaceholderText = "Enter User Name";

            // BtnRegister
            this.BtnRegister.Location = new System.Drawing.Point(12, 64);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

            // UserRegistrationForm
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.TxtUserNumber);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnRegister);
            this.Name = "UserRegistrationForm";
            this.Text = "Register User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
