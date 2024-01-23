using ordering_and_sales_system.Models;
using ordering_and_sales_system.Domain.Repositories;
using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Services
{
    public class InventoryService
    {
        public InventoryModel Model { get; internal set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        public class InventoryServices : IDisposable
        {
            private InventoryRepository inventoryRepository;


            public InventoryServices()
            {
                inventoryRepository = new InventoryRepository();
                Model = new InventoryModel();
                Model = GetAllInventory();
            }

            public InventoryModel Model { get; set; }

            public InventoryModel GetAllInventory()
            {
                Model.InventoryList = inventoryRepository.GetAllInventory();
                return Model;
            }

            public void Dispose()
            {
                inventoryRepository.Dispose();
            }

            public void AddProduct(Inventory product)
            {
                inventoryRepository.AddProduct(product);
            }

            public void UpdateProduct(Inventory product)
            {
                inventoryRepository.UpdateProduct(product);
            }
        }
    }
}
