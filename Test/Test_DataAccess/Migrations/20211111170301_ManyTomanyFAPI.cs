using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_DataAccess.Migrations
{
    public partial class ManyTomanyFAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_Authors",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Authors", x => x.Author_Id);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_Book",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PriceRange = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Book", x => x.Book_Id);
                });

            migrationBuilder.CreateTable(
                name: "fluent_BookInAuthors",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false),
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    Book_Id1 = table.Column<int>(type: "int", nullable: true),
                    Author_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fluent_BookInAuthors", x => new { x.Author_Id, x.Book_Id });
                    table.ForeignKey(
                        name: "FK_fluent_BookInAuthors_Authors_Author_Id1",
                        column: x => x.Author_Id1,
                        principalTable: "Authors",
                        principalColumn: "Author_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_fluent_BookInAuthors_Books_Book_Id1",
                        column: x => x.Book_Id1,
                        principalTable: "Books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "fluent_Publishers",
                columns: table => new
                {
                    Publisher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fluent_Publishers", x => x.Publisher_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_fluent_BookInAuthors_Author_Id1",
                table: "fluent_BookInAuthors",
                column: "Author_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_fluent_BookInAuthors_Book_Id1",
                table: "fluent_BookInAuthors",
                column: "Book_Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_Authors");

            migrationBuilder.DropTable(
                name: "Fluent_Book");

            migrationBuilder.DropTable(
                name: "fluent_BookInAuthors");

            migrationBuilder.DropTable(
                name: "fluent_Publishers");
        }
    }
}
