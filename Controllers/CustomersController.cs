using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            this._context = context;
        }

        protected override void Dispose(bool disposing)
        {
            this._context.Dispose();
        }

        public IActionResult Index()
        {
            List<Customer> customers = this._context.Customer.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            Customer customer = this._context.Customer.Include(c => c.MembershipType).FirstOrDefault(c => c.CustomerId == id);

            return View(customer);
        }
    }
}
