using api_dotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
