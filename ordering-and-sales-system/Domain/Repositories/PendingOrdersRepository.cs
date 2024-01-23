using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class PendingOrdersRepository : IPendingOrdersRepository, IDisposable
    {
        private DatabaseHelper<PendingOrders> _databaseHelper;
        private readonly string tableName = "pendingorders";

        public PendingOrdersRepository()
        {
            _databaseHelper = new DatabaseHelper<PendingOrders>();
        }

        public void AddOrder(PendingOrders pendingOrders)
        {
            _databaseHelper.InsertRecord(tableName, pendingOrders);
        }

        public void UpdateOrder(PendingOrders pendingOrders)
        {
            _databaseHelper.UpdateRecord(tableName, pendingOrders);
        }

        public PendingOrders GetOrderByID(string id)
        {
            string constraints = "OrderID = '" + id + "'"; // Added single quotes for string comparison
            DataTable dataTable = _databaseHelper.SelectRecord(tableName, constraints);
            DataRow row = dataTable.Rows[0];
            return new PendingOrders(
                row["OrderID"].ToString()!,
                row["ProductID"].ToString()!,
                row["CustomerID"].ToString()!,
                row["ProductName"].ToString()!,
                row["Color"].ToString()!,
                int.Parse(row["Quantity"].ToString()!),
                int.Parse(row["Price"].ToString()!),
                DateTime.Parse(row["TransactionDate"].ToString()!),
                row["Status"].ToString()!,
                int.Parse(row["Total"].ToString()!)
            );
        }

        public List<PendingOrders> GetAllPendingOrders()
        {
            DataTable dataTable = _databaseHelper.SelectAllRecord(tableName);
            List<PendingOrders> pendingOrders = new List<PendingOrders>();
            foreach (DataRow row in dataTable.Rows)
            {
                PendingOrders pendingOrder = new PendingOrders(
                    row["OrderID"].ToString()!,
                    row["ProductID"].ToString()!,
                    row["CustomerID"].ToString()!,
                    row["ProductName"].ToString()!,
                    row["Color"].ToString()!,
                    int.Parse(row["Quantity"].ToString()!),
                    int.Parse(row["Price"].ToString()!),
                    DateTime.Parse(row["TransactionDate"].ToString()!),
                    row["Status"].ToString()!,
                    int.Parse(row["Total"].ToString()!));
                    pendingOrders.Add(pendingOrder);
            }
            return pendingOrders;
        }

        public void Dispose()
        {
            _databaseHelper.Dispose();
        }
    }
}
