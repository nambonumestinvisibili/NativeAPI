using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCityCompoundKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileCity_Cities_CityCountryIsoCode_CityPostalCode",
                table: "ProfileCity");

            migrationBuilder.DropIndex(
                name: "IX_ProfileCity_CityCountryIsoCode_CityPostalCode",
                table: "ProfileCity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c6d461d-f740-4489-9f02-4bec7b83fd73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8134b87d-c667-4290-843b-0d12aab1f48f");

            migrationBuilder.DropColumn(
                name: "CityCountryIsoCode",
                table: "ProfileCity");

            migrationBuilder.DropColumn(
                name: "CityPostalCode",
                table: "ProfileCity");

            migrationBuilder.AddColumn<int>(
                name: "IdTemp",
                table: "Cities",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "IdTemp",
                table: "Cities",
                "Id");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CountryIsoCode",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bcaa758b-b727-498c-ae0b-fcd9b4d7a338", null, "user", "USER" },
                    { "f2159593-0e72-4ced-b42f-f1b69d6b602b", null, "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileCity_CityId",
                table: "ProfileCity",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileCity_Cities_CityId",
                table: "ProfileCity",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileCity_Cities_CityId",
                table: "ProfileCity");

            migrationBuilder.DropIndex(
                name: "IX_ProfileCity_CityId",
                table: "ProfileCity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcaa758b-b727-498c-ae0b-fcd9b4d7a338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2159593-0e72-4ced-b42f-f1b69d6b602b");

            migrationBuilder.AddColumn<string>(
                name: "CityCountryIsoCode",
                table: "ProfileCity",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CityPostalCode",
                table: "ProfileCity",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Cities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CountryIsoCode",
                table: "Cities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                columns: new[] { "CountryIsoCode", "PostalCode" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c6d461d-f740-4489-9f02-4bec7b83fd73", null, "admin", "ADMIN" },
                    { "8134b87d-c667-4290-843b-0d12aab1f48f", null, "user", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileCity_CityCountryIsoCode_CityPostalCode",
                table: "ProfileCity",
                columns: new[] { "CityCountryIsoCode", "CityPostalCode" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileCity_Cities_CityCountryIsoCode_CityPostalCode",
                table: "ProfileCity",
                columns: new[] { "CityCountryIsoCode", "CityPostalCode" },
                principalTable: "Cities",
                principalColumns: new[] { "CountryIsoCode", "PostalCode" });
        }
    }
}
