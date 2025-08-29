using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Name", "IsSubscribedToNewsLetter", "MembershipTypeId" },
                values: new object[,]
                {
                    { 1, "John Smith", false, 1 },
                    { 2, "Jane Doe", false, 3 },
                    { 3, "Mary Jane", true, 4 },
                    { 4, "Bob Swaggs", true, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValues: new object[] { 1, 2, 3, 4 });
        }
    }
}
