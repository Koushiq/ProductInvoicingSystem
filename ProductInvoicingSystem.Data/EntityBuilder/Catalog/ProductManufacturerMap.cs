using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInvoicingSystem.Core.Domain.Catalog;

namespace ProductInvoicingSystem.Data.EntityBuilder.Catalog
{
    public class ProductManufacturerMap
    {
        public ProductManufacturerMap(EntityTypeBuilder<ProductManufacturerMapping> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasOne(t => t.Manufacturer)
                .WithMany(t => t.ProductManufacturerMappings).HasForeignKey()
                .OnDelete(DeleteBehavior.Cascade);
            entityBuilder.HasOne(t => t.Product)
                .WithMany(t => t.ProductManufacturerMappings).HasForeignKey()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}