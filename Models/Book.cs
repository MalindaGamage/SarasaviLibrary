namespace SarasaviLibrary.Models
{
    public class Book
    {
        public string BookNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public bool IsReference { get; set; }
        public List<Copy> Copies { get; set; }

        public Book()
        {
            Copies = new List<Copy>();
        }
    }
}
