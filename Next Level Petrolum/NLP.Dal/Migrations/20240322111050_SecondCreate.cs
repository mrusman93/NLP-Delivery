using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLP.Dal.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Store_StoresStoreID",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_StoresStoreID",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "StoresStoreID",
                table: "Brand");

            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "Store",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Store_BrandID",
                table: "Store",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Brand_BrandID",
                table: "Store",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_Brand_BrandID",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_BrandID",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "Store");

            migrationBuilder.AddColumn<int>(
                name: "StoresStoreID",
                table: "Brand",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_StoresStoreID",
                table: "Brand",
                column: "StoresStoreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Store_StoresStoreID",
                table: "Brand",
                column: "StoresStoreID",
                principalTable: "Store",
                principalColumn: "StoreID");
        }
    }
}
