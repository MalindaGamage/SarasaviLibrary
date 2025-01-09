using SarasaviLibrary.Database;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.Services
{
    public class InquiryService
    {
        public List<Book> CheckBookAvailability(string searchText, LibraryContext context)
        {
            // Search by book title or author
            return context.Books
                .Where(b => b.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                            b.Copies.Any(c => c.AccessionNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
