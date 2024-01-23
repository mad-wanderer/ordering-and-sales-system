using ordering_and_sales_system.Domain.Repositories;
using ordering_and_sales_system.Models;
using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Domain.DataTransferObject;
using ordering_and_sales_system.Infrastracture;

namespace ordering_and_sales_system.Services
{
    public class PendingOrdersService : IDisposable
    {
        private PendingOrdersRepository pendingOrdersRepository;
        private InventoryRepository inventoryRepository;
        private CustomerRepository customerRepository;

        public PendingOrdersModel Model { get; set; }
        public PendingOrdersService(string ProductID)
        {
            pendingOrdersRepository = new PendingOrdersRepository();
            inventoryRepository = new InventoryRepository();
            customerRepository = new CustomerRepository();
            Model = new PendingOrdersModel();
            Model = GetPendingOrderList(ProductID);
        }

        public PendingOrdersModel GetPendingOrderList(string ProductID)
        {
            List<PendingOrders> pendingOrders = pendingOrdersRepository.GetAllPendingOrders(); 
            List<PendingOrdersDataTransferObject> pendingOrdersData = new List<PendingOrdersDataTransferObject>();
            foreach(IPendingOrders pendingOrder in pendingOrders)
            {
                PendingOrdersDataTransferObject pendingOrderData = new PendingOrdersDataTransferObject(pendingOrder);
                pendingOrderData.Inventory = inventoryRepository.GetProductByID(pendingOrder.OrderID);
                pendingOrderData.Customers = customerRepository.GetCustomerByID(pendingOrder.CustomerID);
                pendingOrdersData.Add(pendingOrderData);
            }
            Model.ListPendingOrders = pendingOrdersData;
            return Model;
        }
        
        public void AddOrder(PendingOrders pendingOrders)
        {
            pendingOrdersRepository.AddOrder(pendingOrders);
        }

        public void UpdateOrder(PendingOrders pendingOrders)
        {
            pendingOrdersRepository.UpdateOrder(pendingOrders);
        }

        public void Dispose()
        {
            pendingOrdersRepository.Dispose();
        }
    }
}
