using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsScores.Repository.Data.Migrations
{
    public partial class RemovingUnusefulData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Scores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Scores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Scores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
