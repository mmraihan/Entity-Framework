using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_DataAccess.Migrations
{
    public partial class fluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_BookDetails",
                columns: table => new
                {
                    BookDetail_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfchapters = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookDetails", x => x.BookDetail_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_BookDetails");
        }
    }
}
