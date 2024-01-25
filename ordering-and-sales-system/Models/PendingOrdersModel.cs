using ordering_and_sales_system.Domain.DataTransferObject;
using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Models
{
    public class PendingOrdersModel
    {
        public List<Customers>? CustomerList { get; set; }
        public PendingOrders? Transaction { get; set; }
        public List<Inventory>? InventoryList { get; set; }
        public List<PendingOrders>? PendingOrdersList { get; set; }
    }
}
