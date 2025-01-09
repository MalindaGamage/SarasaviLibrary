using SarasaviLibrary.Database;

namespace SarasaviLibrary.UI
{
    public partial class MainForm : Form
    {
        private readonly LibraryContext _context;

        public MainForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context; // Store the context
        }

        private void BtnLoan_Click(object sender, EventArgs e)
        {
            var loanForm = new LoanForm(_context); // Pass context
            loanForm.ShowDialog();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            var returnForm = new ReturnForm(_context); // Pass context
            returnForm.ShowDialog();
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReservationForm(_context); // Pass context
            reservationForm.ShowDialog();
        }

        private void BtnInquiry_Click(object sender, EventArgs e)
        {
            var inquiryForm = new InquiryForm(_context); // Pass context
            inquiryForm.ShowDialog();
        }

        private void BtnBookRegistration_Click(object sender, EventArgs e)
        {
            var bookRegistrationForm = new BookRegistrationForm(_context); // Pass context
            bookRegistrationForm.ShowDialog();
        }

        private void BtnUserRegistration_Click(object sender, EventArgs e)
        {
            var userRegistrationForm = new UserRegistrationForm(_context); // Pass context
            userRegistrationForm.ShowDialog();
        }
    }
}
