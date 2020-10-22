using Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);
            Property(p => p.Name).IsRequired().HasMaxLength(250);
            Property(p => p.Value).IsRequired();
        }
    }
}
