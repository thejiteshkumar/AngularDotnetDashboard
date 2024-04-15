using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularDashboardSPA.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingUsers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7678a184-58b5-4904-a582-f62c06adfe8f",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee07840-736a-4dde-990e-122b45adbe2f", "admin@stormblessed.com", "ADMIN@STORMBLESSED.COM", "AQAAAAIAAYagAAAAEA6TDzbm4g8x1P+NDizd0gwSVZckQ93kDpDNez8n7b9uCMK+4/oZWMbDuDiwXHpPnw==", "5c7adfaa-bf87-4484-a45e-672cd3a7367a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7678a184-58b5-4904-a582-f62c06adfe8f",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70767349-bf60-46f4-bb8f-b5bddb139470", null, null, "AQAAAAIAAYagAAAAEAGlApzEsTnqODmldnaGonePTl+Vqntnf2LoQeWGctJhxaXNH8mPQ0v6V/pnaHJWgA==", "938e3ef6-fe11-4c34-af40-478218a4d170" });
        }
    }
}
