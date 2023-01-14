using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class ResidenceProfileEventModelsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Residences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residences_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningTime = table.Column<DateTime>(type: "date", nullable: false),
                    ClosingTime = table.Column<DateTime>(type: "date", nullable: false),
                    Charge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrganiserId = table.Column<int>(type: "int", nullable: false),
                    ResidenceId = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Profiles_OrganiserId",
                        column: x => x.OrganiserId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Residences_ResidenceId",
                        column: x => x.ResidenceId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("eee8bee6-33a7-4882-81f4-2289c4f9d287"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("d631c933-526b-47b2-b779-c260df6c84fd"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("50d55269-be53-48cf-9b5f-b24fdee285f4"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("f6af3183-8852-4b29-8986-483879e6096d"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("29399eda-12a6-4c58-8684-e60436f91a93"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("7b0135a3-20da-4256-aa56-f4eaa17eea8c"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("6eaac426-0602-4081-a28b-4c6e28940a95"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("42ab0d6e-7dab-4947-b3be-d448bd53862d"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("6193b542-41e8-4202-8329-8aa0762fc9d4"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("1761f1bb-77b9-4d09-845e-b1c833f5a7ff"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("4a74b9f9-7dec-4831-bdc0-1ab568a2d51b"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("27657095-a5de-4eee-933e-6391276fa995"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("d37bf92c-5cce-4538-ba6b-1d1b65d9b1a8"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("2a0c85a9-ae7d-4f8d-8591-338446598148"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("593970f5-d1ac-4109-a5c8-641daf282034"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("862302b1-023a-42c3-af52-1263d390719e"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("ad50fe12-9268-40dc-96e9-23b7ddb9c551"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("69985c3e-85d5-4a21-943e-57836e009dbf"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("be09f33e-2922-48af-b0e8-6f08eb3407ca"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("55c5b7d6-f5cf-437c-9a5c-033f105d9e7b"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("efcbff13-ad05-46c4-ba6f-6736436b3235"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("408943ec-b7b8-43bf-b7d8-3861d0fd6ef8"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("d400c54f-4f7c-4156-b064-aeb3fa282544"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("a496e0c0-39c2-4bf2-b44d-9994f5479e29"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("84111945-a8bc-4c9d-8114-8b26299bc758"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("1c0f8923-fbfe-4156-8d73-91e41205b699"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("c22669ea-d922-4f63-92ad-b9933e61825b"), null });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EventId", "Guid", "ProfileId" },
                values: new object[] { null, new Guid("fd56bdf0-6941-4d80-b137-2131bc40da78"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_EventId",
                table: "Interests",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_ProfileId",
                table: "Interests",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganiserId",
                table: "Events",
                column: "OrganiserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ResidenceId",
                table: "Events",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_ProfileId",
                table: "Residences",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Events_EventId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Profiles_ProfileId",
                table: "Interests");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Residences");

            migrationBuilder.DropTable(
                name: "Profiles");

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

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("fd77dd91-9abb-4b13-9874-e3c434a3e7f1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("9c24a8d7-4ea9-44e7-ab47-a30c5548343d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("29ffd50b-a6db-4b26-850b-317cafc2b3d5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("536d0abd-597e-4e5b-8f15-472698a32101"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("41c29560-8c83-4896-ad8c-5d8eb56621a8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("c48b0aba-39d6-4721-9c30-69148b4b4bb6"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("0d10e2f8-b6a3-4938-bf1f-b431341ec10a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("fcf72a67-26cf-4ec6-a4fe-98395cd6cba5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("68240a7c-7871-4915-bb84-8f1eed174121"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("0dd213ef-70a2-4870-8e10-61a6e47e6cea"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("2ce239ca-74cb-4c88-8ef3-64c9eb16e0e7"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("45f37cac-ed46-4f9a-8723-516a80e83fdc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("121fc651-3836-4a48-bac3-cf07cf6eee66"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("915c3957-09e4-4207-ab9d-7f419c69fca2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("3965f136-26a4-4ca0-9f0b-b2b50311207a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("e2177139-9210-47a8-b133-e517e2ca34e3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("6b706dee-5943-465e-b145-b3483c2a946f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("af9444fa-5e90-45c7-8b4e-0daad9efd6bb"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("627c1207-1200-4686-84e4-43980f215da1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("8068ba84-67d6-4c6d-bb41-d7691c1fd147"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("7d1f3cde-564c-41d5-bde2-b8e55903a926"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("3ad52878-f435-4bc8-b28a-092751808599"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("ac26421e-25a2-4dab-ac3f-973abd7ac63c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("c17cd949-17d4-4d84-9a6d-87f7c5a679d0"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("40f55dda-0458-48ae-9ba1-48eda5dee02a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("0b8d7fb4-ae93-43cf-b859-d002a6b0ffc8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("757d0068-77b0-4b0b-8568-5bd8e9a24d3a"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("22de8aa1-ab67-4a79-a2c9-9758e56c056f"));
        }
    }
}
