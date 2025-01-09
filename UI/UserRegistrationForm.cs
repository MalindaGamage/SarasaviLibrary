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
            string nationalId = TxtNationalId.Text;
            string address = TxtAddress.Text;
            string sex = CmbSex.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(userNumber) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(nationalId) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(sex))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if the user already exists
            if (_context.Users.Exists(u => u.UserNumber == userNumber || u.NationalId == nationalId))
            {
                MessageBox.Show("A user with this number or National ID already exists.");
                return;
            }

            // Create and add a new user
            var user = new User
            {
                UserNumber = userNumber,
                Name = name,
                NationalId = nationalId,
                Address = address,
                Sex = sex,
                IsVisitor = false // Default: registered users are not visitors
            };

            _context.Users.Add(user);

            MessageBox.Show($"User '{name}' has been registered successfully.");
            TxtUserNumber.Clear();
            TxtName.Clear();
            TxtNationalId.Clear();
            TxtAddress.Clear();
            CmbSex.SelectedIndex = -1;
        }
    }
}
