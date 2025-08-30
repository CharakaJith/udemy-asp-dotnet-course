using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMembershipTypeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "MembershipTypeId",
                keyValue: 1,
                columns: new[] { "Name" },
                values: new object[] { "Pay as you go" }
            );

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "MembershipTypeId",
                keyValue: 2,
                columns: new[] { "Name" },
                values: new object[] { "Monthly" }
            );

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "MembershipTypeId",
                keyValue: 3,
                columns: new[] { "Name" },
                values: new object[] { "Quarterly" }
            );

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "MembershipTypeId",
                keyValue: 4,
                columns: new[] { "Name" },
                values: new object[] { "Yearly" }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
