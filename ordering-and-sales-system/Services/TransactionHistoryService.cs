using ordering_and_sales_system.Domain.Repositories;
using ordering_and_sales_system.Models;

namespace ordering_and_sales_system.Services
{
    public class TransactionHistoryService
    {
        private TransactionHistoryRepository transactRepository; /*class variable - camelCase; can be seen in class but outside method*/

        public TransactionHistoryModel Model { get; set; } /*property naming - pascal case; get set*/

        public TransactionHistoryModel GetAllTransactionHistory() /*method - acess modiefier ,return type, function name, parameters ()inside parenthesis*/
        {
            Model.TransactionList = transactRepository.GetAllTransactionHistory(); /*assignment - naglilipat value galign repository to model*/
            return Model;
        }

        internal void Dispose()
        {
            transactRepository.Dispose();
        }

        public TransactionHistoryService() /*constructor - modifier, classname; unang nagra-run when object instantiated*/
        {
            transactRepository = new TransactionHistoryRepository(); /*object - new keyword*/
            Model = new TransactionHistoryModel();
            Model = GetAllTransactionHistory();
        }
    }

}
