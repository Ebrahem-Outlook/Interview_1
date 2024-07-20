using Interview.Domain.Core.BaseType;
using Interview.Domain.Products.Events;

namespace Interview.Domain.Products;

public sealed class Product : AggregateRoot
{
    public Product(string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = CreatedOn;
    }

    private Product() { }

    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public decimal Price { get; private set; } = default!;
    public int Stock { get; private set; } = default!;
    public DateTime CreatedOn { get; }
    public DateTime UpdatedOn { get; private set; }

    public static Product Create(string name, string description, decimal price, int stock)
    {
        Product product = new(name,description, price, stock);

        product.Raise(new ProductCreatedDomainEvent(product.Id, product.Name, product.Description, product.Price, product.Stock, product.CreatedOn));

        return product;
    }

    public void Update(Guid id, string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        UpdatedOn = DateTime.UtcNow;

        Raise(new ProductUpdatedDomainevent(Id, Name, Description, Price, Stock, CreatedOn, UpdatedOn));
    }
}
