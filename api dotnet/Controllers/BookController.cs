using api_dotnet.Data;
using api_dotnet.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public BookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = await _dataContext.Books.ToListAsync();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _dataContext.Books.FindAsync(id);
            if(book is null)
                return NotFound("Book not found.");

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddBook(Book book)
        {
            _dataContext.Books.Add(book);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Books.ToListAsync());
        }
    }
}
