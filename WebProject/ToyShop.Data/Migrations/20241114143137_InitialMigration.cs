using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the Category entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of the category with a maximum length constraint")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the Country entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the country with a maximum length constraint"),
                    ISOCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "ISO code of the country with a maximum length constraint"),
                    Currency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Currency used in the country with a maximum length constraint"),
                    PhoneCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Optional phone code of the country with a maximum length constraint"),
                    Continent = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Optional continent of the country with a maximum length constraint"),
                    Region = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "Optional region of the country with a maximum length constraint"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "Indicates if the country is active")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the Promotion entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Name of the promotion with a maximum length constraint"),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false, comment: "Discount percentage offered by the promotion"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Start date of the promotion"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End date of the promotion")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the City entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the city with a maximum length constraint"),
                    PostCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Post code of the city with a maximum length constraint"),
                    CountryId = table.Column<int>(type: "int", nullable: false, comment: "Foreign Key reference to the Country entity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary Key for the Product entity"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of the product with a maximum length constraint"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the product available in stock"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "Price of the product in monetary terms"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Url of the product image"),
                    GlobalCategory = table.Column<int>(type: "int", nullable: false, comment: "Global category of the product"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Foreign Key reference to the Category entity"),
                    ShortDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Short description of the product with a maximum length constraint"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Optional detailed description of the product with a maximum length constraint"),
                    PromotionId = table.Column<int>(type: "int", nullable: true, comment: "Optional foreign Key reference to the Promotion entity"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the product is currently available for purchase")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary Key for the Address entity")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Street name of the address with a maximum length constraint"),
                    Number = table.Column<int>(type: "int", nullable: false, comment: "House number or address number"),
                    BuildingNumber = table.Column<int>(type: "int", nullable: true, comment: "Optional building number"),
                    Entrance = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "Optional entrance information for the address"),
                    OtherAddressInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Optional additional information for the address"),
                    CityId = table.Column<int>(type: "int", nullable: false, comment: "Foreign Key reference to the City entity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "First name of the user, required with a maximum length constraint"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Last name of the user, required with a maximum length constraint"),
                    Age = table.Column<int>(type: "int", nullable: true, comment: "Age of the user"),
                    Gender = table.Column<int>(type: "int", nullable: false, comment: "Gender of the user"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Registration date of the user"),
                    AddressId = table.Column<int>(type: "int", nullable: true, comment: "Foreign Key reference to the Address of the user"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "Indicates if the user account is active"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary Key for the Order entity"),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Unique order number with a maximum length constraint"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "Total price of the order in monetary terms"),
                    DeliveryPrice = table.Column<decimal>(type: "money", nullable: false, comment: "Delivery price associated with the order"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date when the order was placed"),
                    SendingDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Optional date when the order was sent"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Current status of the order"),
                    AddressId = table.Column<int>(type: "int", nullable: false, comment: "Foreign Key reference to the Address entity for delivery"),
                    CouponId = table.Column<int>(type: "int", nullable: true, comment: "Optional foreign Key reference to the Coupon entity"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the User entity who placed the order")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary Key for the Review entity"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Product being reviewed"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the User who wrote the review"),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Optional comment made by the user in the review with a maximum length constraint"),
                    Rating = table.Column<int>(type: "int", nullable: false, comment: "Rating given by the user for the product")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "UserProductWhishlist",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the User who owns the wishlist"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign Key reference to the Product in the wishlist")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProductWhishlist", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UserProductWhishlist_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProductWhishlist_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Еленчета" },
                    { 2, "Мечета" },
                    { 3, "Жирафчета" },
                    { 4, "Зайчета" },
                    { 5, "Кученца" },
                    { 6, "Цветя" },
                    { 7, "Торти" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "Currency", "ISOCode", "IsActive", "Name", "PhoneCode", "Region" },
                values: new object[] { 1, "Европа", "BGN", "BG", true, "България", "+359", "Източна Европа" });

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
                table: "Promotions",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Winter Sale", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 50, new DateTime(2024, 11, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Black Friday Deal", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 30, new DateTime(2025, 3, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Spring Clearance", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 40, new DateTime(2025, 6, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), "Summer Blowout", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 20, new DateTime(2025, 9, 15, 23, 59, 59, 0, DateTimeKind.Unspecified), "Back to School", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostCode" },
                values: new object[,]
                {
                    { 1, 1, "София", "1000" },
                    { 2, 1, "Пловдив", "4000" },
                    { 3, 1, "Варна", "9000" },
                    { 4, 1, "Бургас", "8000" },
                    { 5, 1, "Русе", "7000" },
                    { 6, 1, "Стара Загора", "6000" },
                    { 7, 1, "Плевен", "5800" },
                    { 8, 1, "Велико Търново", "5000" },
                    { 9, 1, "Благоевград", "2700" },
                    { 10, 1, "Шумен", "9700" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GlobalCategory", "ImageUrl", "IsAvailable", "Name", "Price", "PromotionId", "Quantity", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("68a75e6f-2bf8-48bc-a724-ca77e462761b"), 4, "Софи е висока около 24см. Идеална е за игри и гушкане.", 0, "img/products/rabbit_Sophie.jpg", true, "Зайче Софи", 25m, null, 5, "Софи изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("69515881-7767-4686-9f6f-f38f1d1ac34e"), 2, "Височината е около 35см, без шапчицата. Това сладко мече Дани вече се радва на много гушкане и игри и не е налично, но може да бъде изработено по поръчка. ", 0, "img/products/bear_Danny.jpg", true, "Мече Дани", 55m, 1, 5, "Това е мечето Дани, готово за предстоящите хладни дни с пухкава шапчица. " },
                    { new Guid("97f0768d-48b7-4a47-9b45-0f165af9884a"), 1, "Това еленче Рони, все още е налично и участва в каузата на бебе Божидар в групата PavelAndreev.BG. Всеки, който иска да го притежава може да се включи в каузата и да помогне на малкия Божидар.", 0, "img/products/deer_Ronnie.jpg", true, "Еленче Рони", 35m, null, 5, "Изработено от плюшена прежда, обезопасени очички на винт и гранулиран пълнеж." },
                    { new Guid("a8195de9-f4c4-4575-a8b2-908a99796f21"), 5, "Височината му е около 30см. Ако си търсите четириног приятел, който да няма нужда от разходки в горещите летни дни, храна, водичка и редовни прегледи при чичо доктор- ето го вашето решение!", 0, "img/products/dog_Bailey.jpg", true, "Кученце Бейли", 35m, null, 5, "Бейли е изработена от плюшена прежда, гранулиран пълнеж и обезопасени носле и очички." },
                    { new Guid("ae4312b3-8fad-430a-b38a-a2f72e50facb"), 3, "Висок е малко над 35см. Емблемата е бродирана и се заплаща допълнително спрямо размерите.", 0, "img/products/giraffe_Sammie.jpg", true, "Жирафче Сами", 45m, null, 5, "Сами е изработен е от плюшена прежда, обезопасени очички и гранулиран пълнеж." }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "BuildingNumber", "CityId", "Entrance", "Number", "OtherAddressInformation", "StreetName" },
                values: new object[,]
                {
                    { 1, null, 1, "А", 12, "До НДК", "бул. Витоша" },
                    { 2, 2, 1, null, 45, "Срещу книжарницата", "ул. Цар Иван Асен II" },
                    { 3, 5, 2, "Б", 89, "До аптеката", "бул. Сливница" },
                    { 4, null, 3, "В", 7, "Близо до парка", "ул. Александровска" },
                    { 5, 1, 4, null, 23, "До стадиона", "ул. Сан Стефано" },
                    { 6, null, 2, "Г", 101, "До университета", "ул. Княз Борис I" },
                    { 7, 3, 1, null, 18, "Близо до пазара", "ул. Граф Игнатиев" },
                    { 8, null, 5, "Д", 33, "Срещу банката", "ул. Дунав" },
                    { 9, 4, 3, null, 50, "До търговския център", "бул. Левски" },
                    { 10, null, 4, "Е", 99, "Близо до музея", "ул. Шипка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PromotionId",
                table: "Products",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartProduct_ProductId",
                table: "ShoppingCartProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProductWhishlist_ProductId",
                table: "UserProductWhishlist",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShoppingCartProduct");

            migrationBuilder.DropTable(
                name: "UserProductWhishlist");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
