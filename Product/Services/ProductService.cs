using Product.Entities;
using Product.Repositories;

namespace Product.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository) => _productRepository = productRepository;


    public Task<List<ProductEntity>> List()
    {
        return _productRepository.GetAll();
    }

    public Task<ProductEntity> RegisterProduct(ProductEntity product)
    {
        throw new NotImplementedException();
    }

    public Task<ProductEntity> UpdateProduct(ProductEntity newProduct)
    {
        throw new NotImplementedException();
    }

    public Task<ProductEntity> DeleteProduct(ProductEntity deleteProduct)
    {
        throw new NotImplementedException();
    }
}