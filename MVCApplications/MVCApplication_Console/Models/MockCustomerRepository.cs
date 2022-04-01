namespace MVCApplication_Console.Models
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> Customers =>
            new List<Customer> 
            {
                new Customer { CustomerName = "Bob", CreatedDate = System.DateTime.Now, CustomerId = "001", EmployeeId = 1 },
                new Customer { CustomerName = "Bib", CreatedDate = System.DateTime.Now, CustomerId = "002", EmployeeId = 2 },
                new Customer { CustomerName = "Bzb", CreatedDate = System.DateTime.Now, CustomerId = "003", EmployeeId = 3 },
                new Customer { CustomerName = "Btb", CreatedDate = System.DateTime.Now, CustomerId = "004", EmployeeId = 4 }
            };

        public Customer GetCustomerById(string customerId)
        {
            return Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
    }
}
