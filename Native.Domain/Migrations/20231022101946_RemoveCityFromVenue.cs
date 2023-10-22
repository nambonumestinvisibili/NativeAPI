using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCityFromVenue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venues_Cities_CityCountryIsoCode_CityPostalCode",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_CityCountryIsoCode_CityPostalCode",
                table: "Venues");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "247cd59a-9b73-420f-ae14-6489f86e6c6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8001ef4f-60fb-4e6c-a093-66cd95e49254");

            migrationBuilder.DropColumn(
                name: "CityCountryIsoCode",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "CityPostalCode",
                table: "Venues");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c6d461d-f740-4489-9f02-4bec7b83fd73", null, "admin", "ADMIN" },
                    { "8134b87d-c667-4290-843b-0d12aab1f48f", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c6d461d-f740-4489-9f02-4bec7b83fd73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8134b87d-c667-4290-843b-0d12aab1f48f");

            migrationBuilder.AddColumn<string>(
                name: "CityCountryIsoCode",
                table: "Venues",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityPostalCode",
                table: "Venues",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "247cd59a-9b73-420f-ae14-6489f86e6c6b", null, "user", "USER" },
                    { "8001ef4f-60fb-4e6c-a093-66cd95e49254", null, "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venues_CityCountryIsoCode_CityPostalCode",
                table: "Venues",
                columns: new[] { "CityCountryIsoCode", "CityPostalCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_Cities_CityCountryIsoCode_CityPostalCode",
                table: "Venues",
                columns: new[] { "CityCountryIsoCode", "CityPostalCode" },
                principalTable: "Cities",
                principalColumns: new[] { "CountryIsoCode", "PostalCode" });
        }
    }
}
