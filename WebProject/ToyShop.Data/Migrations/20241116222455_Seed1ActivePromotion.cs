using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed1ActivePromotion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16450e25-33a0-4a28-9b03-6d77106f1e75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b16eaa7-ae8e-461d-a9a4-ee1abacbff27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b278a107-530b-441e-ae85-7fb4db442fac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d10b6527-e2a1-4142-a251-56af50597ad0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee8cac5b-ba55-413c-9f5f-d847a4a949db"));

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

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "ImageUrl", "Name", "StartDate" },
                values: new object[] { 6, 20, new DateTime(2025, 9, 15, 23, 59, 59, 0, DateTimeKind.Unspecified), null, "Active Promotion", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("16450e25-33a0-4a28-9b03-6d77106f1e75"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 17, 0, 19, 46, 921, DateTimeKind.Local).AddTicks(2926), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("2b16eaa7-ae8e-461d-a9a4-ee1abacbff27"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 17, 0, 19, 46, 921, DateTimeKind.Local).AddTicks(2961), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." },
                    { new Guid("b278a107-530b-441e-ae85-7fb4db442fac"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, new DateTime(2024, 11, 17, 0, 19, 46, 921, DateTimeKind.Local).AddTicks(2769), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("d10b6527-e2a1-4142-a251-56af50597ad0"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 17, 0, 19, 46, 921, DateTimeKind.Local).AddTicks(3021), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("ee8cac5b-ba55-413c-9f5f-d847a4a949db"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 17, 0, 19, 46, 921, DateTimeKind.Local).AddTicks(2988), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." }
                });
        }
    }
}
