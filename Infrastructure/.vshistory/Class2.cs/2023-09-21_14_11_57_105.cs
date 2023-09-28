using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureWorkshop.Infrastructure;

public class ApplicationContext : DbContext

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }