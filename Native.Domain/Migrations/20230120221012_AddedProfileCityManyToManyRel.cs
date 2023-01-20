using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddedProfileCityManyToManyRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_Profiles_ProfileId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Residences_ProfileId",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Residences");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CountryIsoCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => new { x.CountryIsoCode, x.PostalCode });
                    table.ForeignKey(
                        name: "FK_Cities_Residences_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileCity",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CityCountryIsoCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CityPostalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsProfileNativeToTheCity = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileCity", x => new { x.ProfileId, x.CityId });
                    table.ForeignKey(
                        name: "FK_ProfileCity_Cities_CityCountryIsoCode_CityPostalCode",
                        columns: x => new { x.CityCountryIsoCode, x.CityPostalCode },
                        principalTable: "Cities",
                        principalColumns: new[] { "CountryIsoCode", "PostalCode" });
                    table.ForeignKey(
                        name: "FK_ProfileCity_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("8ccf416a-7a3b-40ed-948e-21044db8e3fd"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("afe224fc-9c18-442f-a15d-57de1189b675"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("09f5c800-be49-42b0-ae0c-23a01f87c00c"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("f8954857-01d1-4b1d-87a1-fb162c9af7e1"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("cdd58bb4-f5ad-46a7-8a2f-9bb9416a34e9"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("e877cba3-df2d-4813-9a33-5c062dc07396"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("c7d415a6-a7c8-4cbe-994a-59072f875dcd"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("23183c4e-1676-41c3-8cc3-ddbc0554f352"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("3707843a-0e05-4cf8-b63d-42105a9a56af"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("9f636856-8229-45c5-8805-0dc77e373e2b"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("c7d21f63-0563-40e3-b9a6-52bc770a0f90"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: new Guid("7226a280-2cfb-4265-a506-054d16a14d85"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: new Guid("389dfd35-1e7d-42b8-bc9e-1214ed526955"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: new Guid("4e2e89a4-79fc-4443-a980-9f58714e6dea"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: new Guid("7dc09e96-c203-4372-83c9-ff24b9ac42ab"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: new Guid("47280f98-e020-470d-989e-a8a248b609ff"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: new Guid("5723c441-a746-496f-b7bf-5554c7379821"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: new Guid("40fe00b7-775e-4ae9-8853-a7f4d7b29baf"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: new Guid("c26b9389-9f61-4fd2-b367-b845a350b192"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: new Guid("12379ac5-5e7d-4138-a878-1cbf9672f63d"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: new Guid("42a7db09-cdf9-4a09-ba2d-b571ed6628f8"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: new Guid("409bb0f5-2d07-44d8-aa8a-4a3c43dbdb31"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: new Guid("1a843b5d-15aa-4509-b2e9-781794a33320"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: new Guid("c432aa06-f5aa-45c2-a928-388e2bbed6fc"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: new Guid("0ccd71cb-abe1-45dc-9196-13853e01693f"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: new Guid("d615514e-03fb-477f-8b46-047c8f3f71ea"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: new Guid("375ab950-95f9-410c-9aca-02c93dafa7b5"));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: new Guid("6d8bdcf1-874f-42d5-8fbd-72abe6ebb41b"));

            migrationBuilder.CreateIndex(
                name: "IX_Cities_LocationId",
                table: "Cities",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileCity_CityCountryIsoCode_CityPostalCode",
                table: "ProfileCity",
                columns: new[] { "CityCountryIsoCode", "CityPostalCode" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileCity");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Residences",
                type: "int",
                nullable: true);

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
                name: "IX_Residences_ProfileId",
                table: "Residences",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_Profiles_ProfileId",
                table: "Residences",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }
    }
}
