using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class PromotionsDatasetChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02cd12f5-a4b7-49fd-b40a-8b978596d3f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05e71f9c-1e1d-4e1a-af81-809029feb27d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17bf6387-bed7-4178-8ca5-a37148e095f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f67d6fb6-747a-40aa-9c2e-96651167304f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff7e6443-21d0-45dc-ac71-9430ac7f292c"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("1aaf33ee-9480-49a9-b220-2bb7ee50ef0d"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 18, 15, 4, 7, 299, DateTimeKind.Local).AddTicks(3904), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("71bca37c-065b-487a-ae7f-29a0f8941851"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 18, 15, 4, 7, 299, DateTimeKind.Local).AddTicks(3949), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." },
                    { new Guid("727f2a9a-7f24-4496-bb0f-1d0cbc29df7e"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 18, 15, 4, 7, 299, DateTimeKind.Local).AddTicks(4017), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("c67cdf1a-d030-409c-b1f3-e74557607ef9"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, new DateTime(2024, 11, 18, 15, 4, 7, 299, DateTimeKind.Local).AddTicks(3720), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("e273dde8-526c-48b3-a0e3-b092b5b19cfe"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 18, 15, 4, 7, 299, DateTimeKind.Local).AddTicks(3986), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." }
                });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 59, 59, 0, DateTimeKind.Unspecified), "Зимна Разпродажба", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Черна Петък Оферти");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Пролетна Разпродажба");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Лятна Разпродажба");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Обратно в Училище");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Разпродажба 2024", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1aaf33ee-9480-49a9-b220-2bb7ee50ef0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71bca37c-065b-487a-ae7f-29a0f8941851"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("727f2a9a-7f24-4496-bb0f-1d0cbc29df7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67cdf1a-d030-409c-b1f3-e74557607ef9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e273dde8-526c-48b3-a0e3-b092b5b19cfe"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("02cd12f5-a4b7-49fd-b40a-8b978596d3f9"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 17, 0, 24, 54, 690, DateTimeKind.Local).AddTicks(1159), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("05e71f9c-1e1d-4e1a-af81-809029feb27d"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 17, 0, 24, 54, 690, DateTimeKind.Local).AddTicks(1276), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("17bf6387-bed7-4178-8ca5-a37148e095f2"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, new DateTime(2024, 11, 17, 0, 24, 54, 690, DateTimeKind.Local).AddTicks(1042), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("f67d6fb6-747a-40aa-9c2e-96651167304f"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 17, 0, 24, 54, 690, DateTimeKind.Local).AddTicks(1250), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("ff7e6443-21d0-45dc-ac71-9430ac7f292c"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 17, 0, 24, 54, 690, DateTimeKind.Local).AddTicks(1194), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." }
                });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Winter Sale", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Black Friday Deal");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Spring Clearance");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Summer Blowout");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Back to School");

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 15, 23, 59, 59, 0, DateTimeKind.Unspecified), "Active Promotion", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
