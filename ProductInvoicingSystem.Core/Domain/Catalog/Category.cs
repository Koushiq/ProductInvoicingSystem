namespace ProductInvoicingSystem.Core.Domain.Catalog
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentCategoryId { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
    }
}
