using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_DataAccess.Migrations
{
    public partial class renameCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "tbl_category");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "tbl_category",
                newName: "categories_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category",
                column: "categories_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category");

            migrationBuilder.RenameTable(
                name: "tbl_category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "categories_id",
                table: "Categories",
                newName: "Category_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Category_Id");
        }
    }
}
