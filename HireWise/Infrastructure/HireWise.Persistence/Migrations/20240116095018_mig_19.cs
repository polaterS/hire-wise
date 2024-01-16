using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Families",
                newName: "FamilyLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Families",
                newName: "FamilyFirstName");

            migrationBuilder.AlterColumn<string>(
                name: "WorkDateOfStart",
                table: "WorkExperiences",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "WorkDateOfEnd",
                table: "WorkExperiences",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Employees",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyLastName",
                table: "Families",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FamilyFirstName",
                table: "Families",
                newName: "FirstName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkDateOfStart",
                table: "WorkExperiences",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkDateOfEnd",
                table: "WorkExperiences",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
