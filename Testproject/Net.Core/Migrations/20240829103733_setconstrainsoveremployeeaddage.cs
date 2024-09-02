using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net.Core.Migrations
{
    /// <inheritdoc />
    public partial class setconstrainsoveremployeeaddage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                schema: "HR",
                table: "Emps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "HR",
                table: "Emps",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(YEAR ,[DateOfBirth],GETDATE())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                schema: "HR",
                table: "Emps");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                schema: "HR",
                table: "Emps");
        }
    }
}
