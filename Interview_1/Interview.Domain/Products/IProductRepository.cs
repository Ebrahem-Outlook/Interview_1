namespace Interview.Domain.Products;

public interface IProductRepository
{
    // Commands.
    Task AddAsync(Product product, CancellationToken cancellationToken);
    void Update(Product product);
    void Delete(Product product);

    Task<List<Product>?> GetAllAsync(CancellationToken cancellationToken);
    Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Product>?> GetByNameAsync(Product product, CancellationToken cancellationToken);
}
