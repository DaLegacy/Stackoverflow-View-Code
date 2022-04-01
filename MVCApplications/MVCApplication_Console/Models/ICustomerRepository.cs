namespace MVCApplication_Console.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers { get; }
        Customer GetCustomerById(string customerId);
    }
}
