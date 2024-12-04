using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovingOrderProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03faf0f2-f978-4fb8-b3ec-3db86dd6713f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0874d87b-ae98-44ea-871b-aeeb485e2e74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("097d96d2-e4d9-493b-b715-798c94e5e396"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ec15b6c-559e-4477-bcab-4c1ce17ea929"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("277af018-960e-4093-8ff5-f1c585be0bdb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a6900b9-69bc-4638-93b2-74bc9726db39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57476ca5-d3a4-4609-91e8-ab5544dbe464"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68f356e5-5069-48f6-a951-cc82be609be7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c58768b-5bbc-4614-8844-4bdb0354dbec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d862165-5e4a-4ae5-bff2-4beb702b0379"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6df4145d-5f44-4506-9e21-f4a5ab815bb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7010fcc6-650a-424c-bc0f-cfd0ede26431"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b644f53-4f24-443c-8113-7c6c33eed9e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d4c5f51-394a-4235-823f-06ecd771e7cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93a47811-f21c-4826-996f-6808c57074b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a173a531-a6ac-416a-8567-0310fcaf6ab8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5221b19-ea6c-4d1e-a469-5cd8dc5bc2f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae25953b-db98-4e24-8ba3-fa3978fe1596"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb0bcdb8-ec21-4199-bf43-d4a12f28a835"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d453cb76-3e1e-4b23-922c-44169d3b3421"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d744588a-51f1-45f9-a12a-79faeaa203f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9d6f337-d45d-45c7-806c-abcdb7f16701"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Order entity"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Product entity"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the product in the order")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
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
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("03faf0f2-f978-4fb8-b3ec-3db86dd6713f"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3739), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("0874d87b-ae98-44ea-871b-aeeb485e2e74"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3798), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("097d96d2-e4d9-493b-b715-798c94e5e396"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3607), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("0ec15b6c-559e-4477-bcab-4c1ce17ea929"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(4065), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("277af018-960e-4093-8ff5-f1c585be0bdb"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3681), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("2a6900b9-69bc-4638-93b2-74bc9726db39"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3948), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("57476ca5-d3a4-4609-91e8-ab5544dbe464"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3972), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("68f356e5-5069-48f6-a951-cc82be609be7"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3474), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("6c58768b-5bbc-4614-8844-4bdb0354dbec"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3710), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("6d862165-5e4a-4ae5-bff2-4beb702b0379"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3653), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("6df4145d-5f44-4506-9e21-f4a5ab815bb1"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3410), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("7010fcc6-650a-424c-bc0f-cfd0ede26431"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3545), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("7b644f53-4f24-443c-8113-7c6c33eed9e2"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3293), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("8d4c5f51-394a-4235-823f-06ecd771e7cc"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3857), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("93a47811-f21c-4826-996f-6808c57074b3"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3579), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("a173a531-a6ac-416a-8567-0310fcaf6ab8"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3924), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("a5221b19-ea6c-4d1e-a469-5cd8dc5bc2f6"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3895), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("ae25953b-db98-4e24-8ba3-fa3978fe1596"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3830), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("bb0bcdb8-ec21-4199-bf43-d4a12f28a835"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3510), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("d453cb76-3e1e-4b23-922c-44169d3b3421"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3444), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("d744588a-51f1-45f9-a12a-79faeaa203f6"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(4041), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("f9d6f337-d45d-45c7-806c-abcdb7f16701"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 12, 1, 14, 42, 48, 563, DateTimeKind.Local).AddTicks(3766), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");
        }
    }
}
