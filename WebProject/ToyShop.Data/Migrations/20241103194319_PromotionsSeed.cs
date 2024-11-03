using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class PromotionsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Winter Sale", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 50, new DateTime(2024, 11, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Black Friday Deal", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 30, new DateTime(2025, 3, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Spring Clearance", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 40, new DateTime(2025, 6, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Summer Blowout", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 20, new DateTime(2025, 9, 15, 23, 59, 59, 0, DateTimeKind.Unspecified), "Back to School", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
