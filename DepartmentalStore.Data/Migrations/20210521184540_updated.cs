using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentalStore.Data.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Category_CategoryID",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "productCategory");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "productCategory",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_CategoryID",
                table: "productCategory",
                newName: "IX_productCategory_CategoryId");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "productCategory",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "productCategory",
                type: "bigint",
                maxLength: 128,
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_productCategory",
                table: "productCategory",
                columns: new[] { "Id", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_productCategory_ProductId",
                table: "productCategory",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_productCategory_Category_CategoryId",
                table: "productCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productCategory_Product_ProductId",
                table: "productCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productCategory_Category_CategoryId",
                table: "productCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_productCategory_Product_ProductId",
                table: "productCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productCategory",
                table: "productCategory");

            migrationBuilder.DropIndex(
                name: "IX_productCategory_ProductId",
                table: "productCategory");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "productCategory");

            migrationBuilder.RenameTable(
                name: "productCategory",
                newName: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ProductCategory",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_productCategory_CategoryId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_CategoryID");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductCategory",
                type: "bigint",
                maxLength: 128,
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Category_CategoryID",
                table: "ProductCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
