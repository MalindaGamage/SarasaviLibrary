using SarasaviLibrary.Database;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.Services
{
    public class UserRegistrationService
    {
        private readonly LibraryContext _context;

        public UserRegistrationService(LibraryContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Registers a new user in the library.
        /// </summary>
        /// <param name="userNumber">Unique user number.</param>
        /// <param name="name">Name of the user.</param>
        /// <param name="nationalId">National identity card number.</param>
        /// <param name="address">Address of the user.</param>
        /// <param name="isVisitor">Indicates if the user is a visitor.</param>
        /// <returns>True if registration is successful, false otherwise.</returns>
        public bool RegisterUser(string userNumber, string name, string nationalId, string address, bool isVisitor)
        {
            // Check if the user already exists
            if (_context.Users.Any(u => u.UserNumber == userNumber || u.NationalId == nationalId))
            {
                Console.WriteLine("User with this number or national ID already exists.");
                return false;
            }

            // Create new user
            var user = new User
            {
                UserNumber = userNumber,
                Name = name,
                NationalId = nationalId,
                Address = address,
                IsVisitor = isVisitor
            };

            // Add user to the database context
            _context.Users.Add(user);
            Console.WriteLine("User registered successfully.");
            return true;
        }

        /// <summary>
        /// Displays all registered users.
        /// </summary>
        public void DisplayUsers()
        {
            Console.WriteLine("Registered Users:");
            foreach (var user in _context.Users)
            {
                Console.WriteLine($"UserNumber: {user.UserNumber}, Name: {user.Name}, Visitor: {user.IsVisitor}");
            }
        }
    }
}
