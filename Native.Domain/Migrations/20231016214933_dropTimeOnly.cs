using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class dropTimeOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b0c94e4-ffb4-46bf-9afc-4e7086d057c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69c4cfe9-c59a-4f13-a638-8930e5f37447");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b97ad0a-fa6f-4631-b3e2-4b6d3cb37ba5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dbbcb5e-2777-4066-8f7d-bd93fc8d87c9");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingTime",
                table: "Venues",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningTime",
                table: "Venues",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingTime",
                table: "Events",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningTime",
                table: "Events",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b0c94e4-ffb4-46bf-9afc-4e7086d057c2", null, "user", "USER" },
                    { "69c4cfe9-c59a-4f13-a638-8930e5f37447", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("61cfff29-83a4-45a9-be4c-c4614034fdca"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("0e6b732e-837d-4318-8c94-4b1581b11aca"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("94b0a9d2-561c-454a-a887-a8fca20a2d03"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("c3e69026-1c28-4b01-bcd0-2901502174ee"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("20bb3ff7-d539-40c6-a88f-dd5e0a1ba7a4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("caf4287c-aea1-423f-8fd6-2c725ad41a87"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("3f6d9db2-1e40-426e-8b4b-808f93e385a5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("731ec57d-1cf7-46d4-872f-bcf741457d08"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("2b12d440-009f-4d99-9f04-b455d1c7f4ce"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("75bc80ce-a93a-4466-977b-8792a2b9b46e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("dcf3040d-983d-442d-a80f-c439b77e574c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("6edc973e-1f3c-4612-af73-ed68e14e1430"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("34f3b59b-c37e-41b6-9a8a-162a5499c360"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("e572cd56-3dc9-4e27-ac08-9da4ae15830f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("3315607e-95c4-4ceb-a61a-c289a2a23209"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("23b1a6f6-6f41-42b4-bc9b-b1eb3e8661a5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("ae692a7d-2f1b-483c-bb1c-1c80adbdeccc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("a363006c-94b6-4d7b-847e-77b2fac03849"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("5973fab2-7e94-425a-bd76-a92e5cb81be0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("e7a5140b-4bec-43e5-81ee-9f04dcd5f4f3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("3b6ac996-8091-4717-864d-11b7cb577403"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("39567fda-6bd9-4a7f-9960-a5a55d2838f3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("de116960-4238-4d45-9be2-229113e7f833"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("7b962e52-eb0d-457a-ae71-a5d9b2b85c1d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("708c1e5e-84e2-49c4-b8ff-4ce3ca634636"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("ebeac9cb-5718-4b8e-9db3-8289b749f1f1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("b532429f-c582-45f8-af52-d07409d9b49e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("c6cbce34-c677-4168-b311-15674d2eca7c"));
        }
    }
}
