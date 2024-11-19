using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("056b64cf-956b-4855-b3a8-360e2258092e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29e20b9c-1bfb-4b87-a74c-724149598158"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ec2a1d5-58ea-4d18-8b70-fd1e93dc0c93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f2c7f3a-465b-4db8-b236-d56302b30fb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c97c70c-ea86-489a-880a-c251b417b70e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cd910bf-9a24-411d-b291-339886b92170"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d8e863f-1128-4604-a7c6-14c8c71625be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ea6b471-fffe-4ceb-b80e-6833bd22c4fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d8bc8d2-ce27-4a5b-ba49-a7dc831ea5b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("719afca8-acee-42d0-aff8-1f974942b690"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78a2b25b-5592-4434-9975-82182e3d2ca5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("822fa4b2-0948-4bec-b6b0-831ac2b88046"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89ac1230-4388-46dd-8995-42716e6bbbb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a277672-28cd-4146-85dc-4001f78eb151"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cd42dc9-c4ce-4dde-af06-f19490fcf122"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d7e1195-5585-4f96-a91c-861ce397b61c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b812cd6b-84a1-425e-ae71-01faf273b146"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfe2a23b-5798-4a9d-aed8-52fe81d7e3e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1f1f7f9-e6c7-4f9e-88b9-d11662b253ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3fac8db-c77c-4341-9372-8da925fad7b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f03dc52c-64e6-45e3-9bd5-cfe666a856b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2c0a1fd-9ed0-4672-b2eb-8a6f5834ea34"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("028944a6-1c7b-437b-8d5c-fe150e81b676"), 11, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2226), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("280be2e2-3a9f-4039-8a10-f6bbb3738ff0"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2533), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("498e3e42-28a1-4c86-ba7b-79927d8ccc1b"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2404), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("510841d3-f2db-4332-a8b9-f336a47d6bf1"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Декорация Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2645), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("55de45e5-7542-407a-b2e4-b768fc9cb5b5"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2500), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("59477ea0-b05b-4a39-8c59-39741c8b2c5d"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Декорация Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2613), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("59e19d1c-a24a-4000-a59b-54061ae9f524"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2158), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("5aebe6a4-f1fe-4b66-b7e0-1980568ccad7"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2374), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("6b54e207-78ca-4145-9cdc-ac01fe9fc22e"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2262), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("7bbedc04-9406-4a71-ac34-f43c0a8e354f"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2343), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("805ab5e7-b7fb-430e-bcea-3a807fa03c90"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Декорация Малко панерче", 30m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2674), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("96d8a652-7c06-49d3-be7a-d321b569f574"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2292), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("98047465-de6c-460a-a0d7-91b7c01eb649"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Декорация Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2731), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("9a52d9d0-1d4c-44a8-b6fd-2bc8f79aeed5"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2080), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("af170ef7-7a5b-4564-94c9-257ca0c44e5e"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2562), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("b89d32bc-5073-4607-8292-7c7041731f6f"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Декорация Малко панерче", 20m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2756), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("bfa3dde4-3ac3-4844-bd5d-837a5482b608"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2117), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("c072e850-9cf6-45f7-b063-066cf5ab257a"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2464), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("cc7d923d-dbcd-4837-ad8a-b41c798ba3cf"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2436), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("d1eecdfa-cc70-4bf3-8625-b2863023b563"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Декорация Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2703), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("d34c129f-d1bd-4fe2-bd4d-bb626fa375ca"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(1906), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("ddf7a806-9e69-41a7-8397-bf31872806da"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 19, 2, 22, 5, 954, DateTimeKind.Local).AddTicks(2188), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("028944a6-1c7b-437b-8d5c-fe150e81b676"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("280be2e2-3a9f-4039-8a10-f6bbb3738ff0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("498e3e42-28a1-4c86-ba7b-79927d8ccc1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("510841d3-f2db-4332-a8b9-f336a47d6bf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55de45e5-7542-407a-b2e4-b768fc9cb5b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59477ea0-b05b-4a39-8c59-39741c8b2c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59e19d1c-a24a-4000-a59b-54061ae9f524"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aebe6a4-f1fe-4b66-b7e0-1980568ccad7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b54e207-78ca-4145-9cdc-ac01fe9fc22e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bbedc04-9406-4a71-ac34-f43c0a8e354f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("805ab5e7-b7fb-430e-bcea-3a807fa03c90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96d8a652-7c06-49d3-be7a-d321b569f574"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98047465-de6c-460a-a0d7-91b7c01eb649"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a52d9d0-1d4c-44a8-b6fd-2bc8f79aeed5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af170ef7-7a5b-4564-94c9-257ca0c44e5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b89d32bc-5073-4607-8292-7c7041731f6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfa3dde4-3ac3-4844-bd5d-837a5482b608"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c072e850-9cf6-45f7-b063-066cf5ab257a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc7d923d-dbcd-4837-ad8a-b41c798ba3cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1eecdfa-cc70-4bf3-8625-b2863023b563"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d34c129f-d1bd-4fe2-bd4d-bb626fa375ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddf7a806-9e69-41a7-8397-bf31872806da"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ReleasedOn", "ShortDescription", "Size" },
                values: new object[,]
                {
                    { new Guid("056b64cf-956b-4855-b3a8-360e2258092e"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7792), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("29e20b9c-1bfb-4b87-a74c-724149598158"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Декорация Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8560), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("2ec2a1d5-58ea-4d18-8b70-fd1e93dc0c93"), 11, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7853), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("2f2c7f3a-465b-4db8-b236-d56302b30fb0"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Декорация Малко панерче", 20m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8607), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("5c97c70c-ea86-489a-880a-c251b417b70e"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7762), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("5cd910bf-9a24-411d-b291-339886b92170"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Декорация Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8511), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("5d8e863f-1128-4604-a7c6-14c8c71625be"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7728), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("5ea6b471-fffe-4ceb-b80e-6833bd22c4fe"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7562), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("6d8bc8d2-ce27-4a5b-ba49-a7dc831ea5b1"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7915), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("719afca8-acee-42d0-aff8-1f974942b690"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Декорация Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8584), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("78a2b25b-5592-4434-9975-82182e3d2ca5"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8328), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("822fa4b2-0948-4bec-b6b0-831ac2b88046"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7888), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("89ac1230-4388-46dd-8995-42716e6bbbb4"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8392), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("9a277672-28cd-4146-85dc-4001f78eb151"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8419), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("9cd42dc9-c4ce-4dde-af06-f19490fcf122"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Декорация Малко панерче", 30m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8536), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("9d7e1195-5585-4f96-a91c-861ce397b61c"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Декорация Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8480), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("b812cd6b-84a1-425e-ae71-01faf273b146"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8214), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("bfe2a23b-5798-4a9d-aed8-52fe81d7e3e2"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8361), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("c1f1f7f9-e6c7-4f9e-88b9-d11662b253ad"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8303), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("e3fac8db-c77c-4341-9372-8da925fad7b9"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(7819), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("f03dc52c-64e6-45e3-9bd5-cfe666a856b7"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8245), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("f2c0a1fd-9ed0-4672-b2eb-8a6f5834ea34"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 19, 2, 11, 41, 720, DateTimeKind.Local).AddTicks(8275), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" }
                });
        }
    }
}
