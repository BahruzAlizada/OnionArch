using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnionArch.Application.Repositories;
using OnionArch.Domain.Entities;

namespace OnionArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository productReadRepository;
        private readonly IProductWriteRepository productWriteRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            this.productReadRepository = productReadRepository;
            this.productWriteRepository = productWriteRepository;
        }
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
           IQueryable<Product> products = productReadRepository.GetAll();
           var productList = products.ToList();
            return Ok(productList);
        }

        [HttpGet("Add")]
        public async Task<IActionResult> Add()
        {
            Product product = new Product { Id = Guid.NewGuid(), Created = DateTime.Now, Name = "Alma", Price = 3, Stock = 100 };

            await productWriteRepository.AddAsync(product);
            await productWriteRepository.SaveAsync();
            return Ok("OK");
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(string id)
        {
            Product product = await productReadRepository.GetByIdAsync(id);
            productWriteRepository.Remove(product);

            int result =  await productWriteRepository.SaveAsync();
            if (result == 1)
                return Ok("Ok");
            else
                return Ok("Error");
        }
    }
}
