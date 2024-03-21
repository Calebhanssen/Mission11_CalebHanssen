using Microsoft.EntityFrameworkCore;

namespace Mission11_CalebHanssen.Models
{
    public class BookContext : DbContext

    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } 
    }
}
