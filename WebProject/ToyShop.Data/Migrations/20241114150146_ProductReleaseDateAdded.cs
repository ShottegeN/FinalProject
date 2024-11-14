using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductReleaseDateAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a75e6f-2bf8-48bc-a724-ca77e462761b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69515881-7767-4686-9f6f-f38f1d1ac34e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97f0768d-48b7-4a47-9b45-0f165af9884a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8195de9-f4c4-4575-a8b2-908a99796f21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae4312b3-8fad-430a-b38a-a2f72e50facb"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleasedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "The date when the product was released");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("1efb6aab-960c-4bb6-9a80-4b705fd79ae9"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." },
                    { new Guid("35392ac5-dca5-426d-a89c-52d05c10e97a"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("369acafb-4055-4239-88cb-72a3540f855a"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("6c5496af-7192-4447-bdad-8d18553f7939"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("908157b3-7113-4c12-8de6-d28a9aec255d"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1efb6aab-960c-4bb6-9a80-4b705fd79ae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35392ac5-dca5-426d-a89c-52d05c10e97a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("369acafb-4055-4239-88cb-72a3540f855a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c5496af-7192-4447-bdad-8d18553f7939"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("908157b3-7113-4c12-8de6-d28a9aec255d"));

            migrationBuilder.DropColumn(
                name: "ReleasedOn",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("68a75e6f-2bf8-48bc-a724-ca77e462761b"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("69515881-7767-4686-9f6f-f38f1d1ac34e"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("97f0768d-48b7-4a47-9b45-0f165af9884a"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("a8195de9-f4c4-4575-a8b2-908a99796f21"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("ae4312b3-8fad-430a-b38a-a2f72e50facb"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." }
                });
        }
    }
}
