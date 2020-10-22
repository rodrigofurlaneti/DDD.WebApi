using System.Collections.Generic;
namespace MVC.WebApi.Models
{
    public class ClientProduct
    {
        public int ClientProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}