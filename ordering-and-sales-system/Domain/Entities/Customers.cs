namespace ordering_and_sales_system.Domain.Entities
{
    public class Customers : ICustomers
    {
        public Customers() { }

        public Customers(string customerID, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            Customer_ID = customerID;
            First_Name = firstName;
            Last_Name = lastName;
            Email = email;
            Phone_Number = phoneNumber;
            Address = address;
        }

        public Customers(ICustomers customer)
        {
            Customer_ID = customer.Customer_ID;
            First_Name = customer.First_Name;
            Last_Name = customer.Last_Name;
            Email = customer.Email;
            Phone_Number = customer.Phone_Number;
            Address = customer.Address;
        }

        public string? Customer_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Address { get; set; }

    }
}

