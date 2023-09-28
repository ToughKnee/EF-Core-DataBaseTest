using CleanArchitectureWorkshop.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class BooksContext : DbContext
{
    public BooksContext(DbContextOptions<BooksContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }

    public DbSet<Author> Authors {  get; set; }       
    public DbSet<Book> Books{  get; set; }
}
