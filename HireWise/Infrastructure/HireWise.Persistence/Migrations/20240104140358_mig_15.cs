using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Languages");

            migrationBuilder.AddColumn<int>(
                name: "LanguageEnum",
                table: "Languages",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageEnum",
                table: "Languages");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Languages",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
