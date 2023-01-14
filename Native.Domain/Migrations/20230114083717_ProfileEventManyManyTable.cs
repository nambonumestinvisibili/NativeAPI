using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class ProfileEventManyManyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfileEvents",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    InvitedById = table.Column<int>(type: "int", nullable: false),
                    StatusOfAppearance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileEvents", x => new { x.ProfileId, x.EventId });
                    table.ForeignKey(
                        name: "FK_ProfileEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProfileEvents_Profiles_InvitedById",
                        column: x => x.InvitedById,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileEvents_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("d6f17768-ec09-47b3-8b3c-8f72e003acec"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("292c93c0-f7e2-4a1a-977e-753dd5ef998e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("3c695f4a-d7d1-49cc-ae22-68a3f84d5758"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("21d82e14-ec5d-42ce-ba42-9a1854c4a04c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("efce3252-c7ea-4b27-837c-9139950b2e00"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("82df6662-80ad-4fa4-a921-45c91f425eb5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("dc61a969-942d-46e2-853a-fff9fd70c5cb"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("86c37b80-ac51-45ab-97c8-50a81d1e5266"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("23f00fe4-df69-4de0-88c3-a5c8e893fb8e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("0866be37-a84a-4e1c-8eb0-3772ed7c58f2"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("f526f908-387c-44ff-8102-116c634134c5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("b0637114-b82d-4bb2-a3cf-12805e5a47c3"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("a5ad8920-29ce-4e0b-bf75-464006fdea0b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("995cca0c-d3a2-4822-a6f2-1f4937695416"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("86b11bf1-6941-420b-827c-2f701dbbbf89"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("bb1ab5af-2403-4f52-be70-21699e1b449f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("3c7b551b-b4a5-4513-a4dd-921f6cc503aa"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("4150b2e4-623d-4aae-b6f8-77c24d3da296"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("d5062449-7514-429b-b15a-c720e1473762"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("187cec9f-b3f0-40f1-8460-2353cd22e569"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("6bb90284-1b8c-472c-b4ef-a3a125a6634d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("25ca3e8d-535c-409e-96f0-554b66f4e63c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("af615b68-46ff-4b58-9ec6-bee8ab4dc48f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("4978f189-5b99-42d9-a409-41f7431a1f6f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("88c97b04-7dc1-40bd-946d-e2728d5c6702"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("6e293a40-1fdb-424d-8810-0b5e8a2bf5be"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("09e0f0cb-f2a6-4e0c-a18c-6b4e7aa0b2a4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("40cd5e16-2cf8-490d-9c47-125854024433"));

            migrationBuilder.CreateIndex(
                name: "IX_ProfileEvents_EventId",
                table: "ProfileEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileEvents_InvitedById",
                table: "ProfileEvents",
                column: "InvitedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileEvents");

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("eee8bee6-33a7-4882-81f4-2289c4f9d287"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("d631c933-526b-47b2-b779-c260df6c84fd"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("50d55269-be53-48cf-9b5f-b24fdee285f4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("f6af3183-8852-4b29-8986-483879e6096d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("29399eda-12a6-4c58-8684-e60436f91a93"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("7b0135a3-20da-4256-aa56-f4eaa17eea8c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("6eaac426-0602-4081-a28b-4c6e28940a95"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("42ab0d6e-7dab-4947-b3be-d448bd53862d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("6193b542-41e8-4202-8329-8aa0762fc9d4"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("1761f1bb-77b9-4d09-845e-b1c833f5a7ff"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("4a74b9f9-7dec-4831-bdc0-1ab568a2d51b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("27657095-a5de-4eee-933e-6391276fa995"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("d37bf92c-5cce-4538-ba6b-1d1b65d9b1a8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("2a0c85a9-ae7d-4f8d-8591-338446598148"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("593970f5-d1ac-4109-a5c8-641daf282034"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("862302b1-023a-42c3-af52-1263d390719e"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("ad50fe12-9268-40dc-96e9-23b7ddb9c551"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("69985c3e-85d5-4a21-943e-57836e009dbf"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("be09f33e-2922-48af-b0e8-6f08eb3407ca"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("55c5b7d6-f5cf-437c-9a5c-033f105d9e7b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("efcbff13-ad05-46c4-ba6f-6736436b3235"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("408943ec-b7b8-43bf-b7d8-3861d0fd6ef8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("d400c54f-4f7c-4156-b064-aeb3fa282544"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("a496e0c0-39c2-4bf2-b44d-9994f5479e29"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("84111945-a8bc-4c9d-8114-8b26299bc758"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("1c0f8923-fbfe-4156-8d73-91e41205b699"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("c22669ea-d922-4f63-92ad-b9933e61825b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("fd56bdf0-6941-4d80-b137-2131bc40da78"));
        }
    }
}
