using SarasaviLibrary.Database;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.Services
{
    public class ReservationService
    {
        public bool ReserveBook(User user, Book book, LibraryContext context)
        {
            if (book.Copies.All(c => c.IsLoaned))
            {
                var reservation = new Reservation
                {
                    ReservationId = Guid.NewGuid().ToString(),
                    UserNumber = user.UserNumber,
                    BookNumber = book.BookNumber,
                    ReservedDate = DateTime.Now
                };
                context.Reservations.Add(reservation);
                Console.WriteLine($"Book reserved for user {user.UserNumber}");
                return true;
            }
            Console.WriteLine("No reservation needed, copies are available.");
            return false;
        }
    }
}
