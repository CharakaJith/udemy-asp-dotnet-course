using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "name";
            }

            return Content(String.Format($"pageInde={pageIndex}&sortBy={sortBy}"));

            //return View();
        }

        public IActionResult Random()
        {
            var movie = new Movies()
            {
                MovieId = 1,
                Title = "Shrek"
            };

            var customers = new List<Customers>
            {
                new Customers
                {
                    CustomerId = 1,
                    Name = "Customer A"
                },
                new Customers
                {
                    CustomerId = 2,
                    Name = "Customer B"
                },
                new Customers
                {
                    CustomerId = 3,
                    Name = "Customer C"
                }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        [Route("movies/released/{year:int}/{month:int}")]
        public IActionResult ByReleaseDate(int? year, int? month)
        {
            return Content($"{year} / {month}");
        }
    }
}
