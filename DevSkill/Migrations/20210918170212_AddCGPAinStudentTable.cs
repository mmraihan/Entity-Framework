using Microsoft.EntityFrameworkCore.Migrations;

namespace DevSkill.Migrations
{
    public partial class AddCGPAinStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CGPA",
                table: "students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGPA",
                table: "students");
        }
    }
}
