using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Random()
        {
            var movie = new Movies()
            {
                MovieId = 1,
                Title = "Shrek"
            };

            return View(movie);
        }
    }
}
