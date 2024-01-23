using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;
using System.Data.Common;
using System.Transactions;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class InventoryRepository : IInventoryRepository, IDisposable
    {
        private DatabaseHelper<Inventory> _databaseHelper;
        private readonly string tableName = "inventory";

        public InventoryRepository()
        {
            _databaseHelper = new DatabaseHelper<Inventory>();
        }

        public void AddProduct(Inventory inventory)
        {
            _databaseHelper.InsertRecord(tableName, inventory);
        }

        public void UpdateProduct(Inventory inventory)
        {
            _databaseHelper.UpdateRecord(tableName, inventory);
        }

        public Inventory GetProductByID(string id)
        {
            string constraints = "Product_ID = '" + id + "'"; // Added single quotes for string comparison
            DataTable dataTable = _databaseHelper.SelectRecord(tableName, constraints);
            DataRow row = dataTable.Rows[0];
            return new Inventory(
                row["Product_ID"].ToString()!,
                row["Product_Name"].ToString()!,
                row["Category"].ToString()!,
                int.Parse(row["Price"].ToString()!),
                int.Parse(row["Quantity"].ToString()!),
                int.Parse(row["Product_Cost"].ToString()!),
                row["Status"].ToString()!
            );
        }

        public List<Inventory> GetAllInventory()
        {
            DataTable dataTable = _databaseHelper.SelectAllRecord(tableName);
            List<Inventory> inventory = new List<Inventory>();
            foreach (DataRow row in dataTable.Rows)
            {
                Inventory inventoryCatalogue = new Inventory(
                    row["Product_ID"].ToString()!,
                    row["Product_Name"].ToString()!,
                    row["Category"].ToString()!,
                    int.Parse(row["Price"].ToString()!),
                    int.Parse(row["Quantity"].ToString()!),
                    int.Parse(row["Product_Cost"].ToString()!),
                    row["Status"].ToString()!);
                    inventory.Add(inventoryCatalogue);
            }
            return inventory;
        }

        public void Dispose()
        {
            _databaseHelper.Dispose();
        }
    }
}
