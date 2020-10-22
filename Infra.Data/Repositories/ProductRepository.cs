using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;
namespace Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> SearchByName(string name)
        {
            return _DDDContext.Products.Where(p => p.Name == name);
        }
    }
}
