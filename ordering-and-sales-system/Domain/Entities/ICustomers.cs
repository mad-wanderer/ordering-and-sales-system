namespace ordering_and_sales_system.Domain.Entities
{
    public interface ICustomers
    {
        public string? Customer_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Address { get; set; }
    }
}
