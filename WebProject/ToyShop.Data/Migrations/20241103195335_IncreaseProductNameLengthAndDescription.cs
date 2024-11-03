using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToyShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class IncreaseProductNameLengthAndDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Name of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Name of the product with a maximum length constraint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Optional detailed description of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Optional detailed description of the product with a maximum length constraint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Name of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Name of the product with a maximum length constraint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "Optional detailed description of the product with a maximum length constraint",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Optional detailed description of the product with a maximum length constraint");
        }
    }
}
