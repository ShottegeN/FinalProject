using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderTotalPricePropertyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16b2294e-149f-48cb-953d-c302705b3d7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29b6287c-a852-4210-aec2-ab781393837f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4440492c-fe98-4c1e-b304-29947ff97991"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60e7d161-473b-475a-8459-35067a7db0b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71d5c62b-b648-4a11-b7c0-e7e4d59e419d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77b37df2-8b94-4133-81e5-02597a7a9fd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e66c67c-bf3e-442d-b8a6-fa67459512aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8466df5b-1d1d-49ff-bb15-7ef9f9f921e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9202f74b-bcb6-4106-a61a-0a69b063bea8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("937517b1-db0b-4f66-90c0-ed4d844ff089"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dd8ef75-51db-4599-bb2a-40c992233ae6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f18b022-0a7a-476b-9577-397a26525f44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2eb0c4b-aedf-45cc-a322-0fca4d5d7b15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb51d7e5-33f3-4a81-be0a-e8b949919872"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c65680d9-7adb-40da-90b4-c94ed95d6913"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfa39287-b4fc-4d44-9db5-63d549493584"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1ae1d43-a16e-4f9e-88b7-07ae7e732044"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5667616-fb53-4b9c-80a1-436771594963"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daf11c81-3cbf-4520-b8b6-bcae3e4e644a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e57a7b75-1392-42c1-b27e-e6b5d95d5f51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f38a503f-f0d6-47f5-9fd9-8206585b441a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa6de76b-eaa7-49ec-90fe-cc921014922f"));

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cities");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                comment: "Total price including delivery price");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("046a0656-a16e-402c-bec2-b8c48d2c68dc"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7350), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("1a2744a6-6ce1-4df2-aefa-fd902bb5ba2c"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7645), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("1d92d5db-fc11-4f69-9508-9ac0d1a395e9"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7522), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("27565ece-22fa-4703-be13-defa9484c17d"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7321), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("2e11cb40-b208-4247-86b0-442b899c099a"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7469), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("309f0293-af20-4471-811c-103ad0edefd4"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7053), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("34186b59-15c3-47d4-acf3-116b780885c3"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7621), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("390d123f-f0c1-4b74-bc50-ac102acc1d79"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7571), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("4e25b4fd-5124-44b0-8448-1c25a2419b1d"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7248), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("50249951-87bd-4f94-af9a-88312d4898d4"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7152), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("5690d29e-8a3b-4f46-860b-6ba32088c244"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7274), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("6bd91400-a693-43f3-9fc5-6287f9e4261d"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7087), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("6cbc890e-5961-4725-867e-640459cfd1e8"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7405), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("788dade8-192b-4bdd-b263-a433664e5929"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7596), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("8bd4d479-844f-47f0-8689-43f5854d8c37"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7221), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("93b5a17c-0a7a-4daf-adef-e995d6a917a0"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7668), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("93b9dcf3-6826-4f4e-95d3-bc0d368887de"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(6931), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("9db80452-77de-44b1-9c48-99282c1e8498"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7381), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("9fb75b77-3166-497c-a6a5-d838e0cdc4ce"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7495), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("cd16e35f-d11c-4a93-b1f8-45171d667309"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7186), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("d68d9fad-e914-4d2a-a03f-5000846f7e2b"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7437), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("f9c2c4f3-7292-4ade-8f8e-256229a937d8"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 12, 6, 1, 32, 38, 121, DateTimeKind.Local).AddTicks(7124), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("046a0656-a16e-402c-bec2-b8c48d2c68dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a2744a6-6ce1-4df2-aefa-fd902bb5ba2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d92d5db-fc11-4f69-9508-9ac0d1a395e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27565ece-22fa-4703-be13-defa9484c17d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e11cb40-b208-4247-86b0-442b899c099a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("309f0293-af20-4471-811c-103ad0edefd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34186b59-15c3-47d4-acf3-116b780885c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("390d123f-f0c1-4b74-bc50-ac102acc1d79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e25b4fd-5124-44b0-8448-1c25a2419b1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50249951-87bd-4f94-af9a-88312d4898d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5690d29e-8a3b-4f46-860b-6ba32088c244"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bd91400-a693-43f3-9fc5-6287f9e4261d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cbc890e-5961-4725-867e-640459cfd1e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("788dade8-192b-4bdd-b263-a433664e5929"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bd4d479-844f-47f0-8689-43f5854d8c37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b5a17c-0a7a-4daf-adef-e995d6a917a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b9dcf3-6826-4f4e-95d3-bc0d368887de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9db80452-77de-44b1-9c48-99282c1e8498"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb75b77-3166-497c-a6a5-d838e0cdc4ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd16e35f-d11c-4a93-b1f8-45171d667309"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d68d9fad-e914-4d2a-a03f-5000846f7e2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9c2c4f3-7292-4ade-8f8e-256229a937d8"));

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Foreign Key reference to the Country entity");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CountryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CountryId",
                value: 0);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("16b2294e-149f-48cb-953d-c302705b3d7f"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4032), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("29b6287c-a852-4210-aec2-ab781393837f"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3965), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("4440492c-fe98-4c1e-b304-29947ff97991"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3507), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("60e7d161-473b-475a-8459-35067a7db0b8"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3806), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("71d5c62b-b648-4a11-b7c0-e7e4d59e419d"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4205), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("77b37df2-8b94-4133-81e5-02597a7a9fd2"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3744), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("7e66c67c-bf3e-442d-b8a6-fa67459512aa"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4087), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("8466df5b-1d1d-49ff-bb15-7ef9f9f921e8"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3653), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("9202f74b-bcb6-4106-a61a-0a69b063bea8"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3618), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("937517b1-db0b-4f66-90c0-ed4d844ff089"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3883), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("9dd8ef75-51db-4599-bb2a-40c992233ae6"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4134), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("9f18b022-0a7a-476b-9577-397a26525f44"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4059), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("b2eb0c4b-aedf-45cc-a322-0fca4d5d7b15"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3779), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("bb51d7e5-33f3-4a81-be0a-e8b949919872"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4182), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("c65680d9-7adb-40da-90b4-c94ed95d6913"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3711), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("cfa39287-b4fc-4d44-9db5-63d549493584"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3998), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("d1ae1d43-a16e-4f9e-88b7-07ae7e732044"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3683), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("d5667616-fb53-4b9c-80a1-436771594963"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3912), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("daf11c81-3cbf-4520-b8b6-bcae3e4e644a"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4229), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("e57a7b75-1392-42c1-b27e-e6b5d95d5f51"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3835), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("f38a503f-f0d6-47f5-9fd9-8206585b441a"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(4158), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("fa6de76b-eaa7-49ec-90fe-cc921014922f"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 12, 6, 0, 57, 34, 443, DateTimeKind.Local).AddTicks(3941), "Малко, симпатично авокадо.", "Височината е около 15см" }
                });
        }
    }
}
