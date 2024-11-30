using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductDescriptionsConstraintChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01354203-9dfe-4052-bcdc-894a0b6223fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18b2ef65-c03c-4cb1-8ee8-87379e0dba90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1fbb660d-8fab-4baf-8634-5d036dd8eaac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21b1f0bb-2389-42c6-aee0-2958470c83a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29cb31fa-0e81-4138-a6d5-268c0743c507"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30fb63eb-b0ba-4c0a-bdbb-d6699bf68ead"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b5e7b10-06dc-4a0d-8893-b87186461b98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44cc6a92-c92c-4380-a463-2c21e282a5a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48a4ae8d-4beb-42ab-a7b1-56c5aada8f9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6473c952-630a-4b73-badd-f012172c066d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("704a005d-9133-433f-904d-e5c7245beaba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e0f3143-2cd1-4340-810e-60a5f7723d5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("952fcef8-b81b-4307-9450-9f3979f4ad61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99bee65a-a7e3-42cd-8c82-888dc384f7b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3aa852c-ed16-4da0-a86e-af27fa094462"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b182715b-40bd-44a7-b1fe-c30ae55e6cb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf192eb7-7e5c-4ca7-9aa1-4bed0663a9c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c080fee1-ba3c-4bb6-8df3-3b923346482f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfe4b4dc-41a9-431c-9b7a-5ee2dd33782a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4823ca1-4a44-4718-b3f0-9674ed059e3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6859ee5-e8a5-4f3e-8d1b-e61ac82245ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7cc1b77-695c-49ab-a1a8-7dd0d5c20502"));

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Short description of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Short description of the product with a maximum length constraint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                comment: "Optional detailed description of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Optional detailed description of the product with a maximum length constraint");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("06d43877-fb72-438d-83be-6544d94f535c"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(1157), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("1243e861-849f-4b24-b04f-5f9956276e26"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(406), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("13797bbb-557b-406d-87bc-9ecf92d2bb39"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(820), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("14f86863-ddbb-4617-8f10-892decaa90fe"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(609), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("15aded44-0a21-4c03-890a-0f80e9d4420b"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(573), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("1d3078ec-e903-43d3-af99-66885da26764"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(181), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("2249dbbc-1d32-4c35-9167-fe3ab044a729"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(446), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("4015848a-8006-427c-82b8-a34bcfb69bda"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(1067), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("419250a6-1fb7-482f-81cc-c04397e6ee5c"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(482), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("565a98e0-8f53-4cf5-96ca-1ea74b8ec1f9"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(751), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("5a389d4f-6836-4642-841e-40287d0b5987"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(788), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("6c437b2c-c5fe-4abb-8b9f-64bb3da79494"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(938), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("761fdba9-9747-488c-b4c4-78428e99e817"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(904), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("88191ecb-af1c-4f82-ab1d-9b83234772ac"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(528), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("8df1f240-e75d-4c8b-81cc-2d6613243acf"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(1036), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("8fa51517-ad73-4bdd-8c32-bc6bd4b01bdf"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(362), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("936b5b87-46bd-4b86-b3bd-903094a2ab76"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(713), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("ad0fd972-6e27-4041-9711-a8208274e60f"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(1127), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("b98f0853-d52b-490a-a567-5b44c036e274"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(1097), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("d235d6e6-2c6e-4904-99ab-0a1fb02c1c4f"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(677), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("e58a296b-ad3c-4396-a68a-f443905eaaec"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(997), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("e8897b30-d7fb-4590-b396-efdf86c10850"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 11, 30, 17, 7, 26, 636, DateTimeKind.Local).AddTicks(862), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06d43877-fb72-438d-83be-6544d94f535c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1243e861-849f-4b24-b04f-5f9956276e26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13797bbb-557b-406d-87bc-9ecf92d2bb39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14f86863-ddbb-4617-8f10-892decaa90fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15aded44-0a21-4c03-890a-0f80e9d4420b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d3078ec-e903-43d3-af99-66885da26764"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2249dbbc-1d32-4c35-9167-fe3ab044a729"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4015848a-8006-427c-82b8-a34bcfb69bda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("419250a6-1fb7-482f-81cc-c04397e6ee5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("565a98e0-8f53-4cf5-96ca-1ea74b8ec1f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a389d4f-6836-4642-841e-40287d0b5987"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c437b2c-c5fe-4abb-8b9f-64bb3da79494"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("761fdba9-9747-488c-b4c4-78428e99e817"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88191ecb-af1c-4f82-ab1d-9b83234772ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8df1f240-e75d-4c8b-81cc-2d6613243acf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fa51517-ad73-4bdd-8c32-bc6bd4b01bdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("936b5b87-46bd-4b86-b3bd-903094a2ab76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad0fd972-6e27-4041-9711-a8208274e60f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b98f0853-d52b-490a-a567-5b44c036e274"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d235d6e6-2c6e-4904-99ab-0a1fb02c1c4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e58a296b-ad3c-4396-a68a-f443905eaaec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8897b30-d7fb-4590-b396-efdf86c10850"));

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Short description of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Short description of the product with a maximum length constraint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Optional detailed description of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Optional detailed description of the product with a maximum length constraint");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("01354203-9dfe-4052-bcdc-894a0b6223fb"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4439), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("18b2ef65-c03c-4cb1-8ee8-87379e0dba90"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4164), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("1fbb660d-8fab-4baf-8634-5d036dd8eaac"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4493), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("21b1f0bb-2389-42c6-aee0-2958470c83a9"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4408), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("29cb31fa-0e81-4138-a6d5-268c0743c507"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4768), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("30fb63eb-b0ba-4c0a-bdbb-d6699bf68ead"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4557), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("3b5e7b10-06dc-4a0d-8893-b87186461b98"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4222), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("44cc6a92-c92c-4380-a463-2c21e282a5a2"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4525), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("48a4ae8d-4beb-42ab-a7b1-56c5aada8f9c"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4669), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("6473c952-630a-4b73-badd-f012172c066d"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4128), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("704a005d-9133-433f-904d-e5c7245beaba"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4379), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("7e0f3143-2cd1-4340-810e-60a5f7723d5e"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4744), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("952fcef8-b81b-4307-9450-9f3979f4ad61"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4257), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("99bee65a-a7e3-42cd-8c82-888dc384f7b8"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4195), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("a3aa852c-ed16-4da0-a86e-af27fa094462"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4720), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("b182715b-40bd-44a7-b1fe-c30ae55e6cb8"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4293), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("bf192eb7-7e5c-4ca7-9aa1-4bed0663a9c0"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4696), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("c080fee1-ba3c-4bb6-8df3-3b923346482f"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(3973), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("dfe4b4dc-41a9-431c-9b7a-5ee2dd33782a"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4468), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("e4823ca1-4a44-4718-b3f0-9674ed059e3b"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4585), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("e6859ee5-e8a5-4f3e-8d1b-e61ac82245ee"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4321), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("e7cc1b77-695c-49ab-a1a8-7dd0d5c20502"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 26, 20, 57, 30, 691, DateTimeKind.Local).AddTicks(4639), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." }
                });
        }
    }
}
