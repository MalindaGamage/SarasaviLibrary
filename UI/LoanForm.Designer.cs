namespace SarasaviLibrary.UI
{
    partial class LoanForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtUserNumber;
        private System.Windows.Forms.TextBox TxtBookNumber;
        private System.Windows.Forms.Button BtnLoan;

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
            this.TxtBookNumber = new System.Windows.Forms.TextBox();
            this.BtnLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TxtUserNumber
            this.TxtUserNumber.Location = new System.Drawing.Point(12, 12);
            this.TxtUserNumber.Name = "TxtUserNumber";
            this.TxtUserNumber.Size = new System.Drawing.Size(260, 20);
            this.TxtUserNumber.PlaceholderText = "Enter User Number";

            // TxtBookNumber
            this.TxtBookNumber.Location = new System.Drawing.Point(12, 38);
            this.TxtBookNumber.Name = "TxtBookNumber";
            this.TxtBookNumber.Size = new System.Drawing.Size(260, 20);
            this.TxtBookNumber.PlaceholderText = "Enter Book Number";

            // BtnLoan
            this.BtnLoan.Location = new System.Drawing.Point(12, 64);
            this.BtnLoan.Name = "BtnLoan";
            this.BtnLoan.Size = new System.Drawing.Size(75, 23);
            this.BtnLoan.Text = "Loan";
            this.BtnLoan.UseVisualStyleBackColor = true;
            this.BtnLoan.Click += new System.EventHandler(this.BtnLoan_Click);

            // LoanForm
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.TxtUserNumber);
            this.Controls.Add(this.TxtBookNumber);
            this.Controls.Add(this.BtnLoan);
            this.Name = "LoanForm";
            this.Text = "Loan Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
