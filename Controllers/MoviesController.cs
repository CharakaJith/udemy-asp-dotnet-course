using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            this._context = context;
        }

        protected override void Dispose(bool disposing)
        {
            this._context.Dispose();
        }

        public IActionResult Index()
        {
            List<Movie> movies = this._context.Movie.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public IActionResult Details(int id)
        {
            Movie movie = this._context.Movie.Include(m => m.Genre).FirstOrDefault(m => m.MovieId == id);

            return View(movie);
        }
    }
}
