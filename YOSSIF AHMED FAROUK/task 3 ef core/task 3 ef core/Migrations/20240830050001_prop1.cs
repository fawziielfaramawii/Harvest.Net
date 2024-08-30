using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task_3_ef_core.Migrations
{
    /// <inheritdoc />
    public partial class prop1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "salary",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 5000.0,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "brithdate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "brithdate",
                table: "Employees");

            migrationBuilder.AlterColumn<double>(
                name: "salary",
                table: "Employees",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5000.0);
        }
    }
}
