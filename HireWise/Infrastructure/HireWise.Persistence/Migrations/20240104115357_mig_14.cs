using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAlive",
                table: "Families");

            migrationBuilder.AddColumn<int>(
                name: "FamilyPhoneNumber",
                table: "Families",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilyPhoneNumber",
                table: "Families");

            migrationBuilder.AddColumn<bool>(
                name: "IsAlive",
                table: "Families",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
