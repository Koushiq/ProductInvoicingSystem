namespace ProductInvoicingSystem.Core.Domain.User
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public ICollection<CustomerRoleMapping> CustomerRoles { get; set; }
    }
}
