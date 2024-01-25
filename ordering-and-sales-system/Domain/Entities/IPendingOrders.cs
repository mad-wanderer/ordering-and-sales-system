namespace ordering_and_sales_system.Domain.Entities
{
    public interface IPendingOrders
    {
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
    }
}
