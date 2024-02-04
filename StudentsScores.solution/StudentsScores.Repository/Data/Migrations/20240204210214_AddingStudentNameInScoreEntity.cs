using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsScores.Repository.Data.Migrations
{
    public partial class AddingStudentNameInScoreEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Scores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Scores");
        }
    }
}
