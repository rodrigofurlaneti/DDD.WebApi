using DDD.Aplication.Interfaces;
using Domain.Entities;
using Domain.Services;
namespace DDD.Aplication.Services
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly ProductService _productService;
        public ProductAppService(ProductService productService)
            : base(productService)
        {
            _productService = productService;
        }
    }
}
