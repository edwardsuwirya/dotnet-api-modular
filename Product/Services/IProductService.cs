namespace Product.Services;

using Product.Entities;

public interface IProductService
{
    Task<List<ProductEntity>> List();
    Task<ProductEntity> RegisterProduct(ProductEntity product);
    Task<ProductEntity> UpdateProduct(ProductEntity newProduct);
    Task<ProductEntity> DeleteProduct(ProductEntity deleteProduct);
}