using DDD.Aplication.Interfaces;
using Domain.Entities;
using Domain.Services;
namespace DDD.Aplication.Services
{
    public class ClientProductAppService : AppServiceBase<ClientProduct>, IClientProductAppService
    {
        private readonly ClientProductService _clientproductService;
        public ClientProductAppService(ClientProductService clientproductService)
            : base(clientproductService)
        {
            _clientproductService = clientproductService;
        }
    }
}
