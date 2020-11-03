using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Repositories;
using MVC.WebApi.ViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
namespace MVC.WebApi.Controllers
{
    public class ClientController : ApiController
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();
        // GET: api/Client
        public IEnumerable<string> Get()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientRepository.GetAll());
            string json = JsonConvert.SerializeObject(clientViewModel);
            return new string[] { json };
        }

        // GET: api/Client/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Client
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
