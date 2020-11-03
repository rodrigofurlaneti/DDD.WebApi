using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Collections.Generic;
namespace Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
            : base (productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> SearchByName(string name)
        {
            return _productRepository.SearchByName(name);
        }
    }
}
