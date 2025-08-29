using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                MovieId = 1,
                Title = "Shrek"
            },
            new Movie
            {
                MovieId = 2,
                Title = "Happy death day"
            },
            new Movie
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
