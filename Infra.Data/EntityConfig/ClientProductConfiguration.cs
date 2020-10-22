using Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace Infra.Data.EntityConfig
{
    public class ClientProductConfiguration : EntityTypeConfiguration<ClientProduct>
    {
        public ClientProductConfiguration()
        {
            HasKey(p => p.ClientProductId);
            //HasRequired(p => p.Clients).WithMany().HasForeignKey(p => p.ClientId);
            //HasRequired(p => p.Products).WithMany().HasForeignKey(p => p.Products);
        }
    }
}
