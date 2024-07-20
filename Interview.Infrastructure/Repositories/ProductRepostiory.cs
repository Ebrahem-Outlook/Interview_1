using Interview.Application.Core.Data;
using Interview.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Interview.Infrastructure.Repositories;

internal sealed class ProductRepostiory(IDbContext dbContext) : IProductRepository
{
    public async Task AddAsync(Product product, CancellationToken cancellationToken)
    {
        await dbContext.Set<Product>().AddAsync(product, cancellationToken);
    }

    public void Update(Product product)
    {
        dbContext.Set<Product>().Update(product);
    }

    public void Delete(Product product)
    {
        dbContext.Set<Product>().Remove(product);
    }

    public async Task<List<Product>?> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>().ToListAsync(cancellationToken);
    }

    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }

    public async Task<List<Product>?> GetByNameAsync(Product product, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>().Where(p => p.Name == product.Name).ToListAsync(cancellationToken);
    }
}
