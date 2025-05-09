using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.Interfaces.Repositories
{
    // IBookRepository interface defines the contract for book-related data operations.
    // It includes methods for adding, updating, deleting, and retrieving books.
    // Additionally, it provides a method for searching books based on various criteria.
    public interface IBookRepository
    {
        // The methods in this interface returns a Task based on the Book entity
        Task Add(Book book);

        // The methods in this interface returns a Task based on the Book entity
        Task Update(Book book);

        // The method get an ID and returns a Task for deleting a book
        Task Delete(int id);

        // This can be NULL as the book may not exist in the database
        Task<Book?> GetById(int id);

        // Return an enumerable object of books
        Task<IEnumerable<Book>> GetAll();

        // Search for book based on various criteria ( for the future I need to handle the case of no parameters passed)
        Task<IEnumerable<Book>> Search(string? title, string? author, string? genre);
    }
}
