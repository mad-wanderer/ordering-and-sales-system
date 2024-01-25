namespace ordering_and_sales_system.Domain.Entities
{
    public interface IInventory
    {
        public string? Product_ID { get; set; }
        public string? Product_Name { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Product_Cost { get; set; }
        public string? Status { get; set; }
    }
}
