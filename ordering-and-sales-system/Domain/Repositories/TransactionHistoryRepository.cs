using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class TransactionHistoryRepository : ITransactionHistoryRepository, IDisposable
    {
        private DatabaseHelper<TransactionHistory> _databaseHelper;
        private readonly string tableName = "transactionhistory";

        public TransactionHistoryRepository()
        {
            _databaseHelper = new DatabaseHelper<TransactionHistory>();
        }

        public void AddTransactionHistory(ITransactionHistory transactionHistory)
        {
            _databaseHelper.InsertRecord(tableName, new TransactionHistory(transactionHistory));
        }

        public TransactionHistory GetTransactionHistoryByID(string transactionId)
        {
            string constraints = "TransactionID = " + transactionId;

            DataTable dataTable = _databaseHelper.SelectRecord(tableName, constraints);
            DataRow dataRow = dataTable.Rows[0];
            return new TransactionHistory(
                dataRow["TransactionID"].ToString()!,
                dataRow["OrderID"].ToString()!,
                DateTime.Parse(dataRow["TransactionDate"].ToString()!),
                dataRow["OrderStatus"].ToString()!
                );
        }

        public List<TransactionHistory> GetAllTransactionHistory()
        {
            DataTable dataTable = _databaseHelper.SelectAllRecord(tableName);

            List<TransactionHistory> transactList = new List<TransactionHistory>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                TransactionHistory transactionHistory = new TransactionHistory (
                        dataTable.Rows[i]["TransactionID"].ToString()!,
                        dataTable.Rows[i]["OrderID"].ToString()!,
                        DateTime.Parse(dataTable.Rows[i]["TransactionDate"].ToString()!),
                        dataTable.Rows[i]["OrderStatus"].ToString()!
                    );

                transactList.Add( transactionHistory );
            }
            return transactList;

        }

        public void Dispose()
        {
            _databaseHelper.Dispose();
        }
    }
}
