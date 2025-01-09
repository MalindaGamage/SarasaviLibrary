namespace SarasaviLibrary.UI
{
    partial class ReturnForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtBookNumber;
        private System.Windows.Forms.TextBox TxtCopyNumber;
        private System.Windows.Forms.Button BtnReturn;

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
            this.TxtCopyNumber = new System.Windows.Forms.TextBox();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TxtBookNumber
            this.TxtBookNumber.Location = new System.Drawing.Point(12, 12);
            this.TxtBookNumber.Name = "TxtBookNumber";
            this.TxtBookNumber.Size = new System.Drawing.Size(260, 20);
            this.TxtBookNumber.PlaceholderText = "Enter Book Number";

            // TxtCopyNumber
            this.TxtCopyNumber.Location = new System.Drawing.Point(12, 38);
            this.TxtCopyNumber.Name = "TxtCopyNumber";
            this.TxtCopyNumber.Size = new System.Drawing.Size(260, 20);
            this.TxtCopyNumber.PlaceholderText = "Enter Copy Number";

            // BtnReturn
            this.BtnReturn.Location = new System.Drawing.Point(12, 64);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);

            // ReturnForm
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.TxtBookNumber);
            this.Controls.Add(this.TxtCopyNumber);
            this.Controls.Add(this.BtnReturn);
            this.Name = "ReturnForm";
            this.Text = "Return Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
