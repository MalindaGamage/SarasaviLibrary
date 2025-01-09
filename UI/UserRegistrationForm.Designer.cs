namespace SarasaviLibrary.UI
{
    partial class UserRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtUserNumber;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNationalId;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.ComboBox CmbSex;
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
            this.TxtNationalId = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.CmbSex = new System.Windows.Forms.ComboBox();
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

            // TxtNationalId
            this.TxtNationalId.Location = new System.Drawing.Point(12, 64);
            this.TxtNationalId.Name = "TxtNationalId";
            this.TxtNationalId.Size = new System.Drawing.Size(260, 20);
            this.TxtNationalId.PlaceholderText = "Enter National ID";

            // TxtAddress
            this.TxtAddress.Location = new System.Drawing.Point(12, 90);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(260, 20);
            this.TxtAddress.PlaceholderText = "Enter Address";

            // CmbSex
            this.CmbSex.Location = new System.Drawing.Point(12, 116);
            this.CmbSex.Name = "CmbSex";
            this.CmbSex.Size = new System.Drawing.Size(260, 21);
            this.CmbSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.CmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // BtnRegister
            this.BtnRegister.Location = new System.Drawing.Point(12, 143);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

            // UserRegistrationForm
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.TxtUserNumber);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtNationalId);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.CmbSex);
            this.Controls.Add(this.BtnRegister);
            this.Name = "UserRegistrationForm";
            this.Text = "Register User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
