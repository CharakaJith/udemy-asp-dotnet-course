using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerBday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "BirthDate" },
                values: new object[] { DateTime.Parse("2000-06-25") }
            );

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "BirthDate" },
                values: new object[] { DateTime.Parse("1990-05-15") }
            );

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "BirthDate" },
                values: new object[] { DateTime.Parse("2007-12-04") }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
