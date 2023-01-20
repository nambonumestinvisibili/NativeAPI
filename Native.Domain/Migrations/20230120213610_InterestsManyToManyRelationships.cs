using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InterestsManyToManyRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Events_EventId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Profiles_ProfileId",
                table: "Interests");

            migrationBuilder.DropIndex(
                name: "IX_Interests_EventId",
                table: "Interests");

            migrationBuilder.DropIndex(
                name: "IX_Interests_ProfileId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Interests");

            migrationBuilder.CreateTable(
                name: "EventInterest",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    InterestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventInterest", x => new { x.EventsId, x.InterestsId });
                    table.ForeignKey(
                        name: "FK_EventInterest_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventInterest_Interests_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterestProfile",
                columns: table => new
                {
                    InterestsId = table.Column<int>(type: "int", nullable: false),
                    ProfilesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestProfile", x => new { x.InterestsId, x.ProfilesId });
                    table.ForeignKey(
                        name: "FK_InterestProfile_Interests_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestProfile_Profiles_ProfilesId",
                        column: x => x.ProfilesId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("39bb242e-4bfa-4c90-979b-f332826112f9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("d9ed22da-13a9-40aa-9ab2-b72aa9933237"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("c4890aa6-de61-4b04-b488-c9c589653b86"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("0e3a2ccd-7d11-4c17-8b76-1f2aa1c20b67"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("250fcfdc-28ab-4507-a4e3-355bb5900379"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("6efa59d7-8247-4afd-9ab9-c53e18f8bd40"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("f45bda88-42d9-4387-a129-4842cd256796"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("b062067f-4b85-4cf4-8e26-8db74af9b623"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("669e7f37-99bd-4492-8667-3dca251c0e93"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("f711ef89-7817-408a-8846-8f3e42e83c2b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("8b30f25d-8edb-46f7-99c3-205f767435b2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("df21ec23-b4eb-480e-9832-2d5d27bd38ed"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("3fd201ef-58fa-41cc-b3a5-09f4163d19e0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("d51ab234-2c7f-4383-b8ad-8fcb58c7a934"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("201aca2c-a441-42af-a0db-c60111b1a075"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("2a755c6e-92fa-4274-8d41-44cc0ede8a4d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("6258eb7d-2659-4a0c-8f4b-d8b9a6950a8e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("b55de903-cad0-41b8-8e47-f6ef6800d8dc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("d8a260f9-e175-40af-bfbd-627d54e467b6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("e4f109b9-cb0d-4249-83c7-dd8105537c79"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("bd47b816-0f80-4ad3-8802-4cb19b731618"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("a33dbc9b-411b-4374-97f5-6bf06df69c0f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("ca52695b-8eeb-4550-a9be-284b2a3ece85"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("0fc50f00-5713-475f-a22b-731d194819e6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("57c98ea7-36b2-4bfc-abf2-025c4eef538e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("8924b8a5-7e19-4375-8c18-d5bc47e71e55"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("779d8b8d-91b1-4369-b8bc-bd0adf30cea6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("b7751e79-c313-47f7-8dab-c1b6276b60ae"));

            migrationBuilder.CreateIndex(
                name: "IX_EventInterest_InterestsId",
                table: "EventInterest",
                column: "InterestsId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestProfile_ProfilesId",
                table: "InterestProfile",
                column: "ProfilesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventInterest");

            migrationBuilder.DropTable(
                name: "InterestProfile");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Interests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Interests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("69753e37-db4f-4316-b290-d37e143f7ea0"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("02978727-d846-472c-9481-8ee80009c8b3"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("e33e2f27-b384-474b-bb25-43ad540c2b93"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("0fa3090c-cebc-4483-8298-b7b9dd2d081a"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("30bc0c5d-4595-44f7-80a5-72e7b5741ac8"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("4ff52b1f-a63e-4a99-818e-3609d6fbb08e"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("0673c1e9-071b-4bfe-95cb-683b4e362036"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("23e2de27-1adf-4281-b7dd-fd070b415edc"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("474e7001-0ae3-4b3c-832e-ac2b0b4989be"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("d2616061-7c18-4541-9837-6e13c41edf83"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("787f8d44-a8e5-4f08-bcdb-830dece546a9"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("d4c9225a-8c93-4c73-b3f5-d385a5c7e29e"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("75bc37bb-4d05-4dd3-ba46-db86b65f4bb1"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("10b9cafc-4288-4eb0-a609-c93bc924ef4f"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("6f731371-ad1d-4659-bc9a-8d39e216b5f5"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("6f2bee20-a6c9-4e0a-8b5f-938aac84076a"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("5e616ec1-03ed-4eeb-8c56-6f6fdc1fac5a"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("823bf553-87a9-4734-aedd-acf547a56f36"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("793109b8-66e8-4fa1-b43c-bf172fbd5389"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("767daa92-dda3-49d4-834a-250974610f47"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("83a42086-50ca-465c-b23a-2463d9b5f442"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("ae8ffa90-da1d-496a-b65e-08daf4b33aab"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("24c7e1c3-41a9-4349-9c04-4e64620c3610"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("506e0e91-c2d1-432d-b517-7287db8e1813"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("b4e375e8-8ad3-47c9-834c-3fe16ac5cd59"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("1521e730-8ef7-4973-885c-fa8b867ae335"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("7d0fe34d-fa87-44bd-a032-7ce2653f54b9"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("31721885-d5ab-40b7-9e9a-611fda0dd1ae"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_EventId",
                table: "Interests",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_ProfileId",
                table: "Interests",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Events_EventId",
                table: "Interests",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Profiles_ProfileId",
                table: "Interests",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }
    }
}
