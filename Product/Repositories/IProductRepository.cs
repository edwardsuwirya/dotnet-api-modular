namespace Product.Repositories;

using Product.Entities;

public interface IProductRepository
{
    Task<List<ProductEntity>> GetAll();
    Task<ProductEntity> FindById(string id);
    Task Save(ProductEntity product);
    void Update(ProductEntity product);
    void Delete(ProductEntity product);
}