using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLP.Dal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductSize_SizeID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_SizeID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductSize",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SizeDescription",
                table: "ProductSize",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductID",
                table: "ProductSize",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_Product_ProductID",
                table: "ProductSize",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_Product_ProductID",
                table: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_ProductSize_ProductID",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "SizeDescription",
                table: "ProductSize");

            migrationBuilder.AddColumn<int>(
                name: "SizeID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_SizeID",
                table: "Product",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductSize_SizeID",
                table: "Product",
                column: "SizeID",
                principalTable: "ProductSize",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
