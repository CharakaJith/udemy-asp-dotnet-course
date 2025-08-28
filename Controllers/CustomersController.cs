using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customers> customers = new List<Customers>
        {
            new Customers
            {
                CustomerId = 1,
                Name = "John Doe"
            },
            new Customers
            {
                CustomerId = 2,
                Name = "Jane Doe"
            },
            new Customers
            {
                CustomerId = 3,
                Name = "Bob Smith"
            },
        };

        public IActionResult Index()
        {
            return View(this.customers);
        }

        public IActionResult Details(int id)
        {
            Customers customer = this.customers.FirstOrDefault(c => c.CustomerId == id);

            return View(customer);
        }
    }
}
