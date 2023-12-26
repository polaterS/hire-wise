using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "TerminationDate",
                table: "Departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Departments",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Departments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Departments",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "TerminationDate",
                table: "Departments",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
