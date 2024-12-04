using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReturningOrderProductEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_AspNetUsers_OrderId",
                table: "OrderProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("050d28d2-3948-4a1b-8e4e-e19e58c989f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("220d6efa-d33f-4c4e-892e-bcb7a25d13c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28f7d062-cb15-4e21-9189-b8640d69b597"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("301f1122-86b5-480e-a064-f276cf339f38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cfb5dc6-d18a-4eda-9fcd-34e8419eb7ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fcd247f-3e28-487d-94c3-2f63d009443b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ffed233-975c-45e0-8dbd-51770d7cb946"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d764d73-65f3-4241-aa3a-72ad09e5bad9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6db8b44d-751e-4530-a657-7eb625a20dab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ad63017-358c-4e9b-84c3-924423d8ba89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8088a97a-3477-45cd-a5af-16c016ec0f42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("858e4a0e-6e11-4eac-97d0-7a0922f76ddb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90e4daa1-57c8-4b72-9a9c-3f50c9175586"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98d30edc-14cb-4e46-a2b6-cec3eb6ef42c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a273e219-31af-44e1-8cf0-f1aa6d6325ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a97217a1-db0b-44ba-8925-b71b15ffded1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab37f620-2080-4b19-8dd1-b35e23d1e407"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be11b76f-671b-42c7-9a98-f667fc0fa004"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7a97071-6228-4e3f-83d2-06d2de24ea17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0d6a6dd-1e49-4038-a763-4277511e6f4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5535bde-01ac-4ea3-a6ec-c216273b462b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fba820e4-e0f5-4183-bc7d-5e124b3bc77a"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "OrderId", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("021029b9-2ae1-408f-a0d5-1358b5392d27"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", null, 40m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7955), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("0aa0a818-cf0f-478a-a0d8-0185b1cfb9fd"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", null, 30m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7461), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("0f56efec-8720-4c01-bd29-51e983c8f9b8"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7893), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("226b27b7-d94e-4f52-a580-8596a64f5c6f"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", null, 15m, 5, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7789), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("336ccfe4-eea2-4249-bbc8-a5ec2ebf3fea"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", null, 30m, 1, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7384), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("403f577b-7550-47cd-8ee0-d69ac27eebbc"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7821), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("4259003b-b8f9-4765-a2fa-6959a274a5a1"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", null, 30m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7925), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("4f431fb8-4161-4c29-bad3-5d6259e18964"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", null, 50m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7427), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("52dc399e-e76c-4bdc-beab-ab1b8adeafdd"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", null, 20m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7642), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("7493187e-e25f-46a1-9a3d-e92b55034ece"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", null, 20m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(8020), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("95e6ab54-41c9-47e1-9a19-9cb3211d03e6"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7300), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("9bbb7a1e-c0c4-4481-a284-c12f0c7ba858"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", null, 15m, 5, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7756), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("a52047c6-57e7-47dd-90ad-80a04caac33b"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", null, 40m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7568), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("b2d6e95a-c86b-4bff-8202-cd7e5346bf15"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", null, 35m, 1, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7044), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("b7183e40-a714-48dd-9d6e-96bb8eb90f85"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", null, 45m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7262), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("c7402c4b-f850-46a4-ac9f-e81b02409259"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", null, 35m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7335), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("cbe6ac8b-60ea-47eb-8b4c-8966d69c61ae"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", null, 55m, 1, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7219), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("cd614410-cd18-4d9a-8744-6dea24c9fd21"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7673), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("f0c71539-5bbd-4f58-9063-751b7ad83d47"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", null, 35m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7605), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("f1555204-93e2-4314-b2d1-fe580ca4d702"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", null, 40m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7987), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("f4a7f02c-e27d-44e8-ba1b-a84c8e040b31"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", null, 45m, null, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7495), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("ff8df46b-2736-4e4f-9bc3-6c4a75cee4d7"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", null, 15m, 5, 5, new DateTime(2024, 12, 4, 14, 23, 11, 12, DateTimeKind.Local).AddTicks(7716), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_OrderId",
                table: "OrderProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("021029b9-2ae1-408f-a0d5-1358b5392d27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aa0a818-cf0f-478a-a0d8-0185b1cfb9fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f56efec-8720-4c01-bd29-51e983c8f9b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("226b27b7-d94e-4f52-a580-8596a64f5c6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("336ccfe4-eea2-4249-bbc8-a5ec2ebf3fea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("403f577b-7550-47cd-8ee0-d69ac27eebbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4259003b-b8f9-4765-a2fa-6959a274a5a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f431fb8-4161-4c29-bad3-5d6259e18964"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52dc399e-e76c-4bdc-beab-ab1b8adeafdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7493187e-e25f-46a1-9a3d-e92b55034ece"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95e6ab54-41c9-47e1-9a19-9cb3211d03e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bbb7a1e-c0c4-4481-a284-c12f0c7ba858"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a52047c6-57e7-47dd-90ad-80a04caac33b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2d6e95a-c86b-4bff-8202-cd7e5346bf15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7183e40-a714-48dd-9d6e-96bb8eb90f85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7402c4b-f850-46a4-ac9f-e81b02409259"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbe6ac8b-60ea-47eb-8b4c-8966d69c61ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd614410-cd18-4d9a-8744-6dea24c9fd21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0c71539-5bbd-4f58-9063-751b7ad83d47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1555204-93e2-4314-b2d1-fe580ca4d702"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4a7f02c-e27d-44e8-ba1b-a84c8e040b31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff8df46b-2736-4e4f-9bc3-6c4a75cee4d7"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "OrderId", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("050d28d2-3948-4a1b-8e4e-e19e58c989f6"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3011), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("220d6efa-d33f-4c4e-892e-bcb7a25d13c3"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", null, 40m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3531), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("28f7d062-cb15-4e21-9189-b8640d69b597"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", null, 45m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(2980), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("301f1122-86b5-480e-a064-f276cf339f38"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", null, 15m, 5, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3338), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("4cfb5dc6-d18a-4eda-9fcd-34e8419eb7ef"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3304), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("5fcd247f-3e28-487d-94c3-2f63d009443b"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", null, 15m, 5, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3370), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("5ffed233-975c-45e0-8dbd-51770d7cb946"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3483), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("6d764d73-65f3-4241-aa3a-72ad09e5bad9"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", null, 45m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3159), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("6db8b44d-751e-4530-a657-7eb625a20dab"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", null, 30m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3132), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("7ad63017-358c-4e9b-84c3-924423d8ba89"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", null, 20m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3280), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("8088a97a-3477-45cd-a5af-16c016ec0f42"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", null, 40m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3222), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("858e4a0e-6e11-4eac-97d0-7a0922f76ddb"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", null, 40m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3555), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("90e4daa1-57c8-4b72-9a9c-3f50c9175586"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", null, 35m, 1, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(2755), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("98d30edc-14cb-4e46-a2b6-cec3eb6ef42c"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", null, 15m, 5, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3398), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("a273e219-31af-44e1-8cf0-f1aa6d6325ac"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", null, 50m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3104), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("a97217a1-db0b-44ba-8925-b71b15ffded1"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", null, 30m, 1, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3070), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("ab37f620-2080-4b19-8dd1-b35e23d1e407"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", null, 55m, 1, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(2946), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("be11b76f-671b-42c7-9a98-f667fc0fa004"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", null, 25m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3424), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("c7a97071-6228-4e3f-83d2-06d2de24ea17"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", null, 35m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3251), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("f0d6a6dd-1e49-4038-a763-4277511e6f4e"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", null, 30m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3508), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("f5535bde-01ac-4ea3-a6ec-c216273b462b"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", null, 20m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3578), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("fba820e4-e0f5-4183-bc7d-5e124b3bc77a"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", null, 35m, null, 5, new DateTime(2024, 12, 4, 14, 22, 22, 21, DateTimeKind.Local).AddTicks(3037), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_AspNetUsers_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
