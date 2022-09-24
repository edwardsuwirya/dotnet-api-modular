using Microsoft.AspNetCore.Mvc;
using Product.Services;
using Shared.Controllers;

namespace Product.Controllers;

public class ProductsController : BaseController
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProduct()
    {
        var products = await _productService.List();
        return Ok(products);
    }
}