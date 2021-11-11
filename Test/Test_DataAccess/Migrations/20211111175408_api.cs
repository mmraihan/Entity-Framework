using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_DataAccess.Migrations
{
    public partial class api : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Category",
                table: "Fluent_Category");

            migrationBuilder.RenameTable(
                name: "Fluent_Category",
                newName: "tblUpdate_category");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblUpdate_category",
                newName: "Category_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblUpdate_category",
                table: "tblUpdate_category",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblUpdate_category",
                table: "tblUpdate_category");

            migrationBuilder.RenameTable(
                name: "tblUpdate_category",
                newName: "Fluent_Category");

            migrationBuilder.RenameColumn(
                name: "Category_Name",
                table: "Fluent_Category",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Category",
                table: "Fluent_Category",
                column: "Category_Id");
        }
    }
}
