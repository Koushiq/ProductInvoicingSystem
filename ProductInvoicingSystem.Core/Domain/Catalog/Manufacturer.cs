namespace ProductInvoicingSystem.Core.Domain.Catalog
{
    public class Manufacturer : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
    }
}
