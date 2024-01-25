using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.DataTransferObject
{
    public class PendingOrdersDataTransferObject : IPendingOrders
    {
        public PendingOrdersDataTransferObject() { }

        public PendingOrdersDataTransferObject(string? orderID, string? productID, string? customerID, string? productName, string? color, int quantity, int price, DateTime? transactionDate, string? status, int total)
        {
            Order_ID = orderID;
            Product_ID = productID;
            Customer_ID = customerID;
            Product_Name = productName;
            Color = color;
            Quantity = quantity;
            Price = price;
            Transaction_Date = transactionDate;
            Status = status;
            Total = total;
        }

        public PendingOrdersDataTransferObject(IPendingOrders PendingOrders)
        {
            Order_ID = PendingOrders.Order_ID;
            Product_ID = PendingOrders.Product_ID;
            Customer_ID = PendingOrders.Customer_ID;
            Product_Name = PendingOrders.Product_Name;
            Color = PendingOrders.Color;
            Quantity = PendingOrders.Quantity;
            Price = PendingOrders.Price;
            Transaction_Date = PendingOrders.Transaction_Date;
            Status = PendingOrders.Status;
            Total = PendingOrders.Total;
        }

            public string? Order_ID { get; set; }
            public string? Product_ID { get; set; }
            public string? Customer_ID { get; set; }
            public string? Product_Name { get; set; }
            public string? Color { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public DateTime? Transaction_Date { get; set; }
            public string? Status { get; set; }
            public int Total { get; set; }

            public Inventory? Inventory { get; set; }
            public Customers? Customers { get; set; }
    }
}
