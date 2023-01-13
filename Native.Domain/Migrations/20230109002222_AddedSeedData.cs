using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Native.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Guid", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("fd77dd91-9abb-4b13-9874-e3c434a3e7f1"), "Coffe & chat" },
                    { 2, new Guid("9c24a8d7-4ea9-44e7-ab47-a30c5548343d"), "Walk & talk" },
                    { 3, new Guid("29ffd50b-a6db-4b26-850b-317cafc2b3d5"), "Networking" },
                    { 4, new Guid("536d0abd-597e-4e5b-8f15-472698a32101"), "Cinema" },
                    { 5, new Guid("41c29560-8c83-4896-ad8c-5d8eb56621a8"), "Theatre" },
                    { 6, new Guid("c48b0aba-39d6-4721-9c30-69148b4b4bb6"), "Gigs & concerts" },
                    { 7, new Guid("0d10e2f8-b6a3-4938-bf1f-b431341ec10a"), "Shopping" },
                    { 8, new Guid("fcf72a67-26cf-4ec6-a4fe-98395cd6cba5"), "Bowling" },
                    { 9, new Guid("68240a7c-7871-4915-bb84-8f1eed174121"), "Poker" },
                    { 10, new Guid("0dd213ef-70a2-4870-8e10-61a6e47e6cea"), "Karting" },
                    { 11, new Guid("2ce239ca-74cb-4c88-8ef3-64c9eb16e0e7"), "Pub quiz" },
                    { 12, new Guid("45f37cac-ed46-4f9a-8723-516a80e83fdc"), "Dancing" },
                    { 13, new Guid("121fc651-3836-4a48-bac3-cf07cf6eee66"), "Languages" },
                    { 14, new Guid("915c3957-09e4-4207-ab9d-7f419c69fca2"), "Photography" },
                    { 15, new Guid("3965f136-26a4-4ca0-9f0b-b2b50311207a"), "Baking" },
                    { 16, new Guid("e2177139-9210-47a8-b133-e517e2ca34e3"), "Satrtups & enterpreneurship" },
                    { 17, new Guid("6b706dee-5943-465e-b145-b3483c2a946f"), "Hollistic wellness" },
                    { 18, new Guid("af9444fa-5e90-45c7-8b4e-0daad9efd6bb"), "Nutrition" },
                    { 19, new Guid("627c1207-1200-4686-84e4-43980f215da1"), "Reading" },
                    { 20, new Guid("8068ba84-67d6-4c6d-bb41-d7691c1fd147"), "Writing" },
                    { 21, new Guid("7d1f3cde-564c-41d5-bde2-b8e55903a926"), "Gardening" },
                    { 22, new Guid("3ad52878-f435-4bc8-b28a-092751808599"), "Neighbourhood " },
                    { 23, new Guid("ac26421e-25a2-4dab-ac3f-973abd7ac63c"), "Hiking" },
                    { 24, new Guid("c17cd949-17d4-4d84-9a6d-87f7c5a679d0"), "Picnic" },
                    { 25, new Guid("40f55dda-0458-48ae-9ba1-48eda5dee02a"), "Dog walking" },
                    { 26, new Guid("0b8d7fb4-ae93-43cf-b859-d002a6b0ffc8"), "Outdoor activities" },
                    { 27, new Guid("757d0068-77b0-4b0b-8568-5bd8e9a24d3a"), "Traveling abroad" },
                    { 28, new Guid("22de8aa1-ab67-4a79-a2c9-9758e56c056f"), "Camping" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 28);
        }
    }
}
