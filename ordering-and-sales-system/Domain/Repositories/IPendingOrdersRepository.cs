using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.Repositories
{
    public interface IPendingOrdersRepository
    {
        public void AddOrder(PendingOrders pendingOrders);
        public void UpdateOrder(PendingOrders pendingOrders);
        public PendingOrders GetOrderByID(string id);
        public List<PendingOrders> GetAllPendingOrders();
    }
}
