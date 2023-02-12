using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInvoicingSystem.Core.Domain.User;

namespace ProductInvoicingSystem.Data.EntityBuilder.User
{
    public class RoleMap
    {
        public RoleMap(EntityTypeBuilder<Role> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasIndex(t => t.RoleName)
                .IsUnique();

        }
    }
}