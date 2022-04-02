namespace MVCApplication_Console.Models
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> Customers =>
            new List<Customer> 
            {
                new Customer { CustomerName = "Bob", CreatedDate = System.DateTime.Now, CustomerId = "001", EmployeeId = 1 }
            };
    }
}
