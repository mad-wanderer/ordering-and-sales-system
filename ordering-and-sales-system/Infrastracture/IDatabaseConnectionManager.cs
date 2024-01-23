using MySql.Data.MySqlClient;

namespace ordering_and_sales_system.Infrastracture
{
    public interface IDatabaseConnectionManager
    {
        public string ConnectionString { get; set; }
        public MySqlConnection Connection { get; set; }

        public void OpenConnection();
        public void CloseConnection(IDatabaseConnectionManager dbManager);
    }

}
