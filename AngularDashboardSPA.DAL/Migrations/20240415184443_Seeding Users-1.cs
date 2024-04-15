using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularDashboardSPA.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingUsers1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7678a184-58b5-4904-a582-f62c06adfe8f",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70767349-bf60-46f4-bb8f-b5bddb139470", "ADMIN", "AQAAAAIAAYagAAAAEAGlApzEsTnqODmldnaGonePTl+Vqntnf2LoQeWGctJhxaXNH8mPQ0v6V/pnaHJWgA==", "938e3ef6-fe11-4c34-af40-478218a4d170" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7678a184-58b5-4904-a582-f62c06adfe8f",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6412e2c8-c730-45b3-96e1-7eb9b2a1490e", "Admin", "AQAAAAIAAYagAAAAENQOO24bS5ikMabluD1SZm+RLmL4dMxnPO+O8s6JUwRGmIrram/fp9SDXJOFac7wZg==", "7a0373d3-c1e0-49bf-a438-5c94c2300220" });
        }
    }
}