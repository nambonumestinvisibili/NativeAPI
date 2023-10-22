using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddCityToVenue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92891f02-9efc-46ce-930a-7f3e79a8b203");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e909c5b2-2284-4050-b1b5-3e670e719699");

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
                    { "17c0b1ae-be18-4c32-8a2d-cc7dd481904a", null, "admin", "ADMIN" },
                    { "1947dc29-6da3-4244-a679-8c6c6965c37d", null, "user", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("e2cd076a-880a-4edb-9ac7-80dcd79c0fda"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("bc802a29-61b9-4402-a7d3-b403c1db180c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("0ff58589-fb34-4125-b43f-a4796ef764ff"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("248a60c5-c476-48e5-b063-0aa1b2792c06"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("6f03f580-1ae8-4e5b-b955-379d5c08ab95"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("48ab16b1-a5e5-4940-a6f1-fc3ba604eac2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("ee32a23f-01a3-4fc5-8f60-834866fd4c3a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("098e58c1-c6b2-4055-9cd0-1a947022dae6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("d666ce1d-6bed-4800-9ed0-291161b915bc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("88d7b4a1-b520-4f42-b2b8-a5a712714543"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("302efd2b-47f3-4210-8f8f-f3daf78ee635"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("a4926365-e8be-4303-b16b-e9f761e303fc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("16a1aad9-44f3-48c3-a3ce-397b99edb0ca"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("a6839312-84d6-43c0-a0e4-7aa0ebe423c2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("68cf7522-8ad0-4e5f-a1b9-261319c22de4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("48b4c466-b8ca-4fe6-9799-0208902c9fe7"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("1390679e-b383-477b-83ea-b64bc81732d7"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("fba87eb8-705f-4d31-b2bc-455473472ce8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("2a4c4e31-2b5b-4d47-bb9a-132c08b116f1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("bdad0738-1d5a-4c1e-baa5-8a5c6fac7d04"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("0b427701-8451-4e46-8a5f-7514179c2c29"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("dfdcdc37-4d71-4992-93cb-9c4c9b9bf2e0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("75d233f3-cdcb-4688-b1cd-f200a6d99c39"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("575af4bb-a670-4596-a6e9-2728b94e0dfc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("70bb4993-9b7a-430f-a4c6-7ed506e9f458"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("5253a2d9-d9fb-48f9-b41a-d7a6a6e1c8d3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("e6baf2ec-f87a-4e42-98a6-378ee89de8c9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("24daf68c-7278-4e9c-929c-c989b0db74d4"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "17c0b1ae-be18-4c32-8a2d-cc7dd481904a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1947dc29-6da3-4244-a679-8c6c6965c37d");

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
                    { "92891f02-9efc-46ce-930a-7f3e79a8b203", null, "user", "USER" },
                    { "e909c5b2-2284-4050-b1b5-3e670e719699", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("63b622e7-8111-4fb2-a8cb-368702a1ecc0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("5b6e1396-9cb1-4fe2-9c60-f3f41dc0cbeb"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("9383824c-6a5b-4c23-99c0-9187900a1f3e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("85f35995-7b3e-4c54-9a10-c6021bcb096f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("7ff94907-1174-416d-95b6-7a9ea4857358"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("5e317ce1-aa58-4899-8bda-a51eba493066"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("5feca84c-e5c8-42e5-b7ef-fa823b4385ea"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("a97c7b41-a01e-4833-b2a9-9142ae0e9a99"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("36cef5d3-335a-47b6-864e-8a61e14860c9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("37e0700f-c020-46bd-bc23-004e39c3ca5e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("85dcc9ad-9fc9-4379-b176-97e64362baf0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("6e403797-8d08-4a74-abc7-4d36ae0b3191"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("854f6daa-c312-42eb-bd48-7c9efdc60e3d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("27db7bdb-4631-469c-aa3b-56ebd4c7c1e5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("c69fc06e-2c3e-4f5f-84a5-e79d456ac70b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("6b3f1c21-bceb-4459-83db-e93d46408e84"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("47ba4df0-72b9-42a2-bb39-81beddbedf7e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("5cb25890-ac25-4f57-a7f3-7dd55bf413d0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("d2237055-61be-4f46-be78-a7ce57a896cb"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("e6840c4e-ea1b-4900-ba33-acb730be1e64"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("13ad7b80-6884-496b-b5d5-f8eee52670c2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("feeac283-d893-446b-9e3d-799c361f18b9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("e28129db-3fe7-43b1-aab8-c6d78532e9e1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("ca0996f5-dd89-4319-b776-3f244cc75d7e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("0f875449-075f-4303-b9bf-c972e87c5b67"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("672f0078-49bc-49d7-88d7-c28342cb51a1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("1b119054-2ebb-4576-946f-b786c557b5aa"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("7cdff06a-68aa-4fb3-af64-393746bf525c"));
        }
    }
}
