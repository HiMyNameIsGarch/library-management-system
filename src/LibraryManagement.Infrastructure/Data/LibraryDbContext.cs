using LibraryManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Data
{
    public class LibraryDbContext : DbContext
    {
        // DbSet properties for the entities in the database
        public required DbSet<Book> Books { get; set; }

        // default contructor
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=library.db",
                    b => b.MigrationsAssembly("LibraryManagement.Api"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Book entity
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.Id);  // Explicitly define primary key
                entity.Property(b => b.Id).ValueGeneratedOnAdd();  // Auto-increment

                // Add other configurations as needed
                entity.Property(b => b.Title).IsRequired().HasMaxLength(100);
                entity.Property(b => b.Author).IsRequired().HasMaxLength(100);
                entity.Property(b => b.ISBN).IsRequired().HasMaxLength(20);
                entity.Property(b => b.TotalCopies).IsRequired();
                entity.Property(b => b.AvailableCopies).IsRequired();
            });
        }
    }
}
