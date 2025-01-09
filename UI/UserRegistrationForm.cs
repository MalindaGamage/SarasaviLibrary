using System;
using System.Windows.Forms;
using SarasaviLibrary.Database;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.UI
{
    public partial class UserRegistrationForm : Form
    {
        private readonly LibraryContext _context;

        public UserRegistrationForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context; // Pass the LibraryContext instance
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string userNumber = TxtUserNumber.Text;
            string name = TxtName.Text;

            if (string.IsNullOrWhiteSpace(userNumber) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please fill in both User Number and Name.");
                return;
            }

            // Check if the user already exists
            if (_context.Users.Exists(u => u.UserNumber == userNumber))
            {
                MessageBox.Show("A user with this number already exists.");
                return;
            }

            // Create and add a new user
            var user = new User
            {
                UserNumber = userNumber,
                Name = name,
                IsVisitor = false // Default: registered users are not visitors
            };

            _context.Users.Add(user);

            MessageBox.Show($"User '{name}' has been registered successfully.");
            TxtUserNumber.Clear();
            TxtName.Clear();
        }
    }
}
