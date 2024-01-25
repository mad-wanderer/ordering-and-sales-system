using ordering_and_sales_system.Models;
using ordering_and_sales_system.Domain.Repositories;
using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Services
{
    public class InventoryService : IDisposable
    {
        private InventoryRepository inventoryRepository;


        public InventoryService()
        {
            inventoryRepository = new InventoryRepository();
            Model = new InventoryModel();
            Model = GetAllInventoryList();
        }

        public InventoryModel Model { get; set; }

        public InventoryModel GetAllInventoryList()
        {
            Model.InventoryList = inventoryRepository.GetAllInventory();
            return Model;
        }

        public void Dispose()
        {
            inventoryRepository.Dispose();
        }

        public void AddProduct(Inventory inventory)
        {
            inventoryRepository.AddProduct(inventory);
        }

        public void UpdateProduct(Inventory inventory)
        {
            inventoryRepository.UpdateProduct(inventory);
        }
    }
}
