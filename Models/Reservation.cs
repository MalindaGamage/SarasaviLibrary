namespace SarasaviLibrary.Models
{
    public class Reservation
    {
        public string ReservationId { get; set; }
        public string UserNumber { get; set; }
        public string BookNumber { get; set; }
        public DateTime ReservedDate { get; set; }
    }
}
