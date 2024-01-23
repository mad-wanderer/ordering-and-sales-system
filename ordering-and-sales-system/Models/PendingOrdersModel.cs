using ordering_and_sales_system.Domain.DataTransferObject;

namespace ordering_and_sales_system.Models
{
    public class PendingOrdersModel
    {
        public List<PendingOrdersDataTransferObject>? ListPendingOrders { get; set; }
    }
}
