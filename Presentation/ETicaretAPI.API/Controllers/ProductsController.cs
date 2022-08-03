using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories.ProductRepo;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;


        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        [HttpGet]
        public async void GetAsync()
        {

            await _productWriteRepository.AddRangeAsync(new() {

            new() {Name ="product1", Id= Guid.NewGuid(),CreateDate=DateTime.UtcNow,Stock=1,Price=5},
            new() {Name ="product2", Id= Guid.NewGuid(),CreateDate=DateTime.UtcNow,Stock=2,Price=10},
            new() {Name ="product3", Id= Guid.NewGuid(),CreateDate=DateTime.UtcNow,Stock=3,Price=15}
 
            }); 
                
            
        }
    }
}
