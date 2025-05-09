// src/LibraryManagement.Core/Services/BookService.cs
using LibraryManagement.Core.Entities;
using LibraryManagement.Core.Interfaces.Repositories;
using LibraryManagement.Core.Interfaces.Services;

namespace LibraryManagement.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public async Task<Book?> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<Book>> AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<bool>> UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<bool>> DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> SearchBooks(string? title, string? author, string? genre)
        {
            throw new NotImplementedException();
        }

    }
}
