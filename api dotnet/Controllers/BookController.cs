using api_dotnet.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Lord of the Rings",
                    Description = "The Lord of the Rings is an high fantasy novel, written between 1937-1949 by the English author and scholar J. R. R. Tolkien. All three parts of the masterpiece are steeped in magic and otherworldliness. The epic story centres around Frodo Baggins, who is forced to leave his hometown of the Shire to make a perilous journey across the realms of Middle-earth to destroy a powerful ring, deep inside the territories of the Dark Lord. Sauron, the dark lord, has gathered all the Rings of Power, minus the one ring - the ring that rules them all - and needs this for his campaign to conquer and rule all of middle-earth. There Frodo must destroy the ring forever and foil the dark lord in his evil purpose.",
                    Author = "J. R. R. Tolkien",
                }
            };

            return Ok(books);

        }
    }
}
