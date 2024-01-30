using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedsToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4273), "Details", "", "Beach Villa", 10, 20.0, 220, new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4286) },
                    { 2, "", new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4288), "Details", "", "Beach Villa", 10, 20.0, 220, new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4289) },
                    { 3, "", new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4291), "Details", "", "Lake Villa", 10, 20.0, 220, new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4292) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
