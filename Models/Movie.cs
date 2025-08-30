using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        [Display(Name = "Movie Title")]
        public string? Title { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        [Display(Name = "Number in Stocks")]
        public int NumInStock { get; set; }

        [Required]
        [Display(Name = "Movie Genre")]
        public int GenreId { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}
