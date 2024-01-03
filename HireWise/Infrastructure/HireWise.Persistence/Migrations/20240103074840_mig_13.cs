using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Operation",
                table: "JobPosts",
                newName: "ModeOfOperation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModeOfOperation",
                table: "JobPosts",
                newName: "Operation");
        }
    }
}
