using System;
using System.Linq;
using SarasaviLibrary.Database;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.Services
{
    public class BookRegistrationService
    {
        private readonly LibraryContext _context;

        public BookRegistrationService(LibraryContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Registers a new book in the library.
        /// </summary>
        /// <param name="bookNumber">Unique book number.</param>
        /// <param name="title">Title of the book.</param>
        /// <param name="author">Author of the book.</param>
        /// <param name="publisher">Publisher of the book.</param>
        /// <param name="isReference">Indicates if the book is reference-only.</param>
        /// <param name="copyCount">Number of copies to register (max 10).</param>
        /// <returns>True if registration is successful, false otherwise.</returns>
        public bool RegisterBook(string bookNumber, string title, string author, string publisher, bool isReference, int copyCount)
        {
            // Validate copy count
            if (copyCount > 10)
            {
                Console.WriteLine("Cannot register more than 10 copies of a book.");
                return false;
            }

            // Check if the book already exists
            if (_context.Books.Any(b => b.BookNumber == bookNumber))
            {
                Console.WriteLine("Book with this number already exists.");
                return false;
            }

            // Create a new book
            var book = new Book
            {
                BookNumber = bookNumber,
                Title = title,
                Author = author,
                Publisher = publisher,
                IsReference = isReference
            };

            // Add copies to the book
            for (int i = 1; i <= copyCount; i++)
            {
                var accessionNumber = $"{bookNumber}-{i:0000}";
                book.Copies.Add(new Copy
                {
                    AccessionNumber = accessionNumber,
                    IsBorrowable = !isReference,
                    IsLoaned = false
                });
            }

            // Add book to the database context
            _context.Books.Add(book);
            Console.WriteLine("Book registered successfully with copies.");
            return true;
        }

        /// <summary>
        /// Displays all registered books with their copies.
        /// </summary>
        public void DisplayBooks()
        {
            Console.WriteLine("Registered Books:");
            foreach (var book in _context.Books)
            {
                Console.WriteLine($"BookNumber: {book.BookNumber}, Title: {book.Title}, Author: {book.Author}");
                foreach (var copy in book.Copies)
                {
                    var status = copy.IsLoaned ? "Loaned Out" : "Available";
                    Console.WriteLine($"  Copy: {copy.AccessionNumber}, Status: {status}");
                }
            }
        }
    }
}
