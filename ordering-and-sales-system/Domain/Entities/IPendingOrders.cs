namespace ordering_and_sales_system.Domain.Entities
{
    public interface IPendingOrders
    {
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
    }
}
