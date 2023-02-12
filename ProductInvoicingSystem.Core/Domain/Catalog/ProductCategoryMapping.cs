namespace ProductInvoicingSystem.Core.Domain.Catalog
{
    public class ProductCategoryMapping : BaseEntity
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        //public ICollection<Product> Products { get; set; }
        //public ICollection<Category> Categories { get; set; }

    }
}
