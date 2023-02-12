using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInvoicingSystem.Core.Domain.User;

namespace ProductInvoicingSystem.Data.EntityBuilder.User
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.Property(t => t.PhoneNumber).IsRequired();
            entityBuilder.Property(t => t.PrimaryAddress).IsRequired();
            entityBuilder.Property(t => t.SecondaryAddress).IsRequired();
            entityBuilder.Property(t => t.DateOfBirth).IsRequired();
        }
    }
}