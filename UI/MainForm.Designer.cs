namespace SarasaviLibrary.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button BtnLoan;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnReservation;
        private System.Windows.Forms.Button BtnInquiry;
        private System.Windows.Forms.Button BtnBookRegistration;
        private System.Windows.Forms.Button BtnUserRegistration;

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
            this.BtnLoan = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnReservation = new System.Windows.Forms.Button();
            this.BtnInquiry = new System.Windows.Forms.Button();
            this.BtnBookRegistration = new System.Windows.Forms.Button();
            this.BtnUserRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // BtnLoan
            this.BtnLoan.Location = new System.Drawing.Point(50, 30);
            this.BtnLoan.Name = "BtnLoan";
            this.BtnLoan.Size = new System.Drawing.Size(150, 30);
            this.BtnLoan.Text = "Loan Book";
            this.BtnLoan.UseVisualStyleBackColor = true;
            this.BtnLoan.Click += new System.EventHandler(this.BtnLoan_Click);

            // BtnReturn
            this.BtnReturn.Location = new System.Drawing.Point(50, 70);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(150, 30);
            this.BtnReturn.Text = "Return Book";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);

            // BtnReservation
            this.BtnReservation.Location = new System.Drawing.Point(50, 110);
            this.BtnReservation.Name = "BtnReservation";
            this.BtnReservation.Size = new System.Drawing.Size(150, 30);
            this.BtnReservation.Text = "Reserve Book";
            this.BtnReservation.UseVisualStyleBackColor = true;
            this.BtnReservation.Click += new System.EventHandler(this.BtnReservation_Click);

            // BtnInquiry
            this.BtnInquiry.Location = new System.Drawing.Point(50, 150);
            this.BtnInquiry.Name = "BtnInquiry";
            this.BtnInquiry.Size = new System.Drawing.Size(150, 30);
            this.BtnInquiry.Text = "Inquire Book";
            this.BtnInquiry.UseVisualStyleBackColor = true;
            this.BtnInquiry.Click += new System.EventHandler(this.BtnInquiry_Click);

            // BtnBookRegistration
            this.BtnBookRegistration.Location = new System.Drawing.Point(50, 190);
            this.BtnBookRegistration.Name = "BtnBookRegistration";
            this.BtnBookRegistration.Size = new System.Drawing.Size(150, 30);
            this.BtnBookRegistration.Text = "Register Book";
            this.BtnBookRegistration.UseVisualStyleBackColor = true;
            this.BtnBookRegistration.Click += new System.EventHandler(this.BtnBookRegistration_Click);

            // BtnUserRegistration
            this.BtnUserRegistration.Location = new System.Drawing.Point(50, 230);
            this.BtnUserRegistration.Name = "BtnUserRegistration";
            this.BtnUserRegistration.Size = new System.Drawing.Size(150, 30);
            this.BtnUserRegistration.Text = "Register User";
            this.BtnUserRegistration.UseVisualStyleBackColor = true;
            this.BtnUserRegistration.Click += new System.EventHandler(this.BtnUserRegistration_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.BtnLoan);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnReservation);
            this.Controls.Add(this.BtnInquiry);
            this.Controls.Add(this.BtnBookRegistration);
            this.Controls.Add(this.BtnUserRegistration);
            this.Name = "MainForm";
            this.Text = "Sarasavi Library";
            this.ResumeLayout(false);
        }
    }
}
