using Interview.Application.Core.Data;
using Interview.Domain.Products;
using Interview.Infrastructure.Database;
using Interview.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Concurrent;

namespace Interview.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        string? connection = configuration.GetConnectionString("Local-SqlServer");

        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        services.AddScoped<IProductRepository, ProductRepostiory>();

        return services;
    }
}
