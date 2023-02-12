namespace ProductInvoicingSystem.Core.Domain.User
{
    public class CustomerRoleMapping : BaseEntity
    {
        public int CustomerId { get; set; }
        public int RoleId { get; set; }
        public Customer Customer { get; set; }
        public Role Role { get; set; }
    }
}
