using SarasaviLibrary.Database;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.UI
{
    public partial class BookRegistrationForm : Form
    {
        private readonly LibraryContext _context;

        public BookRegistrationForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context; // Pass the LibraryContext instance
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string bookNumber = TxtBookNumber.Text;
            string title = TxtTitle.Text;

            if (string.IsNullOrWhiteSpace(bookNumber) || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please fill in both Book Number and Title.");
                return;
            }

            // Check if the book already exists
            if (_context.Books.Exists(b => b.BookNumber == bookNumber))
            {
                MessageBox.Show("A book with this number already exists.");
                return;
            }

            // Create and add a new book
            var book = new Book
            {
                BookNumber = bookNumber,
                Title = title
            };

            _context.Books.Add(book);

            MessageBox.Show($"Book '{title}' has been registered successfully.");
            TxtBookNumber.Clear();
            TxtTitle.Clear();
        }
    }
}
