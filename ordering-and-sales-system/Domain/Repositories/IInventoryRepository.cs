using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Transactions;

namespace ordering_and_sales_system.Domain.Repositories
{
    public interface IInventoryRepository
    {
        public void AddProduct(Inventory inventory);
        public void UpdateProduct(Inventory inventory);
        public Inventory GetProductByID(string id);
        public List<Inventory>? GetAllInventory();
    }
}
