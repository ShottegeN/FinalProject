using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReturningOrderProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("086c8670-966b-4ac8-9229-970e29d26fd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ffaae73-76d7-406b-8ed7-9c0514438ae0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("384b1b6e-9fef-4407-922c-61e5c2bb70f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c3276d7-da3b-4c79-9ec1-4526e2272ce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e462926-e7a5-4584-b8cf-babd44e73da6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55b3a26c-9556-471d-8f00-5226a056e348"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ee4d9b4-12d1-43ae-9403-ead564bd4ddd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("795cfa00-b249-4bbf-89bb-5671c62b1c27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b583ead-7349-4647-88f9-6c8038ba6cdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ee9d285-6361-45a5-8578-87a666296d74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("829f8080-edc0-4f6c-aa39-c41000b1d9b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8302879a-7f41-4476-a4a4-9e0ac12b61df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89b3fc61-a512-42a3-84f4-e499b96fdf01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c8ddc27-0e97-4e1b-84e1-16cb548d7dd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("973f4c04-51fe-4334-b087-10fdc8a5cc34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6150165-06d9-4d27-9ad6-0548972cb1e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba43f03b-4e21-4c6b-89aa-3c558c2a81bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c311cc59-6b20-4317-aadd-28913739220e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1471e72-dff8-4eab-9856-c2f66b4daedd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dff26435-7fd9-462b-8e00-f80eb7f372cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed9667e8-65ec-4747-b06c-a21145a1b911"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f844ba35-7646-42fe-9b36-e124fe793410"));

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Order"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Product in the order"),
                    BoughtQuantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the bought products of same type")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_AspNetUsers_OrderId",
                        column: x => x.OrderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

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
                    { new Guid("086c8670-966b-4ac8-9229-970e29d26fd1"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", null, 35m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8494), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("2ffaae73-76d7-406b-8ed7-9c0514438ae0"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", null, 35m, 1, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8054), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("384b1b6e-9fef-4407-922c-61e5c2bb70f5"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", null, 20m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8832), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("4c3276d7-da3b-4c79-9ec1-4526e2272ce7"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", null, 25m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8237), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("4e462926-e7a5-4584-b8cf-babd44e73da6"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", null, 30m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8756), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("55b3a26c-9556-471d-8f00-5226a056e348"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", null, 15m, 5, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8644), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("6ee4d9b4-12d1-43ae-9403-ead564bd4ddd"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", null, 40m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8781), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("795cfa00-b249-4bbf-89bb-5671c62b1c27"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", null, 55m, 1, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8170), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("7b583ead-7349-4647-88f9-6c8038ba6cdf"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", null, 35m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8270), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("7ee9d285-6361-45a5-8578-87a666296d74"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", null, 25m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8551), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("829f8080-edc0-4f6c-aa39-c41000b1d9b2"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", null, 45m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8205), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("8302879a-7f41-4476-a4a4-9e0ac12b61df"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", null, 15m, 5, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8616), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("89b3fc61-a512-42a3-84f4-e499b96fdf01"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", null, 30m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8370), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("8c8ddc27-0e97-4e1b-84e1-16cb548d7dd5"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", null, 30m, 1, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8306), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("973f4c04-51fe-4334-b087-10fdc8a5cc34"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", null, 15m, 5, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8584), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("a6150165-06d9-4d27-9ad6-0548972cb1e9"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", null, 45m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8400), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("ba43f03b-4e21-4c6b-89aa-3c558c2a81bd"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", null, 25m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8730), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("c311cc59-6b20-4317-aadd-28913739220e"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", null, 25m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8671), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("d1471e72-dff8-4eab-9856-c2f66b4daedd"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", null, 20m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8523), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("dff26435-7fd9-462b-8e00-f80eb7f372cb"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", null, 40m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8464), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("ed9667e8-65ec-4747-b06c-a21145a1b911"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", null, 50m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8341), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("f844ba35-7646-42fe-9b36-e124fe793410"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", null, 40m, null, 5, new DateTime(2024, 12, 4, 13, 4, 35, 980, DateTimeKind.Local).AddTicks(8807), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." }
                });
        }
    }
}
