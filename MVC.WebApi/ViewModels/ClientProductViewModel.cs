using System.Collections.Generic;
namespace MVC.WebApi.ViewModel
{
    public class ClientProductViewModel
    {
        public int ClientProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public virtual IEnumerable<ClientViewModel> Clients { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}