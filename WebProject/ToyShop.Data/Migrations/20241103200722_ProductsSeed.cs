using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "images/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { 2, 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "images/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { 3, 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "images/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." },
                    { 4, 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "images/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { 5, 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "images/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
