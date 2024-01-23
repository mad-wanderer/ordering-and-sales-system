using ordering_and_sales_system.Domain.Entities;

namespace ordering_and_sales_system.Domain.Repositories

{
    public interface ITransactionHistoryRepository
    {
        public void AddTransactionHistory(ITransactionHistory transactionHistory);
        public TransactionHistory GetTransactionHistoryByID(string transactionId);
        public List<TransactionHistory> GetAllTransactionHistory();
    }
}
