using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizBackend.Migrations
{
    public partial class QuizDbFinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QId",
                table: "Questions");
        }
    }
}
