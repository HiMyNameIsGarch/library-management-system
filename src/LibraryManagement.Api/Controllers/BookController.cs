using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Core.Entities;
using LibraryManagement.Core.Interfaces.Services;
using System.Text.Json;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok("Hello World");
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            var result = await _bookService.AddBook(book);
            if(result == null)
                return BadRequest("Book could not be added");
            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Book book)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string? title, [FromQuery] string? author, [FromQuery] string? genre)
        {
            throw new NotImplementedException();
        }
    }
}
