using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArch.Application.Abstractions;
using OnionArch.Domain.Entities;

namespace OnionArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            List<Product> products = productService.GetProducts();
            return Ok(products);
        }
    }
}
