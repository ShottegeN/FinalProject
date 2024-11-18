using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class PromotionsDatasetChanges2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("4440bef2-9cfb-46ca-bbf6-43ca48e015b2"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, new DateTime(2024, 11, 18, 15, 9, 52, 336, DateTimeKind.Local).AddTicks(2799), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("4b479c27-a8ec-4f0b-830d-af142315f774"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 18, 15, 9, 52, 336, DateTimeKind.Local).AddTicks(3022), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("7a568f58-0015-415c-b3c1-68db05fd9a11"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 18, 15, 9, 52, 336, DateTimeKind.Local).AddTicks(2957), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("8a7db35b-bfcc-4473-bd93-c4091660702b"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 18, 15, 9, 52, 336, DateTimeKind.Local).AddTicks(2993), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." },
                    { new Guid("cc766d02-ca9f-4e45-96b0-7fd26c8afad6"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 18, 15, 9, 52, 336, DateTimeKind.Local).AddTicks(3047), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." }
                });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountPercentage", "EndDate", "StartDate" },
                values: new object[] { 20, new DateTime(2024, 2, 29, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 30, new DateTime(2025, 5, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Пролетна Разпродажба", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 20, new DateTime(2025, 8, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Лятна Разпродажба", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 30, new DateTime(2025, 11, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Есенна Разпродажба", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 10, new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Разпродажба 2024", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4440bef2-9cfb-46ca-bbf6-43ca48e015b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b479c27-a8ec-4f0b-830d-af142315f774"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a568f58-0015-415c-b3c1-68db05fd9a11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a7db35b-bfcc-4473-bd93-c4091660702b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc766d02-ca9f-4e45-96b0-7fd26c8afad6"));

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
                columns: new[] { "DiscountPercentage", "EndDate", "StartDate" },
                values: new object[] { 25, new DateTime(2025, 2, 28, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 50, new DateTime(2024, 11, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Черна Петък Оферти", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 30, new DateTime(2025, 3, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Пролетна Разпродажба", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 40, new DateTime(2025, 6, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Лятна Разпродажба", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[] { 20, new DateTime(2025, 9, 15, 23, 59, 59, 0, DateTimeKind.Unspecified), "Обратно в Училище", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "ImageUrl", "Name", "StartDate" },
                values: new object[] { 6, 20, new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), null, "Разпродажба 2024", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
