using System;
namespace MVC.WebApi.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrarionDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}