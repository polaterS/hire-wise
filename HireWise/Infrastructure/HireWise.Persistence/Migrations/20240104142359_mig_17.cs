using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EventAndSeminars",
                newName: "EventName");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "EventAndSeminars",
                newName: "EventLocation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventName",
                table: "EventAndSeminars",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EventLocation",
                table: "EventAndSeminars",
                newName: "Location");
        }
    }
}
