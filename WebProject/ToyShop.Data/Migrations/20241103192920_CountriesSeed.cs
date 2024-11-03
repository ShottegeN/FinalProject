using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CountriesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "Currency", "ISOCode", "IsActive", "Name", "PhoneCode", "Region" },
                values: new object[] { 1, "Европа", "BGN", "BG", true, "България", "+359", "Източна Европа" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
