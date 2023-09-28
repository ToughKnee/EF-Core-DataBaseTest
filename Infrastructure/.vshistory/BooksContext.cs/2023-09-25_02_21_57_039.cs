using CleanArchitectureWorkshop.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class BooksContext : DbContext
{
/*    public BooksContext(DbContextOptions<BooksContext> options) : base(options)
    {

    }
*/
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
 //       optionsBuilder.UseSqlServer("Server=localhost;Database=master;Encrypt = Optional;Uid=Book;Pwd=book;");
        optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;Encrypt=Optional");
    }

    public DbSet<Author> Authors {  get; set; }       
    public DbSet<Book> Books{  get; set; }
}
