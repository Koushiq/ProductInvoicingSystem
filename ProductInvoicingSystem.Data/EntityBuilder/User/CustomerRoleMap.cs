using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProductInvoicingSystem.Core.Domain.User;

namespace ProductInvoicingSystem.Data.EntityBuilder.User
{
    public class CustomerRoleMap
    {
        public CustomerRoleMap(EntityTypeBuilder<CustomerRoleMapping> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t=>t.CustomerId).IsRequired();
            entityBuilder.Property(t => t.RoleId).IsRequired();
            entityBuilder.HasOne(t => t.Customer)
                .WithMany(t => t.CustomerRoles)
                .HasForeignKey(t => t.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            entityBuilder.HasOne(t => t.Role)
                .WithMany(t => t.CustomerRoles)
                .HasForeignKey(t => t.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}