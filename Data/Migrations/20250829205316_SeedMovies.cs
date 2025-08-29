using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieId", "Title", "ReleasedDate", "AddedDate", "NumInStock", "GenreId" },
                values: new object[,]
                {
                    { 1, "Alien", DateTime.Parse("1979-06-22"), DateTime.Parse("2025-02-10"), 10, 17 },
                    { 2, "Inception", DateTime.Parse("2010-07-16"), DateTime.Parse("2025-03-05"), 7, 17 },
                    { 3, "The Shawshank Redemption", DateTime.Parse("1994-09-22"), DateTime.Parse("2025-01-20"), 5, 8 },
                    { 4, "The Godfather", DateTime.Parse("1972-03-24"), DateTime.Parse("2025-04-15"), 8, 6 },
                    { 5, "Toy Story", DateTime.Parse("1995-11-22"), DateTime.Parse("2025-05-01"), 12, 3 },
                    { 6, "Parasite", DateTime.Parse("2019-05-30"), DateTime.Parse("2025-06-10"), 6, 8 },
                    { 7, "Blade Runner", DateTime.Parse("1982-06-25"), DateTime.Parse("2025-07-05"), 4, 17 },
                    { 8, "Green Book", DateTime.Parse("2018-11-16"), DateTime.Parse("2025-08-01"), 9, 8 },
                    { 9, "Avengers: Endgame", DateTime.Parse("2019-04-26"), DateTime.Parse("2025-03-25"), 15, 1 },
                    { 10, "Memento", DateTime.Parse("2000-10-11"), DateTime.Parse("2025-02-28"), 6, 15 },
                    { 11, "Jurassic Park", DateTime.Parse("1993-06-11"), DateTime.Parse("2025-01-10"), 10, 2 },
                    { 12, "Titanic", DateTime.Parse("1997-12-19"), DateTime.Parse("2025-04-22"), 5, 16 },
                    { 13, "The Breakfast Club", DateTime.Parse("1985-02-15"), DateTime.Parse("2025-05-18"), 7, 8 },
                    { 14, "No Country for Old Men", DateTime.Parse("2007-11-21"), DateTime.Parse("2025-06-30"), 8, 6 },
                    { 15, "Stand by Me", DateTime.Parse("1986-08-22"), DateTime.Parse("2025-07-15"), 9, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
