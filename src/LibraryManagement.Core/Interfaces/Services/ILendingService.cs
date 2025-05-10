using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.Interfaces.Services
{
    public interface ILendingService
    {
        Task<Result<bool>> BorrowBook(int bookId);
        Task<Result<bool>> ReturnBook(int bookId);
    }
}
