using SarasaviLibrary.Models;

namespace SarasaviLibrary.Services
{
    public class ReturnService
    {
        public void ReturnBook(Copy copy, List<Reservation> reservations)
        {
            copy.IsLoaned = false;
            var reservation = reservations.FirstOrDefault(r => r.BookNumber == copy.AccessionNumber);
            if (reservation != null)
            {
                Console.WriteLine($"Notify user {reservation.UserNumber} about availability.");
                reservations.Remove(reservation);
            }
        }
    }
}
