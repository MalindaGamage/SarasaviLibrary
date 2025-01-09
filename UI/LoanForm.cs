using SarasaviLibrary.Database;
using SarasaviLibrary.Services;

namespace SarasaviLibrary.UI
{
    public partial class LoanForm : Form
    {
        private readonly LibraryContext _context;
        private readonly LoanService _loanService;

        public LoanForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            var userNumber = TxtUserNumber.Text;
            var bookNumber = TxtBookNumber.Text;

            var user = _context.Users.FirstOrDefault(u => u.UserNumber == userNumber);
            var book = _context.Books.FirstOrDefault(b => b.BookNumber == bookNumber);
            var copy = book?.Copies.FirstOrDefault(c => !c.IsLoaned);

            if (user == null || book == null || copy == null)
            {
                MessageBox.Show("User, book, or available copy not found.");
                return;
            }

            if (_loanService.BorrowBook(user, copy))
            {
                MessageBox.Show($"Book '{book.Title}' borrowed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to borrow the book. Either it's already loaned or user exceeded the borrowing limit.");
            }
        }
    }
}
