using CleanArchitectureWorkshop.Application.Repositories;
using CleanArchitectureWorkshop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureWorkshop.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureLayerServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer("Server=localhost;Initial Catalog=CleanArchitectureWorkshop.Database;Trusted_Connection=True;Encrypt=Optional"));

        services.AddScoped<ITeamsRepository, TeamsRepository>();

        return services;
    }
}
