using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.DataTransferObject
{
    public class PendingOrdersDataTransferObject : IPendingOrders
    {
        public PendingOrdersDataTransferObject() { }

        public PendingOrdersDataTransferObject(string? orderID, string? productID, string? customerID, string? productName, string? color, int quantity, int price, DateTime? transactionDate, string? status, int total)
        {
            OrderID = orderID;
            ProductID = productID;
            CustomerID = customerID;
            ProductName = productName;
            Color = color;
            Quantity = quantity;
            Price = price;
            TransactionDate = transactionDate;
            Status = status;
            Total = total;
        }

        public PendingOrdersDataTransferObject(IPendingOrders PendingOrders)
        {
            OrderID = PendingOrders.OrderID;
            ProductID = PendingOrders.ProductID;
            CustomerID = PendingOrders.CustomerID;
            ProductName = PendingOrders.ProductName;
            Color = PendingOrders.Color;
            Quantity = PendingOrders.Quantity;
            Price = PendingOrders.Price;
            TransactionDate = PendingOrders.TransactionDate;
            Status = PendingOrders.Status;
            Total = PendingOrders.Total;
        }

            public string? OrderID { get; set; }
            public string? ProductID { get; set; }
            public string? CustomerID { get; set; }
            public string? ProductName { get; set; }
            public string? Color { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public DateTime? TransactionDate { get; set; }
            public string? Status { get; set; }
            public int Total { get; set; }

            public Inventory? Inventory { get; set; }
            public Customers? Customers { get; set; }
    }
}
