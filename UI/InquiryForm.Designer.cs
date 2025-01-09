namespace SarasaviLibrary.UI
{
    partial class InquiryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;

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
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TxtSearch
            this.TxtSearch.Location = new System.Drawing.Point(12, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(260, 20);
            this.TxtSearch.PlaceholderText = "Enter Book Title or Author";

            // BtnSearch
            this.BtnSearch.Location = new System.Drawing.Point(12, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // InquiryForm
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnSearch);
            this.Name = "InquiryForm";
            this.Text = "Inquire Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
