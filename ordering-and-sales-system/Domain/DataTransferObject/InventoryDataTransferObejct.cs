using System.ComponentModel.DataAnnotations;
using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.DataTransferObject
{
        public class InventoryDataTransferObject : ordering_and_sales_system.Domain.Entities.IInventory
        {
        public InventoryDataTransferObject() { }

        public InventoryDataTransferObject(string? productID, string? productName, string? category, int quantity, int price, int productCost, string? status)
        {
            Product_ID = productID;
            Product_Name = productName;
            Category = category;
            Quantity = quantity;
            Price = price;
            Product_Cost = productCost;
            Status = status;
        }

        public InventoryDataTransferObject(Inventory inventory)
        {
            Product_ID = inventory.Product_ID;
            Product_Name = inventory.Product_Name;
            Category = inventory.Category;
            Quantity = inventory.Quantity;
            Price = inventory.Price;
            Product_Cost = inventory.Product_Cost;
            Status = inventory.Status;
        }

        public string? Product_ID { get; set; }
        public string? Product_Name { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Product_Cost { get; set; }
        public string? Status { get; set; }
    }
}

