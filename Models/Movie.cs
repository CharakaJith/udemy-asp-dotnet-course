using System.ComponentModel.DataAnnotations;
using Vidly.Validations;

namespace Vidly.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie title is required.")]
        [Display(Name = "Movie Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Released Date is required.")]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Required]
        public DateTime AddedDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Number of stocks is required.")]
        [Display(Name = "Number in Stocks")]
        [ValidateStocks]
        public int NumInStock { get; set; }

        [Required(ErrorMessage = "The Genre field is required.")]
        [Display(Name = "Movie Genre")]
        public int? GenreId { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}
