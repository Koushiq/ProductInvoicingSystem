namespace ProductInvoicingSystem.Core.Domain.Catalog
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
    }
}
