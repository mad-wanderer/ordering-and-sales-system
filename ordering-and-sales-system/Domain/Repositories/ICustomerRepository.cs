using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.Repositories
{
    public interface ICustomerRepository
    {
        public void AddCustomer(ICustomers customer);
        public void UpdateCustomer(ICustomers customer);
        public Customers GetCustomerByID(string id);
        public List<Customers>? GetAllCustomers();
    }
}
