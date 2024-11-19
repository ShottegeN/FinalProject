using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductPromotionalPricePropertyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01015047-5020-4096-86b9-061a6f78bcf4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("059e6e78-ec4d-48e5-a119-aada77638168"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a92950e-5347-4909-9991-09c2b8a103ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d410e1d-8cf9-4387-8de8-5916535091b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("221bfe2e-3002-465d-ac25-825a612f6717"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a147443-fe06-4a40-9b5f-c9230a1bd788"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("533f604d-18d5-41b3-ac2d-64d882d44964"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54ff5a9b-da5f-49e9-aec0-fd5b4a623395"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e34bd01-6a6c-4cbe-a4e9-b71867e671de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fab4e77-6a70-42d9-86e6-9ad22e1be98c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a921302-0a8d-4f5c-bbe5-9708d4c9bc29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("975611f7-32ca-4fe4-b1a5-fef7c344b2a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99d8e87b-cd5b-44ff-a9ed-cf399f2ab647"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b201184d-0170-4f92-8a39-44e4f606d285"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c08fe036-c6e6-4861-b655-869bac40cbce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7d347e1-6e35-4ce4-85a2-961ea318f6c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2c8860e-233c-4d9f-8922-a87037a812f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8be7df3-4ae8-46a8-8aa9-f39703b6f094"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbdd92a1-0475-46b1-bc83-c03993bc3888"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e384c116-5e52-4e02-b581-64d11aba4480"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0a02caa-2f3e-479d-bf8b-62ce48a53641"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("feda7057-5e19-48f0-9e84-ad265e5ddf6e"));

            migrationBuilder.AddColumn<decimal>(
                name: "PromotionalPrice",
                table: "Products",
                type: "money",
                nullable: true,
                comment: "Price of the product after discount");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "PromotionalPrice", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("021da2c5-4692-4d0d-a76c-230c7d7dfdd3"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3315), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("09772000-4231-450d-bf40-87203702bc1c"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3345), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("0ca77396-d020-4d16-90ed-81941a1688f8"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3071), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("1f25fccb-763e-4dda-96be-b7731d71fbda"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3218), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("2617b451-602d-4e00-8684-393568b208bd"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3033), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("26a62d68-acca-4992-960a-4909e7cca16a"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2647), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("3c41c8e7-f481-48c5-896f-776a556707a1"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2694), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("637e5be7-bc8d-4eaf-ae16-86428395c982"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2996), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("75f85ef0-093a-48ad-8130-a4a081567bb6"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3407), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("7aee07ab-61ac-41dc-aa5e-9ea723a3c81e"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2858), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("80f20517-73c0-47c4-a74b-d934952e138d"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3144), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("93a0188c-3eca-4b33-a0b4-f97e6e7109aa"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3376), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("9f9fc558-b7ae-4feb-a7d4-f732cf5efe96"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2769), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("ab9ddb1e-1fb3-458c-a85d-c425e1941203"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3184), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("bb0a756a-b88c-4497-8e5c-12b08cf8c1c7"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2960), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("bfa4e5ad-9c6f-46a1-aec2-bf30d456c343"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2447), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("c0a840da-09a6-4e9e-8dc6-0fa264d5e4eb"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3279), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("c8a8e188-9b3d-459d-8704-ed8797fc8ce5"), 11, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2814), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("cd811af1-4244-4181-a15c-47edda35a9c3"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3437), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("cf2fc4e2-73ca-4ef6-8e31-466c1c7ebbe9"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(3103), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("d9ce804f-a339-491f-8b93-12d2d9670120"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2734), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("df3b0fd7-01a3-462a-ba35-bdc0b3013277"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, null, 5, new DateTime(2024, 11, 19, 19, 22, 42, 768, DateTimeKind.Local).AddTicks(2895), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("021da2c5-4692-4d0d-a76c-230c7d7dfdd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09772000-4231-450d-bf40-87203702bc1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ca77396-d020-4d16-90ed-81941a1688f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f25fccb-763e-4dda-96be-b7731d71fbda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2617b451-602d-4e00-8684-393568b208bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26a62d68-acca-4992-960a-4909e7cca16a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c41c8e7-f481-48c5-896f-776a556707a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("637e5be7-bc8d-4eaf-ae16-86428395c982"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75f85ef0-093a-48ad-8130-a4a081567bb6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aee07ab-61ac-41dc-aa5e-9ea723a3c81e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80f20517-73c0-47c4-a74b-d934952e138d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93a0188c-3eca-4b33-a0b4-f97e6e7109aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f9fc558-b7ae-4feb-a7d4-f732cf5efe96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab9ddb1e-1fb3-458c-a85d-c425e1941203"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb0a756a-b88c-4497-8e5c-12b08cf8c1c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfa4e5ad-9c6f-46a1-aec2-bf30d456c343"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a840da-09a6-4e9e-8dc6-0fa264d5e4eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8a8e188-9b3d-459d-8704-ed8797fc8ce5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd811af1-4244-4181-a15c-47edda35a9c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf2fc4e2-73ca-4ef6-8e31-466c1c7ebbe9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9ce804f-a339-491f-8b93-12d2d9670120"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df3b0fd7-01a3-462a-ba35-bdc0b3013277"));

            migrationBuilder.DropColumn(
                name: "PromotionalPrice",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("01015047-5020-4096-86b9-061a6f78bcf4"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(3854), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("059e6e78-ec4d-48e5-a119-aada77638168"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4064), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("0a92950e-5347-4909-9991-09c2b8a103ef"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4387), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("0d410e1d-8cf9-4387-8de8-5916535091b4"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4480), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("221bfe2e-3002-465d-ac25-825a612f6717"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4124), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("4a147443-fe06-4a40-9b5f-c9230a1bd788"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4582), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("533f604d-18d5-41b3-ac2d-64d882d44964"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4195), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("54ff5a9b-da5f-49e9-aec0-fd5b4a623395"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4633), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("7e34bd01-6a6c-4cbe-a4e9-b71867e671de"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4529), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("7fab4e77-6a70-42d9-86e6-9ad22e1be98c"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4557), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("8a921302-0a8d-4f5c-bbe5-9708d4c9bc29"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4362), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("975611f7-32ca-4fe4-b1a5-fef7c344b2a0"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4657), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("99d8e87b-cd5b-44ff-a9ed-cf399f2ab647"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4452), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("b201184d-0170-4f92-8a39-44e4f606d285"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4333), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("c08fe036-c6e6-4861-b655-869bac40cbce"), 11, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4158), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("c7d347e1-6e35-4ce4-85a2-961ea318f6c4"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4420), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("d2c8860e-233c-4d9f-8922-a87037a812f5"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4302), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("d8be7df3-4ae8-46a8-8aa9-f39703b6f094"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4096), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("dbdd92a1-0475-46b1-bc83-c03993bc3888"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4608), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("e384c116-5e52-4e02-b581-64d11aba4480"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4028), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("f0a02caa-2f3e-479d-bf8b-62ce48a53641"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4273), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("feda7057-5e19-48f0-9e84-ad265e5ddf6e"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 19, 2, 42, 17, 858, DateTimeKind.Local).AddTicks(4223), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" }
                });
        }
    }
}
