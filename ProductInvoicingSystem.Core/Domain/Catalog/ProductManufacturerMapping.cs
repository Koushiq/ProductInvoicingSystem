namespace ProductInvoicingSystem.Core.Domain.Catalog
{
    public class ProductManufacturerMapping : BaseEntity
    {
        public int ProductId { get; set; }
        public int ManufacturerId { get; set; }
        public Product Product { get; set; }
        public Manufacturer Manufacturer { get; set; }  
    }
}
