namespace ordering_and_sales_system.Configurations
{
    public class Configuration
    {
        public static class MySQL
        {
            private static String _connectionString = String.Empty;
            public static String ConnectionString { get { return _connectionString; } set { _connectionString = value; } }
        }
    }
}
