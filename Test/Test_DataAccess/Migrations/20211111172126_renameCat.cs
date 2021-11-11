using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_DataAccess.Migrations
{
    public partial class renameCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_category",
                newName: "Categories_Name");

            migrationBuilder.RenameColumn(
                name: "categories_id",
                table: "tbl_category",
                newName: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categories_Name",
                table: "tbl_category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "tbl_category",
                newName: "categories_id");
        }
    }
}
