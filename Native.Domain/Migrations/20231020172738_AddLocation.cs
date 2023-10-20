using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Residences_LocationId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Residences_ResidenceId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Residences",
                table: "Residences");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aa0aaf4-db3b-4285-a20a-f233248cc4ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4fd2d71-e5ef-4d30-8a75-9552dd2033b2");

            migrationBuilder.RenameTable(
                name: "Residences",
                newName: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "775b81fe-841b-436b-80ff-e11685ee91a2", null, "user", "USER" },
                    { "a9dff1b6-5b7f-43d6-98d9-10a8c0304a21", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("2cfd8ae9-eacd-4125-9edb-347e65b0f356"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("d68688d5-669d-400e-abbd-8faca3d506e6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("f791cc41-bd4d-4617-a0d6-a50b8336c8ee"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("0d6dfee3-9dfa-4310-994a-1f9b129ef08f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("0961fcb7-36f5-4039-8b03-500229e000f8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("81aa5363-4ade-4b74-9016-9eeb1ddd578e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("8547f75d-4440-49fb-a375-d24e1636b71b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("9d4573f3-5103-442c-9409-8cf5d4850d2a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("7cb25e9b-0199-40e8-8155-3835a8009e64"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("699679fc-5476-47e7-a4f6-d78b8ef9e0e6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("07623488-4978-4a67-a6d1-647f785c55de"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("ee4276f8-28df-44ff-822b-95fb71af384b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("2f3ab3c5-8752-4b54-9358-f322d1da403b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("78d367fa-8955-4a86-af98-8fe1e0e8bde4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("0af8762b-0305-4095-8984-1aeb3b0926ee"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("32ce4bd1-0e40-4557-80d7-d76e101fcb83"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("74d7ba61-16bb-4410-a3a1-19157b087b14"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("e885824c-b085-4c44-8cf0-c2587a40d50b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("b8a5a259-4761-404c-ba70-5c0084437565"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("6f0f3f1b-bced-4702-aa5c-6ace6330ee6e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("8b022212-d3d3-4666-bbd2-622a3db04d5f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("9fd42124-6054-4286-984a-20d04814bfb0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("58357838-f27a-44e9-ac8e-7599033f4eb2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("22d304f0-754c-4ee1-b685-d62b86c002d6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("ba06fb02-8e1a-4594-9a73-00e4901b868c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("0a410e64-c9ee-4ebc-92b5-abbcd7889ee8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("61f30d56-8de3-42be-91a4-b86dcbad8df5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("e91256e6-40c2-4ec1-b527-65651badcf81"));

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Location_LocationId",
                table: "Cities",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Location_ResidenceId",
                table: "Events",
                column: "ResidenceId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Location_LocationId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Location_ResidenceId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "775b81fe-841b-436b-80ff-e11685ee91a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9dff1b6-5b7f-43d6-98d9-10a8c0304a21");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Residences");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Residences",
                table: "Residences",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7aa0aaf4-db3b-4285-a20a-f233248cc4ea", null, "user", "USER" },
                    { "c4fd2d71-e5ef-4d30-8a75-9552dd2033b2", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("dd491987-6598-490e-ba86-2b14c818bc66"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("a55b6030-b4a4-4733-820e-0602cc5b7513"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("6d6ce561-cc3b-4e47-a362-0151ae9d6caf"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("0464a67c-dbdb-4df9-b48e-21c36e375e2b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("6037223e-a825-48bb-af10-9a7fb8ff0717"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("413f5884-0e7e-4e89-8bc7-b23d5a206048"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("e1af17e2-6b5c-48fd-a865-4e482908d618"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("a8b1eb31-c951-4ebb-a1c6-31af4436a998"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("337e5f0a-43c8-494a-8069-4f10742be38b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("0a6d00e4-cdc9-4d01-aa56-22b62d06a4ba"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("ac60a70f-2ee6-485f-a07f-a368e5fc9d28"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("2f1a1a78-0ad2-4031-8801-489f6b2d34a4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("aa07821e-f62c-4277-845d-a47193dd8213"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("2619b0e2-2f41-4dd6-8dd7-730a70e6ba40"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("6159b1bb-2a4e-4369-9080-6dd515bdc47d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("498d76c5-3b60-44f8-a804-0ba39ae57e53"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("81cdd33e-6de1-4217-adec-4463fac875db"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("495d5b64-e601-4c34-b2d1-7c35ee552680"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("85fec776-26a8-4b8c-bf85-ec830e120208"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("ce605d09-ef7d-4101-b075-87ec3203f0c8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("00f083e8-72fb-4843-ab70-a04fdd44fbca"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("70aff8f8-55b6-424d-a65f-5df04c84ee01"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("9bb47660-7403-40ae-86dc-4daae2fb86f5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("20e663b0-0fff-4253-8589-f3140cd3eaff"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("fbd1d348-b66f-45b0-973a-6d455be8668c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("df269375-e1fb-4467-a18d-a86470d35321"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("94da87d9-cd3d-4011-a0be-fc2b8bfd4aba"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("5844b29a-b2f2-4875-8a18-d929443fae78"));

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Residences_LocationId",
                table: "Cities",
                column: "LocationId",
                principalTable: "Residences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Residences_ResidenceId",
                table: "Events",
                column: "ResidenceId",
                principalTable: "Residences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
