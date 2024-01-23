namespace ordering_and_sales_system.Domain.Entities
{
    public class Customers
    {
        public Customers() { }

        public Customers(string customerID, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Customers(ICustomers customer)
        {
            CustomerID = customer.Customer_ID;
            FirstName = customer.First_Name;
            LastName = customer.Last_Name;
            Email = customer.Email;
            PhoneNumber = customer.Phone_Number;
            Address = customer.Address;
        }

        public string? CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}

