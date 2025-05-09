using LibraryManagement.Core.Interfaces.Repositories;
using LibraryManagement.Core.Interfaces.Services;
using LibraryManagement.Core.Services;
using LibraryManagement.Infrastructure.Data;
using LibraryManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure DbContext with SQLite ( or any other database provider )
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlite("Data Source=library.db"));

// Register repositories
builder.Services.AddScoped<IBookRepository, BookRepository>();

// Register services
builder.Services.AddScoped<IBookService, BookService>();

// Build the application
var app = builder.Build();

// Enable routing
app.UseRouting();

// Map controllers
app.MapControllers();

// finally run the application with the configured services
app.Run();
