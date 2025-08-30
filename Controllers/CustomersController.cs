using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.Models.ViewModels;

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

        #region add new customer
        public IActionResult CustomerForm()
        {
            List<MembershipType> membershipTypes = this._context.MembershipType.ToList();

            CustomerFormViewModel viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                List<MembershipType> membershipTypes = this._context.MembershipType.ToList();

                CustomerFormViewModel viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = membershipTypes
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.CustomerId == 0)
            {
                this._context.Customer.Add(customer);
            }
            else
            {
                Customer customerToUpdate = this._context.Customer.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
                if (customerToUpdate == null)
                {
                    return NotFound();
                }

                customerToUpdate.Name = customer.Name;
                customerToUpdate.BirthDate = customer.BirthDate;
                customerToUpdate.MembershipTypeId = customer.MembershipTypeId;
                customerToUpdate.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }

            this._context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
        #endregion

        #region edit customer
        public IActionResult EditCustomer(int id)
        {
            List<MembershipType> membershipTypes = this._context.MembershipType.ToList();
            Customer customer = this._context.Customer.Include(c => c.MembershipType).FirstOrDefault(c => c.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            CustomerFormViewModel viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }
        #endregion
    }
}
