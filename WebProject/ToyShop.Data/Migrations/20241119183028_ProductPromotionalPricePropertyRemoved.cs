using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductPromotionalPricePropertyRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("027acb6a-4715-432f-ae9e-e054a342c180"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_01.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(4126), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("109e1f32-9f3f-44f3-ad72-11abd8770e0f"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_04.jpg", true, "Средна кошница ", 40m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(4151), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 30см в диаметър." },
                    { new Guid("146bfc20-a3d2-4128-ad26-dddf337e0085"), 4, "Цялата декорация е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички. Вклюва ръчно изработено панерче, седем сладки яйчица и естествено едно пухкаво зайче.", 0, "img/products/rabbit_Easter.jpg", true, "Великденски Заек", 25m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3898), "Ето една сладка идея за подарък изненада за ваш близък, а защо не и за самите вас.", "Височината на цялата декорация е около 18см." },
                    { new Guid("15187cc4-28f5-472f-8309-60c282a1dce6"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_03.jpg", true, "Малко панерче", 30m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(4101), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." },
                    { new Guid("2772b492-5913-4e3f-8c15-ae7d3bfeeeea"), 4, "Лоли е ръчноизработена, като рокличката, обувчиците и лентата се свалят. Изработена е от плюшена прежда и пълна със силиконов гранулиран пух.", 0, "img/products/rabbit_Lollie.jpg", true, "Зайче Лоли", 40m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3816), "Ето я и сладката Лоли, която е готова за щури игри.", "Лоли е висока около 35см." },
                    { new Guid("3bd0bed3-ee33-4f66-8de8-cc1abfd4ea1b"), 6, "Изработена е от плюшена хипоалергенна прежда, има си обезопасени очички и пълнеж на гранули.", 0, "img/products/unicorn_Polly.jpg", true, "Еднорог Поли", 45m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3787), "Поли е сладък, шарен еднорог готов за игри и много гушкане!", "Височината е около 35см" },
                    { new Guid("4b01d7ee-ef2b-418b-8346-75bfbd8469ab"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Frozen.jpg", true, "Торта Фроузън", 15m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3989), "Тортата за малките госпожици, които харесват Елза и Анна . Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("5b59dd12-efa5-4715-9ec3-f035af2a933a"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, 1, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3363), "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж.", "Височината е около 35см." },
                    { new Guid("5c24f8a9-818c-4ac7-a389-b7644887f371"), 7, "Всеки от тях е изключително сладък, пухкав и гушлив. Изработени са от плюшена прежда и са пълни със силиконов гранулиран пух.", 0, "img/products/mouse_Jerry.jpg", true, "Мишле Джери", 35m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3845), "Това са малките мишоци, които изработваме съвсем отскоро.", "Височината им е около 25см" },
                    { new Guid("6ccda01a-a699-4dba-ad8c-7807f9254d0d"), 2, "Тези сладки мечета вече се радват на много гушкане и игри.", 0, "img/products/bear_Emma.jpg", true, "Мече Ема", 50m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3694), "Това е мечето Ема, готово за предстоящите хладни дни.", "Височината е около 35см" },
                    { new Guid("7b8bc6bf-2cdb-4d24-b686-0cc387b98a90"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_Safari.jpg", true, "Торта Сафари", 15m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3963), "Тортата за всяко дете, любител на животни. Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("887f5b32-b3cc-4354-a584-fa695bc1bab6"), 5, "Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3625), "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Височината му е около 30см." },
                    { new Guid("8d2ce8be-667b-45e3-83f6-aa246481eece"), 13, "Изработено е от плюшена прежда и е пълно със силиконов гранулиран пух.", 0, "img/products/avocado_1.jpg", true, "Плюшено Авокадо", 20m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3874), "Малко, симпатично авокадо.", "Височината е около 15см" },
                    { new Guid("902fc633-3dd8-42c2-9a5b-f278bb326a72"), 2, "Това сладко мече Дани вече се радва на много гушкане и игри.", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3533), "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. ", "Височината е около 35см, без шапчицата." },
                    { new Guid("96a79148-a48c-4976-a47e-4d8886ab6347"), 10, "Всяка торта се изработва изцяло по желание на малкия рожденик и може да бъде използвана като част от празника в детската градина.", 3, "img/products/cake_HarryPotter.jpg", true, "Торта Хари Потър", 15m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3931), "Само за истински, малки фенове на Хари Потър! Минималният брой парчета е 15.", "Размерът зависи от броят на парчетата." },
                    { new Guid("af9842f0-50c2-42e1-b51c-0a20e2a19d75"), 3, "Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3568), "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж.", "Висок е малко над 35см." },
                    { new Guid("b91a58f8-3f81-4a83-b7b9-cdeb44e691a0"), 11, "Всяка кошница се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_02.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(4046), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("befb66fa-1b95-446c-a01e-c4b39d80f740"), 2, "Мечето Теди е изработено от плюшена прежда, обезапасени очички, носле и гранулиран пълнеж.", 0, "img/products/bear_Teddy.jpg", true, "Мече Теди", 30m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3722), "Толкова е сладък, че ти идва да не спираш да го гушкаш.", "Височината е около 25см" },
                    { new Guid("c1e5c9e3-1f56-4467-8ca5-5d380048166f"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_06.jpg", true, "Малка кошница", 25m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(4076), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 20см в диаметър." },
                    { new Guid("d4b2f658-1c11-445a-a1e0-64fe013d4ea6"), 11, "Времето навън все по-често ни напомня, че наближава зима, ❄️а какво по-хубаво от това през студените дни да се завиеш с пухкаво, меко и топло одеалце, а защо не и да подариш едно такова на малко сладурче?", 1, "img/products/blanket_01.jpg", true, "Плетено Одеало", 30m, 1, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3660), "Одеалцето е изработено от пухкава плюшена прежда.", "Размер 90х90." },
                    { new Guid("d6794080-840b-4043-b640-91ab876dbe5e"), 4, "Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(3598), "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички.", "Софи е висока около 24см." },
                    { new Guid("f8f2a041-3fbe-4419-921c-074757e7460e"), 11, "Всяка декорация се изработва изцяло по желание на клиента и може да бъде се използвана като декорация в дома или офиса.", 2, "img/products/decoration_05.jpg", true, "Малко панерче", 20m, null, 5, new DateTime(2024, 11, 19, 20, 30, 27, 637, DateTimeKind.Local).AddTicks(4174), "Красив и стилен подарък, дори с ограничен бюджет.", "Размерът e около 18см в диаметър." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("027acb6a-4715-432f-ae9e-e054a342c180"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("109e1f32-9f3f-44f3-ad72-11abd8770e0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("146bfc20-a3d2-4128-ad26-dddf337e0085"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15187cc4-28f5-472f-8309-60c282a1dce6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2772b492-5913-4e3f-8c15-ae7d3bfeeeea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bd0bed3-ee33-4f66-8de8-cc1abfd4ea1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b01d7ee-ef2b-418b-8346-75bfbd8469ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b59dd12-efa5-4715-9ec3-f035af2a933a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c24f8a9-818c-4ac7-a389-b7644887f371"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ccda01a-a699-4dba-ad8c-7807f9254d0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b8bc6bf-2cdb-4d24-b686-0cc387b98a90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("887f5b32-b3cc-4354-a584-fa695bc1bab6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d2ce8be-667b-45e3-83f6-aa246481eece"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("902fc633-3dd8-42c2-9a5b-f278bb326a72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96a79148-a48c-4976-a47e-4d8886ab6347"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af9842f0-50c2-42e1-b51c-0a20e2a19d75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b91a58f8-3f81-4a83-b7b9-cdeb44e691a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("befb66fa-1b95-446c-a01e-c4b39d80f740"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1e5c9e3-1f56-4467-8ca5-5d380048166f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4b2f658-1c11-445a-a1e0-64fe013d4ea6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6794080-840b-4043-b640-91ab876dbe5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8f2a041-3fbe-4419-921c-074757e7460e"));

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
    }
}
