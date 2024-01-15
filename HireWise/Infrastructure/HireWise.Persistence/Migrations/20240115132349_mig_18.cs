using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireWise.Persistence.Migrations
{
    public partial class mig_18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SchoolDateOfStartOnUtc",
                table: "SchoolExperiences",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "SchoolDateOfEndOnUtc",
                table: "SchoolExperiences",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SchoolDateOfStartOnUtc",
                table: "SchoolExperiences",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SchoolDateOfEndOnUtc",
                table: "SchoolExperiences",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
