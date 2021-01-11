using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizBackend.Migrations
{
    public partial class QuizDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "correctAnswer",
                table: "Questions",
                newName: "CorrectAnswer");

            migrationBuilder.RenameColumn(
                name: "answer3",
                table: "Questions",
                newName: "Answer3");

            migrationBuilder.RenameColumn(
                name: "answer2",
                table: "Questions",
                newName: "Answer2");

            migrationBuilder.RenameColumn(
                name: "answer1",
                table: "Questions",
                newName: "Answer1");

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.QuizId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.RenameColumn(
                name: "CorrectAnswer",
                table: "Questions",
                newName: "correctAnswer");

            migrationBuilder.RenameColumn(
                name: "Answer3",
                table: "Questions",
                newName: "answer3");

            migrationBuilder.RenameColumn(
                name: "Answer2",
                table: "Questions",
                newName: "answer2");

            migrationBuilder.RenameColumn(
                name: "Answer1",
                table: "Questions",
                newName: "answer1");
        }
    }
}
