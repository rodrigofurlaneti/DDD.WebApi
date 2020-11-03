using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
namespace Domain.Services
{
    public class ClientProductService : ServiceBase<ClientProduct>, IClientProductService
    {
        private readonly IClientProductRepository _clientProductRepository;
        public ClientProductService(IClientProductRepository clientProductRepository)
            : base (clientProductRepository)
        {
            _clientProductRepository = clientProductRepository;
        }
    }
}
