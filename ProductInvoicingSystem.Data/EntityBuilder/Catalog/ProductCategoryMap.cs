using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInvoicingSystem.Core.Domain.Catalog;

namespace ProductInvoicingSystem.Data.EntityBuilder.Catalog
{
    public class ProductCategoryMap
    {
        public ProductCategoryMap(EntityTypeBuilder<ProductCategoryMapping> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasOne(t => t.Product)
                .WithMany(t => t.ProductCategoryMappings)
                .HasForeignKey(t => t.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            entityBuilder.HasOne(t => t.Category)
                .WithMany(t => t.ProductCategoryMappings)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}