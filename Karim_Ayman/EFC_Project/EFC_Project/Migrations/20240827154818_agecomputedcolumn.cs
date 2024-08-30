using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCProject.Migrations
{
    /// <inheritdoc />
    public partial class agecomputedcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Emplyees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Emplyees",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(year, [DateOfBirth], GETDATE())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Emplyees");
        }
    }
}
