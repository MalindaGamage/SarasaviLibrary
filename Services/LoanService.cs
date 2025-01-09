using SarasaviLibrary.Models;

namespace SarasaviLibrary.Services
{
    public class LoanService
    {
        public bool BorrowBook(User user, Copy copy)
        {
            if (!copy.IsBorrowable || copy.IsLoaned || user.Loans.Count >= 5)
                return false;

            var loan = new Loan
            {
                LoanId = Guid.NewGuid().ToString(),
                UserNumber = user.UserNumber,
                BookNumber = copy.AccessionNumber,
                BorrowedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14),
                IsReturned = false
            };
            user.Loans.Add(loan);
            copy.IsLoaned = true;
            return true;
        }
    }
}
