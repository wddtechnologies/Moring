using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Morning.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7166), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Royal Villa", 4, 200.0, 550, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7222) },
                    { 2, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7225), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Premium Pool Villa", 4, 300.0, 550, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7226) },
                    { 3, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7229), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7230) },
                    { 4, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7233), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Diamond Villa", 4, 550.0, 900, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7234) },
                    { 5, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7237), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7238) }
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

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
