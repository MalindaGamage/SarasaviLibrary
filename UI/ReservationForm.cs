using System;
using System.Linq;
using System.Windows.Forms;
using SarasaviLibrary.Database;
using SarasaviLibrary.Services;

namespace SarasaviLibrary.UI
{
    public partial class ReservationForm : Form
    {
        private readonly LibraryContext _context;
        private readonly ReservationService _reservationService;

        public ReservationForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                string userNumber = TxtUserNumber?.Text; // Add null check
                string bookNumber = TxtBookNumber?.Text; // Add null check

                if (string.IsNullOrWhiteSpace(userNumber) || string.IsNullOrWhiteSpace(bookNumber))
                {
                    MessageBox.Show("Please fill in both User Number and Book Number.");
                    return;
                }

                var user = _context?.Users?.FirstOrDefault(u => u.UserNumber == userNumber);
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                var book = _context?.Books?.FirstOrDefault(b => b.BookNumber == bookNumber);
                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                if (_reservationService?.ReserveBook(user, book, _context) == true)
                {
                    MessageBox.Show($"Book '{book.Title}' reserved successfully for user '{user.Name}'.");
                }
                else
                {
                    MessageBox.Show("Failed to reserve the book.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\n{ex.StackTrace}");
            }
        }
    }
}
