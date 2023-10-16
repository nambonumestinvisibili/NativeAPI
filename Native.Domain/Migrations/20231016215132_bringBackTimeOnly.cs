using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class bringBackTimeOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b97ad0a-fa6f-4631-b3e2-4b6d3cb37ba5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dbbcb5e-2777-4066-8f7d-bd93fc8d87c9");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ClosingTime",
                table: "Venues",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OpeningTime",
                table: "Venues",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ClosingTime",
                table: "Events",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OpeningTime",
                table: "Events",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "834b343f-827b-4a12-a9b1-b92ebc514961", null, "admin", "ADMIN" },
                    { "a03a576d-406e-4294-ac87-f059b1d81624", null, "user", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("8b36b8a7-68e0-4144-897e-706bd2188374"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("9d55aaa1-715d-4010-88df-5a2e0df25007"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("1e4e676f-525f-43bf-8ef3-d1b330c96562"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("6f13dd55-438d-4a6c-892b-2045ffda4540"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("3009faf9-20a6-4fc1-b38e-963065069135"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("9dd3f057-e9ae-4340-b6e4-a42eede8a5c1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("d889f5cc-415e-4b99-b1fd-5403ff6c91ef"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("61414e9c-491d-4259-b325-2e0718d3f9f8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("5c434aea-054f-4cfd-b19c-2c3f41b64808"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("9d5ea3de-b8c3-4363-97c0-5349174fca6e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("11e74a6b-3231-4d4f-bdb8-c9b1ee3e88cf"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("03f6e0c1-5a10-4fe0-8dfe-9a8e310675df"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("d2bda9b8-63ee-4366-b86e-7dd33fe5bf25"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("70560b9c-e99d-4451-9c5d-7047b5779083"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("67420291-213c-489d-b513-e938bcbeef9d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("2b6031d3-7960-400a-ae14-d9bf63e5ba08"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("044d6763-ef30-4f73-ba34-962ace807b98"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("1ae8e656-6097-44e7-ad45-a07013e7036c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("3558d6ee-fbe6-4916-bca2-546151de151b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("a1ddef72-94f1-4a56-959d-42976150f1e3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("c8927c07-f772-438e-bc81-174b27b65d37"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("215ad8be-c2b9-48e2-87eb-fc7729ca04a9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("d7e2f9f9-fd94-4f3e-9114-806850951820"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("9ca04a05-70ea-476b-9d68-367cc8b3ddce"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("dca131f5-b303-41f5-9cd7-fc6b8fbb6da5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("c079e38c-5d84-489c-a60d-416baead172a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("7706c5e7-15b9-4f9f-a437-5af6558c934a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("a0b8fd11-a255-43b1-9e01-f26772641e0e"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "834b343f-827b-4a12-a9b1-b92ebc514961");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a03a576d-406e-4294-ac87-f059b1d81624");

            migrationBuilder.DropColumn(
                name: "ClosingTime",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "OpeningTime",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "ClosingTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "OpeningTime",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b97ad0a-fa6f-4631-b3e2-4b6d3cb37ba5", null, "admin", "ADMIN" },
                    { "9dbbcb5e-2777-4066-8f7d-bd93fc8d87c9", null, "user", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("11544dba-cd2c-4807-a7db-81f4b1454bbe"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("8238d63d-0da3-4f89-84c0-adcf5a3e88f3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("5c182a3c-473f-4688-ad3a-08ddaad63639"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("2d2c4032-f651-4067-a368-9227b817101e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("202b71cf-06cf-4189-999e-c2f0c5807ca2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("14eef2eb-337f-4f57-8345-3063810e1e43"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("1d360c5c-83b9-40d3-a3b7-7d84f45c320b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("12ddc4d6-b45b-4a03-9724-373bf2ce9986"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("f42b5c21-fcd0-4fa3-9778-c67869edc9a0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("792feb00-9595-406c-bc0e-e70de4871fda"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("bfe67ef5-7efc-4e75-9577-10ed3d055c60"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("c181d0be-e210-4f64-a3bb-8f36ca9b60ba"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("48c8861a-96f4-4747-8c4e-bfab87afeab1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("82066fec-5643-4fd3-af58-98a4d73bf419"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("4eb24369-39ef-4a39-8260-80bb4bbdaa90"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("b2252d08-d95e-49c8-9d3c-38069e54ec41"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("6a84c3af-2927-410d-ab0a-921213e16d75"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("33d79a40-ec43-4b29-bbc4-2fa3064406bc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("a430b3cd-69e6-44d1-a984-296035f00f92"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("a05503b7-86bc-4f48-aa12-6002aa7be414"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("30f4f279-23fa-4ace-a726-06af7de65942"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("04a87983-cb3a-4e97-8303-0de8023f6821"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("4474796b-58ed-4b40-82c4-7d98ebd92ff7"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("0744bf1c-ca79-463b-8d97-99546f305cc3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("921b410f-00e8-400a-905f-17f847db3276"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("1a132385-a2a3-4257-9950-7919455faa0a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("c119e1aa-9298-4b04-acdf-56f19ea48913"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("e291a461-5cea-43e4-8b65-aea051f277d0"));
        }
    }
}
