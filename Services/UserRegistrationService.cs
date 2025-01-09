using SarasaviLibrary.Database;
using SarasaviLibrary.Models;
using System.Text.RegularExpressions;

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
        /// Validates user input and registers a new user in the library.
        /// </summary>
        /// <param name="userNumber">Unique user number.</param>
        /// <param name="name">Name of the user.</param>
        /// <param name="nationalId">National identity card number.</param>
        /// <param name="address">Address of the user.</param>
        /// <param name="sex">Gender of the user (e.g., Male, Female).</param>
        /// <param name="isVisitor">Indicates if the user is a visitor.</param>
        /// <returns>True if registration is successful, false otherwise.</returns>
        public bool RegisterUser(string userNumber, string name, string nationalId, string address, string sex, bool isVisitor)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(userNumber))
            {
                Console.WriteLine("User number is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("User name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(nationalId))
            {
                Console.WriteLine("National ID is required.");
                return false;
            }
            if (!IsValidNationalId(nationalId))
            {
                Console.WriteLine("Invalid National ID format.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Address is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(sex) || !IsValidSex(sex))
            {
                Console.WriteLine("Valid sex (Male, Female, Other) is required.");
                return false;
            }

            // Check for duplicates
            if (_context.Users.Any(u => u.UserNumber == userNumber))
            {
                Console.WriteLine("A user with this number already exists.");
                return false;
            }
            if (_context.Users.Any(u => u.NationalId == nationalId))
            {
                Console.WriteLine("A user with this National ID already exists.");
                return false;
            }

            // Create and add a new user
            var user = new User
            {
                UserNumber = userNumber,
                Name = name,
                NationalId = nationalId,
                Address = address,
                Sex = sex,
                IsVisitor = isVisitor
            };

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
                Console.WriteLine($"UserNumber: {user.UserNumber}, Name: {user.Name}, Sex: {user.Sex}, Visitor: {user.IsVisitor}");
            }
        }

        /// <summary>
        /// Validates the format of the National ID.
        /// </summary>
        /// <param name="nationalId">National ID to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        private bool IsValidNationalId(string nationalId)
        {
            // Example validation: National ID must be numeric and 10-12 digits long
            return Regex.IsMatch(nationalId, @"^\d{10,12}$");
        }

        /// <summary>
        /// Validates the Sex input.
        /// </summary>
        /// <param name="sex">Sex to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        private bool IsValidSex(string sex)
        {
            return sex.Equals("Male", StringComparison.OrdinalIgnoreCase) ||
                   sex.Equals("Female", StringComparison.OrdinalIgnoreCase) ||
                   sex.Equals("Other", StringComparison.OrdinalIgnoreCase);
        }
    }
}
