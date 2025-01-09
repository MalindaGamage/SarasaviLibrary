namespace SarasaviLibrary.UI
{
    partial class ReservationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtUserNumber;
        private System.Windows.Forms.TextBox TxtBookNumber;
        private System.Windows.Forms.Button BtnReserve;

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
            this.BtnReserve = new System.Windows.Forms.Button();
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

            // BtnReserve
            this.BtnReserve.Location = new System.Drawing.Point(12, 64);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(75, 23);
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);

            // ReservationForm
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.TxtUserNumber);
            this.Controls.Add(this.TxtBookNumber);
            this.Controls.Add(this.BtnReserve);
            this.Name = "ReservationForm";
            this.Text = "Reserve Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
