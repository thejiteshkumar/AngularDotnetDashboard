using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularDashboardSPA.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36009813-b259-4997-b4d3-4f72cbabbc04", null, "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7678a184-58b5-4904-a582-f62c06adfe8f", 0, "6412e2c8-c730-45b3-96e1-7eb9b2a1490e", null, false, false, null, null, "Admin", "AQAAAAIAAYagAAAAENQOO24bS5ikMabluD1SZm+RLmL4dMxnPO+O8s6JUwRGmIrram/fp9SDXJOFac7wZg==", null, false, "7a0373d3-c1e0-49bf-a438-5c94c2300220", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36009813-b259-4997-b4d3-4f72cbabbc04", "7678a184-58b5-4904-a582-f62c06adfe8f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36009813-b259-4997-b4d3-4f72cbabbc04", "7678a184-58b5-4904-a582-f62c06adfe8f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36009813-b259-4997-b4d3-4f72cbabbc04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7678a184-58b5-4904-a582-f62c06adfe8f");
        }
    }
}