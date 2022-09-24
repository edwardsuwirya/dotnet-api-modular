using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Repositories;
using Product.Services;

namespace Product;

public static class ProductModule
{
    public static IServiceCollection RegisterProductModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductService, ProductService>();
        return services;
    }
}