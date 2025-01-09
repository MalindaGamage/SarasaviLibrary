using SarasaviLibrary.Models;

namespace SarasaviLibrary.Database
{
    public class LibraryContext
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public List<Loan> Loans { get; set; }
        public List<Reservation> Reservations { get; set; }

        public LibraryContext()
        {
            Books = new List<Book>();
            Users = new List<User>();
            Loans = new List<Loan>();
            Reservations = new List<Reservation>();
        }
    }
}
