using SarasaviLibrary.Database;
using SarasaviLibrary.Services;

namespace SarasaviLibrary.UI
{
    public partial class InquiryForm : Form
    {
        private readonly LibraryContext _context;
        private readonly InquiryService _inquiryService;

        public InquiryForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = TxtSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a title or author to search.");
                return;
            }

            // Use the InquiryService to find matching books
            var results = _inquiryService.CheckBookAvailability(searchText, _context);

            if (results.Any())
            {
                string message = "Books Found:\n" +
                                 string.Join("\n", results.Select(b => $"{b.BookNumber}: {b.Title}"));
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("No books found matching your search.");
            }
        }
    }
}
