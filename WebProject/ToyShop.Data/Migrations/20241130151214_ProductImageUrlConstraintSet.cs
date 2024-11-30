using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductImageUrlConstraintSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                comment: "Url of the product image",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Url of the product image");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Url of the product image",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true,
                oldComment: "Url of the product image");

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
    }
}
