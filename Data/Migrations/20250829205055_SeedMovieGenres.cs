using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovieGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Animation" },
                    { 4, "Biography" },
                    { 5, "Comedy" },
                    { 6, "Crime" },
                    { 7, "Documentary" },
                    { 8, "Drama" },
                    { 9, "Family" },
                    { 10, "Fantasy" },
                    { 11, "History" },
                    { 12, "Horror" },
                    { 13, "Music" },
                    { 14, "Musical" },
                    { 15, "Mystery" },
                    { 16, "Romance" },
                    { 17, "Sci-Fi" },
                    { 18, "Sport" },
                    { 19, "Thriller" },
                    { 20, "War" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
