using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        public int NumInStock { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}
