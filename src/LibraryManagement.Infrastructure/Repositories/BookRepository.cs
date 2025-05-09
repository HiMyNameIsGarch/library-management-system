using LibraryManagement.Core.Entities;
using LibraryManagement.Core.Interfaces.Repositories;
using LibraryManagement.Infrastructure.Data;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task Add(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Book?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> Search(string? title, string? author, string? genre)
        {
            throw new NotImplementedException();
        }
    }
}
