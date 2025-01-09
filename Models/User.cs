namespace SarasaviLibrary.Models
{
    public class User
    {
        public string UserNumber { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public bool IsVisitor { get; set; }
        public List<Loan> Loans { get; set; }

        public User()
        {
            Loans = new List<Loan>();
        }
    }
}
