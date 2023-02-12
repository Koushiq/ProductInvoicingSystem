using Microsoft.EntityFrameworkCore;
using ProductInvoicingSystem.Core.Domain.Catalog;
using ProductInvoicingSystem.Core.Domain.User;
using ProductInvoicingSystem.Data.EntityBuilder.Catalog;
using ProductInvoicingSystem.Data.EntityBuilder.User;

namespace ProductInvoicingSystem.Data.DataProvider
{
    public class ProductInvoicingSystemDbContext : DbContext
    {
        public ProductInvoicingSystemDbContext(DbContextOptions<ProductInvoicingSystemDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Catalog

            new ManufacturerMap(modelBuilder.Entity<Manufacturer>());
            new CategoryMap(modelBuilder.Entity<Category>());
            new ProductMap(modelBuilder.Entity<Product>());
            new ProductCategoryMap(modelBuilder.Entity<ProductCategoryMapping>());

            #endregion

            #region User

            new CustomerMap(modelBuilder.Entity<Customer>());
            new CustomerRoleMap(modelBuilder.Entity<CustomerRoleMapping>());
            new RoleMap(modelBuilder.Entity<Role>());

            #endregion

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-KK6D3RE;Database=ProductInvoicingSystem;Trusted_Connection=True");
        }
    }
}