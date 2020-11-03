using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
namespace Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService 
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
            : base(clientRepository)
        {
            _clientRepository = clientRepository;
        }
    }
}
