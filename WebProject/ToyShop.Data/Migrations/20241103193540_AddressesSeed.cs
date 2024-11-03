using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddressesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "BuildingNumber", "CityId", "Entrance", "Number", "OtherAddressInformation", "StreetName" },
                values: new object[,]
                {
                    { 1, null, 1, "А", 12, "До НДК", "бул. Витоша" },
                    { 2, 2, 1, null, 45, "Срещу книжарницата", "ул. Цар Иван Асен II" },
                    { 3, 5, 2, "Б", 89, "До аптеката", "бул. Сливница" },
                    { 4, null, 3, "В", 7, "Близо до парка", "ул. Александровска" },
                    { 5, 1, 4, null, 23, "До стадиона", "ул. Сан Стефано" },
                    { 6, null, 2, "Г", 101, "До университета", "ул. Княз Борис I" },
                    { 7, 3, 1, null, 18, "Близо до пазара", "ул. Граф Игнатиев" },
                    { 8, null, 5, "Д", 33, "Срещу банката", "ул. Дунав" },
                    { 9, 4, 3, null, 50, "До търговския център", "бул. Левски" },
                    { 10, null, 4, "Е", 99, "Близо до музея", "ул. Шипка" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
