using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class addConstrainsOnTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Projects",
                newName: "Project Name");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "Employee Salary");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "Employee name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Department",
                newName: "Department name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Project Name",
                table: "Projects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "Employee Salary",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 5000.0,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Employee name",
                table: "Employees",
                type: "varchar(30)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Department name",
                table: "Department",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Employees",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(YEAR ,GETDATE(),[DateOfBirth])",
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Project Name",
                table: "Projects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Employee name",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Employee Salary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "Department name",
                table: "Department",
                newName: "Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(YEAR ,GETDATE(),[DateOfBirth])");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Employees",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5000.0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
