using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovingUnusedEntities2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CouponId",
                table: "Orders");

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

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "UserProductShoppingCart",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the User who owns the wishlist"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Product in the wishlist")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProductShoppingCart", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UserProductShoppingCart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProductShoppingCart_Products_ProductId",
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
                    { new Guid("1dac81d9-e90a-4ac5-87ee-0df05a63e84b"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2500), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("250af7f9-0276-42b4-9730-7c4dfba4e5c9"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3140), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("3d7c0f15-fc3f-4f54-96bd-a13e475b625c"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2758), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("3f274a6d-14d7-46c0-b07e-c238d70516aa"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3274), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("6cf23237-d8fb-4bad-95f2-5e02746c7bf1"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2708), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("6f1e5261-422e-490c-b6d9-f117b9132a9b"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3103), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("717c4b5e-b2cb-4be3-9f4f-a98009ddde10"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2620), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("7553bf24-9b59-4ac0-92b2-2dcc3d725eb1"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3243), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("934cc5ba-ad1f-468e-a5d6-dd0624199d99"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3335), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("9b3867fa-5f88-42cc-bdf5-3dec27293102"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2576), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("a0af023b-15d2-447d-8157-91891c95ab59"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2541), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("a5add1b6-bb44-43eb-9a06-dcbf45261ef9"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2672), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("af5fd6e7-6954-4985-9231-d0f6dd2878bd"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2951), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("b1491eb7-eb71-441a-9321-a5705d095da8"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2999), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("bc2f6788-949a-46b0-b2bc-60e6f8167dc1"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2245), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("c0408c9c-fd91-404d-9d05-74b91be389d6"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3211), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("ca072a20-5835-4286-ab0e-b082dc42f09e"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3305), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("cf6561c7-da55-4763-950b-e8cca8635aed"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2852), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("d0dbbc7f-09f6-4dd4-a8ca-e79b36846ee0"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2794), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("d7bb1111-1c49-4640-bdc8-47c9386ff88d"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2455), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("f367b2f7-489d-4cbd-bc1a-93028ffac1d5"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(3175), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("fd3ac7cc-1f49-49ed-a198-3b715861b745"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 12, 1, 13, 9, 45, 703, DateTimeKind.Local).AddTicks(2909), "Малко, симпатично авокадо.", "Височината е около 15см" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProductShoppingCart_ProductId",
                table: "UserProductShoppingCart",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProductShoppingCart");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dac81d9-e90a-4ac5-87ee-0df05a63e84b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("250af7f9-0276-42b4-9730-7c4dfba4e5c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d7c0f15-fc3f-4f54-96bd-a13e475b625c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f274a6d-14d7-46c0-b07e-c238d70516aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cf23237-d8fb-4bad-95f2-5e02746c7bf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f1e5261-422e-490c-b6d9-f117b9132a9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("717c4b5e-b2cb-4be3-9f4f-a98009ddde10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7553bf24-9b59-4ac0-92b2-2dcc3d725eb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("934cc5ba-ad1f-468e-a5d6-dd0624199d99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b3867fa-5f88-42cc-bdf5-3dec27293102"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0af023b-15d2-447d-8157-91891c95ab59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5add1b6-bb44-43eb-9a06-dcbf45261ef9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af5fd6e7-6954-4985-9231-d0f6dd2878bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1491eb7-eb71-441a-9321-a5705d095da8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc2f6788-949a-46b0-b2bc-60e6f8167dc1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0408c9c-fd91-404d-9d05-74b91be389d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca072a20-5835-4286-ab0e-b082dc42f09e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf6561c7-da55-4763-950b-e8cca8635aed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0dbbc7f-09f6-4dd4-a8ca-e79b36846ee0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7bb1111-1c49-4640-bdc8-47c9386ff88d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f367b2f7-489d-4cbd-bc1a-93028ffac1d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd3ac7cc-1f49-49ed-a198-3b715861b745"));

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Orders",
                type: "int",
                nullable: true,
                comment: "Optional foreign Key reference to the Coupon entity");

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the Coupon entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Unique code for the coupon with a maximum length constraint"),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: true, comment: "Optional discount percentage for the coupon"),
                    DiscountValue = table.Column<decimal>(type: "money", nullable: true, comment: "Optional discount value for the coupon in monetary terms"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "Indicates if the coupon is currently active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "DiscountPercentage", "DiscountValue" },
                values: new object[,]
                {
                    { 1, "XJ7K2H", 10, null },
                    { 2, "YF8L3R", 0, 5m },
                    { 3, "ZQ4M1T", 20, null },
                    { 4, "PR9D7J", null, 10m },
                    { 5, "BX3W5F", 50, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
