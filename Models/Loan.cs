namespace SarasaviLibrary.Models
{
    public class Loan
    {
        public string LoanId { get; set; }
        public string UserNumber { get; set; }
        public string BookNumber { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
