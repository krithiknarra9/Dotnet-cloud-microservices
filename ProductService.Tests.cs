public class ProductServiceTests
{
    [Fact]
    public async Task GetAllAsync_ReturnsProductList()
    {
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(new List<Product> { new Product { Name = "Laptop" } });

        var service = new ProductService(mockRepo.Object);
        var result = await service.GetAllAsync();

        Assert.Single(result);
    }
}