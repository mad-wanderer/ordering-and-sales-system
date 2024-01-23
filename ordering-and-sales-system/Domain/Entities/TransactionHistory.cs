namespace ordering_and_sales_system.Domain.Entities
{

    public class TransactionHistory : ITransactionHistory
    {
        public TransactionHistory() { }

        

        public TransactionHistory (string? transactionID, string? orderID, DateTime? transactionDate, string? orderStatus)
        {
            TransactionID = transactionID;
            OrderID = orderID;
            TransactionDate = transactionDate;
            OrderStatus = orderStatus;
        }

        public TransactionHistory (ITransactionHistory transactionHistory)
        {
            TransactionID = transactionHistory.TransactionID;
            OrderID = transactionHistory.OrderID;
            TransactionDate= transactionHistory.TransactionDate;
            OrderStatus = transactionHistory.OrderStatus;   
        }

        public string? TransactionID { get; set; }
        public string? OrderID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? OrderStatus { get; set; }
    }
}
