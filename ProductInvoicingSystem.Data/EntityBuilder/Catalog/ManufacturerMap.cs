using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInvoicingSystem.Core.Domain.Catalog;

namespace ProductInvoicingSystem.Data.EntityBuilder.Catalog
{
    public class ManufacturerMap
    {
        public ManufacturerMap(EntityTypeBuilder<Manufacturer> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.CreatedAtUtc).IsRequired();
        }
    }
}