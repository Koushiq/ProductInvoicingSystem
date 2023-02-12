using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInvoicingSystem.Core.Domain.Catalog;

namespace ProductInvoicingSystem.Data.EntityBuilder.Catalog
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Price).IsRequired();
            entityBuilder.Property(t => t.CreatedAtUtc).IsRequired();

        }
    }
}