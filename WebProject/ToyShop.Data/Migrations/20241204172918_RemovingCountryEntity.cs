using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovingCountryEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId",
                table: "Cities");

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

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

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
                    { new Guid("085bfce8-b18f-4c90-93dd-c08e6a9fa884"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4395), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("0c626e42-5001-488c-8f95-4eff33436b5c"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4047), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("102d8b55-39f7-4ba0-ab9c-a018ff6cbdad"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, 5, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4519), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("2ae0821e-65af-4841-a462-13693c5c861e"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4701), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("4f592165-2887-433d-afc5-77da54e856ed"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4422), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("66e07bb4-888f-47f4-9c2b-073e05a5977b"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4364), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("6c600f1d-2851-480f-be55-3656855e083b"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4676), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("6c68296b-cda4-4064-a2e4-e4215e89ac52"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4091), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("89c8afee-8f76-4c7d-9bae-bf09f4167008"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4252), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("9042af40-b9d5-468a-8f7e-f94fc3078610"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4223), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("918c9240-6156-49aa-9cdd-fc20730965f7"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4152), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("accd3599-e1bd-471a-b7b0-489b5c894251"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(3861), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("b0ea23fc-deeb-4ac7-ad29-020d418adb08"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, 5, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4457), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("b371673f-986f-452b-bf08-d46c9c8cae98"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4650), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("b8fdec8c-7163-44de-a63a-8a5951cf5fac"), 12, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4187), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("c834f163-e032-4fa5-8e98-942232e493f9"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4331), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("ca40bc55-f88c-4d25-9a90-eda3ee9a3301"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4123), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("d18fec93-73df-4faf-856d-deffbfdda7f7"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4624), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("d933b6a5-bd1e-4005-bd0f-63f0e8d2b411"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, 5, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4491), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("e5954d1f-3de6-4eb6-97f2-470be0d826d1"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4596), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("e5df7681-f00f-4f18-a7e5-60555a98db43"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4280), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("ea1cb113-5f5f-464b-ab0e-8f748fdd45ab"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 12, 4, 19, 29, 17, 752, DateTimeKind.Local).AddTicks(4548), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("085bfce8-b18f-4c90-93dd-c08e6a9fa884"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c626e42-5001-488c-8f95-4eff33436b5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("102d8b55-39f7-4ba0-ab9c-a018ff6cbdad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ae0821e-65af-4841-a462-13693c5c861e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f592165-2887-433d-afc5-77da54e856ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66e07bb4-888f-47f4-9c2b-073e05a5977b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c600f1d-2851-480f-be55-3656855e083b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c68296b-cda4-4064-a2e4-e4215e89ac52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89c8afee-8f76-4c7d-9bae-bf09f4167008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9042af40-b9d5-468a-8f7e-f94fc3078610"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("918c9240-6156-49aa-9cdd-fc20730965f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("accd3599-e1bd-471a-b7b0-489b5c894251"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0ea23fc-deeb-4ac7-ad29-020d418adb08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b371673f-986f-452b-bf08-d46c9c8cae98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8fdec8c-7163-44de-a63a-8a5951cf5fac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c834f163-e032-4fa5-8e98-942232e493f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca40bc55-f88c-4d25-9a90-eda3ee9a3301"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d18fec93-73df-4faf-856d-deffbfdda7f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d933b6a5-bd1e-4005-bd0f-63f0e8d2b411"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5954d1f-3de6-4eb6-97f2-470be0d826d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5df7681-f00f-4f18-a7e5-60555a98db43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea1cb113-5f5f-464b-ab0e-8f748fdd45ab"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the Country entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Continent = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Optional continent of the country with a maximum length constraint"),
                    Currency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Currency used in the country with a maximum length constraint"),
                    ISOCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "ISO code of the country with a maximum length constraint"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "Indicates if the country is active"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the country with a maximum length constraint"),
                    PhoneCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Optional phone code of the country with a maximum length constraint"),
                    Region = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "Optional region of the country with a maximum length constraint")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CountryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CountryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "Currency", "ISOCode", "IsActive", "Name", "PhoneCode", "Region" },
                values: new object[] { 1, "Европа", "BGN", "BG", true, "България", "+359", "Източна Европа" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
