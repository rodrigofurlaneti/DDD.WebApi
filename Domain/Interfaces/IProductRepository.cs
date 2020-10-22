using Domain.Entities;
using System.Collections.Generic;
namespace Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
