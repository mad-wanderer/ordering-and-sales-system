namespace ordering_and_sales_system.Domain.Entities
{
    public interface ITransactionHistory
    {
        public string? TransactionID { get; set; }
        public string? OrderID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? OrderStatus { get; set; }
    }
}
