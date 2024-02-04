using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsScores.Repository.Data.Migrations
{
    public partial class AddingSubjectNameInScoreEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Scores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Scores");
        }
    }
}
