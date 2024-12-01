using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovingUnusedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartProduct");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c12fc00-df6e-41ed-9b09-3c7edc60b4f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cd026e4-eefd-4814-b942-ff56643b978c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e9ac37d-868b-4678-822b-09208cef9bbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30bb87ec-e0ed-4b8f-b3fa-390cc18eef95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33bbf385-a036-43a3-ad9b-19fc56824a50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46740eac-7fb3-44e5-942e-2abbeb14569a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64e7b154-6ae8-4e67-b954-58694268425a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a41bb23-3dd7-48b8-b93f-6778380bb13b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7de1d228-beb8-42c8-a797-aa32be8c4ffa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e64fc60-a0f3-48f2-b769-43b341cfb081"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae09aec2-a64d-4493-9ab2-7a23f306fdee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1b8143f-87f8-4f15-9ce4-ad5f00b8c8fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8614b8a-c49a-4585-b3dd-169685ef30d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf9b9fc7-a2e9-4941-b695-66f379dbf207"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d360382d-077c-4a9c-a3b6-eaab7f9609a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddc90248-9137-45bc-8ed5-7e3ced3a59b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dea5aba8-92e4-4f38-ace3-ecaa01401c2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7721d68-8bb8-4f8a-a80b-7e7b8335db38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eab2a4ca-0457-4c85-b2e2-9970f031f137"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7bc6920-86ff-41d2-a312-38f3cf914889"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8f4ff91-1020-41f1-bf99-d7466c5f6636"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbbd85f-259f-45a2-8a73-27663153320c"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("068855f5-f4fa-4989-a693-a2eae8daa2e7"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5306), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("11568a80-d6d2-4c1f-85be-65ed44d64368"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4904), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("1b59fc28-3801-440f-a258-eaf2d7717ede"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4771), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("1f09c996-9728-4f4b-958a-26f9d7f7c2e3"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5167), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("294583f4-a3eb-4806-8a6d-387b248e1896"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4862), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("2e4cec86-1cec-4e81-bef2-5c695c4f4ce7"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4593), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("31531462-67c7-456a-8c6f-961ce7378dea"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5281), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("4428873b-ec06-4a1b-8074-ec9632ab8e01"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4932), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("47c32443-7d7d-486c-83df-cc96b14981e5"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5330), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("4a61c82d-4a8c-47c6-b90d-473e9e6d6331"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5354), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("4e85d724-8073-46aa-a095-4d96120c1a31"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5252), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("60d59ade-a2b0-4fa4-8c89-8c96169e3b80"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5048), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("6b68d7a0-ff62-4d37-93cb-46e4cc7b3ac7"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4991), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("7637e255-566c-499e-b7fd-8ef5e82af269"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5019), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("90b51dc7-08a3-44c9-9fc2-52ba5a12c72d"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4828), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("a73287c7-7ba0-43cb-a2c4-22bd0fc08cbb"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5134), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("b10391cf-4edc-4b5e-aa6a-26b7f536c43f"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4737), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("c30a53da-0513-4f2e-afa0-856be4b83872"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5101), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("c6658d1a-3260-4212-8c20-81e2795e795d"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5378), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("c8a265be-dde0-4b3a-8ee6-9cd1f41a5c12"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(4802), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("e52c0fa0-9d84-4abd-8711-22f1741ccb8b"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5076), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("f59517b2-9884-4f15-9897-19d49c9b14f4"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 12, 1, 13, 4, 12, 846, DateTimeKind.Local).AddTicks(5194), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("068855f5-f4fa-4989-a693-a2eae8daa2e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11568a80-d6d2-4c1f-85be-65ed44d64368"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b59fc28-3801-440f-a258-eaf2d7717ede"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f09c996-9728-4f4b-958a-26f9d7f7c2e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("294583f4-a3eb-4806-8a6d-387b248e1896"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e4cec86-1cec-4e81-bef2-5c695c4f4ce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31531462-67c7-456a-8c6f-961ce7378dea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4428873b-ec06-4a1b-8074-ec9632ab8e01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47c32443-7d7d-486c-83df-cc96b14981e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a61c82d-4a8c-47c6-b90d-473e9e6d6331"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e85d724-8073-46aa-a095-4d96120c1a31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60d59ade-a2b0-4fa4-8c89-8c96169e3b80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b68d7a0-ff62-4d37-93cb-46e4cc7b3ac7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7637e255-566c-499e-b7fd-8ef5e82af269"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90b51dc7-08a3-44c9-9fc2-52ba5a12c72d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a73287c7-7ba0-43cb-a2c4-22bd0fc08cbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b10391cf-4edc-4b5e-aa6a-26b7f536c43f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c30a53da-0513-4f2e-afa0-856be4b83872"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6658d1a-3260-4212-8c20-81e2795e795d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8a265be-dde0-4b3a-8ee6-9cd1f41a5c12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e52c0fa0-9d84-4abd-8711-22f1741ccb8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f59517b2-9884-4f15-9897-19d49c9b14f4"));

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary Key for the ShoppingCart entity"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the User who owns the shopping cart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartProduct",
                columns: table => new
                {
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the ShoppingCart"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Product in the shopping cart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartProduct", x => new { x.ShoppingCartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ShoppingCartProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartProduct_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("1c12fc00-df6e-41ed-9b09-3c7edc60b4f0"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3070), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("1cd026e4-eefd-4814-b942-ff56643b978c"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(2766), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("1e9ac37d-868b-4678-822b-09208cef9bbe"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3491), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("30bb87ec-e0ed-4b8f-b3fa-390cc18eef95"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3165), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("33bbf385-a036-43a3-ad9b-19fc56824a50"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(2932), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("46740eac-7fb3-44e5-942e-2abbeb14569a"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3027), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("64e7b154-6ae8-4e67-b954-58694268425a"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3230), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("7a41bb23-3dd7-48b8-b93f-6778380bb13b"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3314), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("7de1d228-beb8-42c8-a797-aa32be8c4ffa"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3260), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("7e64fc60-a0f3-48f2-b769-43b341cfb081"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3289), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("ae09aec2-a64d-4493-9ab2-7a23f306fdee"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3106), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("c1b8143f-87f8-4f15-9ce4-ad5f00b8c8fc"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3000), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("c8614b8a-c49a-4585-b3dd-169685ef30d7"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3135), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("cf9b9fc7-a2e9-4941-b695-66f379dbf207"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3566), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("d360382d-077c-4a9c-a3b6-eaab7f9609a9"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3542), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("ddc90248-9137-45bc-8ed5-7e3ced3a59b1"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3348), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("dea5aba8-92e4-4f38-ace3-ecaa01401c2d"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3435), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("e7721d68-8bb8-4f8a-a80b-7e7b8335db38"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3409), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("eab2a4ca-0457-4c85-b2e2-9970f031f137"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(2968), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("f7bc6920-86ff-41d2-a312-38f3cf914889"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3518), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("f8f4ff91-1020-41f1-bf99-d7466c5f6636"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3591), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("ffbbd85f-259f-45a2-8a73-27663153320c"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 11, 30, 17, 12, 13, 686, DateTimeKind.Local).AddTicks(3381), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartProduct_ProductId",
                table: "ShoppingCartProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");
        }
    }
}
