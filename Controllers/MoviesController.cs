using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movies> movies = new List<Movies>
        {
            new Movies
            {
                MovieId = 1,
                Title = "Shrek"
            },
            new Movies
            {
                MovieId = 2,
                Title = "Happy death day"
            },
            new Movies
            {
                MovieId = 3,
                Title = "Wall-E"
            },
        };

        public IActionResult Index()
        {
            return View(this.movies);
        }
    }
}
