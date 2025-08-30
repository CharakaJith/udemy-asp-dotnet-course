using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.Models.ViewModels;

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

        #region add new movie
        public IActionResult MovieForm()
        {
            List<Genre> genres = this._context.Genre.ToList();

            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SaveMovie(Movie movie)
        {
            if (movie.MovieId == 0)
            {
                movie.AddedDate = DateTime.UtcNow;
                this._context.Movie.Add(movie);
            }
            else
            {
                Movie movieToUpdate = this._context.Movie.FirstOrDefault(m => m.MovieId == movie.MovieId);
                if (movieToUpdate == null)
                {
                    return NotFound();
                }

                movieToUpdate.Title = movie.Title;
                movieToUpdate.ReleasedDate = movie.ReleasedDate;
                movieToUpdate.NumInStock = movie.NumInStock;
                movieToUpdate.GenreId = movie.GenreId;
            }

            this._context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
        #endregion

        #region edit movie
        public IActionResult EditMovie(int id)
        {
            List<Genre> genres = this._context.Genre.ToList();
            Movie movie = this._context.Movie.Include(m => m.Genre).FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }

            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }
        #endregion
    }
}
