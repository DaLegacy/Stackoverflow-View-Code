namespace MVCApplication_Console.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MVCApplication_Console.Models;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository Customer;

        public CustomersController(ICustomerRepository customer)
        {
            this.Customer = customer;
        }

        [HttpGet]
        public List<Customer> GetCustomers()
        {
            return (List<Customer>)Customer.Customers;
        }
    }
}
