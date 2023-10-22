using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class addednullablecity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcaa758b-b727-498c-ae0b-fcd9b4d7a338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2159593-0e72-4ced-b42f-f1b69d6b602b");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f2e6da3-f869-4f8e-9a1a-914c3887d2a2", null, "user", "USER" },
                    { "9f0d08bc-0705-4085-ac60-fb3a01a3f1da", null, "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_CityId",
                table: "Location",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_CityId",
                table: "Location");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f2e6da3-f869-4f8e-9a1a-914c3887d2a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f0d08bc-0705-4085-ac60-fb3a01a3f1da");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Location");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bcaa758b-b727-498c-ae0b-fcd9b4d7a338", null, "user", "USER" },
                    { "f2159593-0e72-4ced-b42f-f1b69d6b602b", null, "admin", "ADMIN" }
                });
        }
    }
}
