using System;
using System.Linq;
using System.Windows.Forms;
using SarasaviLibrary.Database;
using SarasaviLibrary.Services;

namespace SarasaviLibrary.UI
{
    public partial class ReturnForm : Form
    {
        private readonly LibraryContext _context;
        private readonly ReturnService _returnService;

        public ReturnForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            string bookNumber = TxtBookNumber.Text;
            string copyNumber = TxtCopyNumber.Text;

            var book = _context.Books.FirstOrDefault(b => b.BookNumber == bookNumber);
            var copy = book?.Copies.FirstOrDefault(c => c.AccessionNumber == copyNumber && c.IsLoaned);

            if (copy == null)
            {
                MessageBox.Show("Book copy not found or not loaned.");
                return;
            }

            _returnService.ReturnBook(copy, _context.Reservations);
            MessageBox.Show("Book returned successfully.");
        }
    }
}
