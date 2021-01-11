using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizBackend.Migrations
{
    public partial class firstquizmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correctAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answer3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
