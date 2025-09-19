public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
}

public class ProductService : IProductService
{
    public Task<IEnumerable<Product>> GetAllAsync()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999 },
            new Product { Id = 2, Name = "Monitor", Price = 199 }
        };

        return Task.FromResult(products.AsEnumerable());
    }
}