using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "535a8cdd-8225-4cb2-808f-068a7af59721", null, "user", "USER" },
                    { "7969ff89-90a5-4825-8c92-b5e84f49b7c4", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("3748727f-2901-4bbb-bde8-d98ce7eee886"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("aa71450e-4464-4da0-93d6-1aa1323d8ec5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("8ce67045-af4e-4ef0-bfcf-5104040c5204"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("542cf787-3df2-44cd-8a76-856920d8447e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("6a7bdbc9-1780-43b3-bece-beaef6feff18"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("a8ef1511-988d-4071-8754-bf7baaed69b5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("a4b435fc-b51e-4e54-853b-1a4777c29d73"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("f73a8881-2691-453e-9b35-142fe86df106"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("c4c77df5-da66-42e9-981f-fff53bc17fd3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("be85f05a-c12c-4dfa-b9a8-d0c686b16782"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("fa5fc820-4190-4071-85a2-b9081b32b98e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("5fc9de83-2355-4e63-9e15-59f12981bcb0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("135b4cee-c428-43fd-a592-0837e11862b4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("0d366281-f4c8-4ee4-b65b-256995067f8a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("85b715a6-7508-4002-98bf-2e01441bacb8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("55d9a4b7-983f-4a0e-9f93-54e109b7e00d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("34be0b76-06b6-4052-a16e-6aa554aa0fb2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("6966ca2f-001e-4c21-ab71-a9caa2da2ad1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("6ffd088f-ab4d-4abe-8132-161bfaa2dc23"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("b0cc290a-ae5f-4460-a0e6-aa5f4c01414e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("eeea774f-baf1-4af7-9e04-0518992f73a0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("fd0d48e2-8f45-4fce-9bd3-c465bfb7b06c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("b37ba9b5-b810-4c47-999f-ec4161b1a71c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("64a278c8-b127-4589-abe6-b339d32f2208"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("8d394c4d-a6a1-42e0-891b-0e6947894f9e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("07f3347d-38bb-4c61-914b-b86f85426d92"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("ae2a1139-1471-47e2-8796-2ba3b3c004a8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("49b12316-00a8-48c4-8664-842e064d8357"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535a8cdd-8225-4cb2-808f-068a7af59721");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7969ff89-90a5-4825-8c92-b5e84f49b7c4");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("f05ed066-0161-44a8-b3f5-3fcc94da8b07"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("b6460337-a45f-484c-a2dc-5c8d6320a3fb"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("1034f2b0-df4b-41b6-9817-83bcc16916e9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("11163657-8a62-400e-a62a-ce4bf224ad0e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("6a330818-4e3f-4763-8f1e-cc21f6aaa3ca"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("41f9c38b-6640-499a-9faf-ea9a0f464ad6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("83f98274-53b8-43d3-8962-3839ca21b23e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("58c10399-a88b-4f7c-b4d2-a4efa10716f7"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("74e0e85b-d8e3-43e8-81f4-2bacdf59cd71"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("9b8222bd-0dff-4e1a-a3e3-7c0b3bd346f1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("ab5cc68d-5369-4d0d-8c34-42db7d5c6827"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("40dd2f91-e4d7-4d4f-a9de-42f127b61314"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("a9962bd3-d049-4975-8f37-04d564ccd8cc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("7c5b411f-f77d-4063-ae38-db4d71c56156"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("e37ba8ae-d7f0-445a-bab4-b50286749035"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("3874960a-d256-455d-8d06-d47200c2dda9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("5cc821ac-8f28-429b-867a-50ff3b2ec0c5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("11ad680f-867f-480a-9475-37797f688238"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("a9deb16a-a13b-4dc3-8cb7-ab56df76cb3d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("780e9a79-aca6-4a1e-9bb6-e4e9ca027725"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("d9115efc-158b-42c4-85ca-0e53ffe6e4fa"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("73956608-5232-4b64-8358-bbd76b4ba986"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("f878a312-ab7a-4a9d-b688-eda548e6142d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("8e80bccb-47a0-40fa-9a2e-8e33de4a16fa"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("c32c91aa-6614-486f-ae64-2cdd72f58d95"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("b95b353d-dac0-4f6a-8ca6-c838fb7e78e1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("932f51e5-28a5-46e5-aa9c-131881d2f240"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("91195424-15a1-4faf-b166-99e65b1790ac"));
        }
    }
}
