using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Infrastracture;
using System.Data;

namespace ordering_and_sales_system.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private DatabaseHelper<Customers> databaseHelper;
        private readonly string tableName = "customers";
        public CustomerRepository()

        {
            databaseHelper = new DatabaseHelper<Customers>();
        }

        public void AddCustomer(ICustomers customer)
        {
            databaseHelper.InsertRecord(tableName, new Customers(customer));
        }

        public void Dispose()
        {
            if (!databaseHelper.Equals(null))
            {
                databaseHelper!.Dispose();
            }
        }

        public List<Customers> GetAllCustomers()
        {
            DataTable dataTable = databaseHelper.SelectAllRecord(tableName);
            List<Customers> customers = new List<Customers>();
            foreach (DataRow row in dataTable.Rows)
            {
                Customers customer = new Customers(
                row["Customer_ID"].ToString()!,
                row["First_Name"].ToString()!,
                row["Last_Name"].ToString()!,
                row["Email"].ToString()!,
                row["Phone_Number"].ToString()!,
                row["Address"].ToString()!
                );
                customers.Add(customer);
            }
            return customers;
        }

        public Customers GetCustomerByID(string id)
        {
            string constraints = "Customer_ID = " + id;
            DataTable dataTable = databaseHelper.SelectRecord(this.tableName, constraints);
            DataRow row = dataTable.Rows[0];
            return new Customers(
                row["Customer_ID"].ToString()!,
                row["First_Name"].ToString()!,
                row["Last_Name"].ToString()!,
                row["Email"].ToString()!,
                row["Phone_Number"].ToString()!,
                row["Address"].ToString()!
            );
        }

        public void UpdateCustomer(ICustomers customer)
        {
            databaseHelper.UpdateRecord(tableName, new Customers(customer));
        }
    }
}
