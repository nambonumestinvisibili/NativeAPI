using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class makelocationvenuenotnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f2e6da3-f869-4f8e-9a1a-914c3887d2a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f0d08bc-0705-4085-ac60-fb3a01a3f1da");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Location",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e02a697-1a84-44e4-8a9e-2bb5aacd7305", null, "admin", "ADMIN" },
                    { "5c644872-0e02-4f12-944f-96b77f4c4aea", null, "user", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e02a697-1a84-44e4-8a9e-2bb5aacd7305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c644872-0e02-4f12-944f-96b77f4c4aea");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Location",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f2e6da3-f869-4f8e-9a1a-914c3887d2a2", null, "user", "USER" },
                    { "9f0d08bc-0705-4085-ac60-fb3a01a3f1da", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Cities_CityId",
                table: "Location",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
