namespace ordering_and_sales_system.Domain.Entities
{
    public interface IInventory
    {
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int ProductCost { get; set; }
        public string? Status { get; set; }
    }
}
