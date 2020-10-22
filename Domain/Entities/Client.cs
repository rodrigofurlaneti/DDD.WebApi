using System;
namespace Domain.Entities
{
    public class Client
    {
        //Propriedades da classe Client = ESTADO
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrarionDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public bool Active { get; set; }

        //Metodos da classe = AÇÃO
        public bool SpecialClient(Client client)
        {
            return client.Active && DateTime.Now.Year - client.RegistrarionDate.Year >= 5;
        }
    }
}
