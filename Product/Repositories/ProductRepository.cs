using Product.Entities;

namespace Product.Repositories;

public class ProductRepository : IProductRepository
{

    public Task<List<ProductEntity>> GetAll()
    {
        return Task.Run(() => new List<ProductEntity>
        {
            new()
            {
                Id = "123",
                ProductName = "Cumi Goreng Tepung"
            }
        });
    }

    public Task<ProductEntity> FindById(string id)
    {
        throw new NotImplementedException();
    }

    public Task Save(ProductEntity product)
    {
        throw new NotImplementedException();
    }

    public void Update(ProductEntity product)
    {
        throw new NotImplementedException();
    }

    public void Delete(ProductEntity product)
    {
        throw new NotImplementedException();
    }
}