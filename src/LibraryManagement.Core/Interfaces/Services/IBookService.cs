using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.Interfaces.Services
{
    // IBookService interface defines the contract for book-related operations
    // that can be performed in the API.
    public interface IBookService
    {
        // Returns the enumerable object of all the books in the database
        Task<IEnumerable<Book>> GetAllBooks();

        // Returns a single book based on the ID passed, can be NULL
        Task<Book?> GetBookById(int id);

        // Return the result of adding a book in the database
        Task<Result<Book>> AddBook(Book book);

        // return the result of type bool of updating a book in the database
        Task<Result<bool>> UpdateBook(Book book);

        // return the result of type bool of deleting a book based on the book
        // ID from the database
        Task<Result<bool>> DeleteBook(int id);

        // searches multiple books based on the various criteria passed and returns
        // an enumerable object of books
        Task<IEnumerable<Book>> SearchBooks(string? title, string? author, string? genre);
    }
}
