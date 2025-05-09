using LibraryManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Data
{
    public class LibraryDbContext : DbContext
    {
        // DbSet properties for the entities in the database
        public DbSet<Book>? Books { get; set; }

        // default contructor
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }
    }
}
