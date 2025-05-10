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
            return await _bookRepository.GetAll();
        }

        public async Task<Book?> GetBookById(int id)
        {
            return await _bookRepository.GetById(id);
        }

        public async Task<Result<Book>> AddBook(Book book)
        {
            try
            {
                await _bookRepository.Add(book);
                return Result<Book>.Success(book);
            }
            catch (Exception ex)
            {
                return Result<Book>.Fail($"Error adding book: {ex.Message}");
            }
        }

        public async Task<Result<bool>> UpdateBook(Book book)
        {
            try
            {
                var existingBook = await _bookRepository.GetById(book.Id);
                if (existingBook == null)
                    return Result<bool>.Fail("Book not found");

                // Prevent invalid copies update
                if (book.TotalCopies < existingBook.TotalCopies - existingBook.AvailableCopies)
                    return Result<bool>.Fail("Cannot reduce total copies below currently borrowed count");

                // Maintain consistency
                book.AvailableCopies = existingBook.AvailableCopies + (book.TotalCopies - existingBook.TotalCopies);

                await _bookRepository.Update(book);
                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail($"Database error: {ex.Message}");
            }
        }

        public async Task<Result<bool>> DeleteBook(int id)
        {
            try
            {
                var book = await _bookRepository.GetById(id);
                if (book == null)
                    return Result<bool>.Fail("Book not found");

                if (book.AvailableCopies < book.TotalCopies)
                    return Result<bool>.Fail("Cannot delete book with borrowed copies");

                await _bookRepository.Delete(id);
                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail($"Database error: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Book>> SearchBooks(string? title, string? author)
        {
            var books = await _bookRepository.Search(title, author);
            return books;
        }

    }
}
