using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureWorkshop.Infrastructure;

public class ApplicationDbContext : DbContext

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }