using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullValuesForProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1468f41b-4211-473c-bd0d-c81aa78a9ef7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e60b4f72-6c9e-43c7-b411-f74ad52103ac");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Introduction",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDayDate",
                table: "Profiles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b0c94e4-ffb4-46bf-9afc-4e7086d057c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69c4cfe9-c59a-4f13-a638-8930e5f37447");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Introduction",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDayDate",
                table: "Profiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1468f41b-4211-473c-bd0d-c81aa78a9ef7", null, "user", "USER" },
                    { "e60b4f72-6c9e-43c7-b411-f74ad52103ac", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("7f70501a-adf6-4bfc-b5cd-a9f977f13a3c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("1b075e76-b1f0-420c-99a1-0fb730c39eff"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("5e279aee-0be4-40e0-aa44-89e93dd598ab"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("fa8bbd97-39be-4057-aad6-b0ef74de82cc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("8aafaaf5-5079-4c7a-9434-8e75c5cfb5a7"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("79dd7cb4-c13d-4250-9ba9-219a4f8ac7ac"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("f86efedb-71f0-447f-959a-2ebac5bdf89b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("0b931e7c-2cb4-44b3-ba26-78b1c1e56f81"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("5992e306-381e-4d47-8240-d0b23b22cbfd"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("da136cdf-2366-4612-a780-36345e7a0934"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("7364caa8-496c-4fb7-9e78-d20049971611"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("b403cbe4-39ba-4bcf-87c2-ac12f554f08c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("d4131395-70d8-4383-a68d-df96d0b1eff5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("36131fe7-2666-4498-bf86-49865924db6e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("f404d1b9-5354-435f-8814-1bbd170a8ef6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("8dfd98df-7bd1-406b-9df7-8493c5fd7ea8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("3ea1b9b3-ee12-4b89-ba24-b954c4124017"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("873179de-2da0-4b26-ad20-073f0b06f13d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("30507392-e605-4095-ac2b-c94ffdaedc1f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("1e997506-7a15-43ab-8676-a83fb1c3147a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("1455648d-847f-4302-9dc8-07fffae79a48"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("bab7169a-a29a-4797-88e6-ed07ef9e8c95"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("ed2c2149-e75c-4d59-8e10-6f2c19827022"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("0b62fd85-dc23-4628-a79f-4b061bcf7576"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("32a89890-e1f7-443f-a190-a27448f36557"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("51a41961-3d68-4be6-95ed-eff43e411387"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("75ff8115-dd6c-4d1e-960f-d024e4fad07b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("c75e532e-420b-432e-852a-76fa28a01fb5"));
        }
    }
}
