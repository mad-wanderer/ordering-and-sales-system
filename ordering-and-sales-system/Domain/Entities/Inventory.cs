namespace ordering_and_sales_system.Domain.Entities
{
    public class Inventory
    {
       

        public Inventory() { }

        public Inventory(string? productID, string? productName, string? category, int quantity, int price, int productCost, string? status)
        {
            ProductID = productID;
            ProductName = productName;
            Category = category;
            Quantity = quantity;
            Price = price;
            ProductCost = productCost;
            Status = status;
        }

        public Inventory(Inventory inventory)
        {
            ProductID = inventory.ProductID;
            ProductName = inventory.ProductName;
            Category = inventory.Category;
            Quantity = inventory.Quantity;
            Price = inventory.Price;
            ProductCost = inventory.ProductCost;
            Status = inventory.Status;
        }

        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int ProductCost { get; set; }
        public string? Status { get; set; }
    }
}

