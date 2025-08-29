using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMembershipTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "MembershipTypeId", "SignupFee", "DurationInMonths", "DiscountRate" },
                values: new object[,]
                {
                    { 1, 0, 0, 0 },    // free
                    { 2, 30, 1, 10 },   // monthly
                    { 3, 90, 3, 15 },   // quarterly
                    { 4, 300, 12, 20 }  // yearly
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "MembershipTypeId",
                keyValues: new object[] { 1, 2, 3, 4 });
        }
    }
}
