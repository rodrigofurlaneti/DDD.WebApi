using DDD.Aplication.Interfaces;
using Domain.Entities;
using Domain.Services;
namespace DDD.Aplication.Services
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly ClientService _clientService;
        public ClientAppService(ClientService clientService)
            : base(clientService)
        {
            _clientService = clientService;
        }
    }
}