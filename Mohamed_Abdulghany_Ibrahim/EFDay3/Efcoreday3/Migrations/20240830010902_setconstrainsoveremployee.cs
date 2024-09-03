using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcoreday3.Migrations
{
    /// <inheritdoc />
    public partial class setconstrainsoveremployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmpId");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 5000.0,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Employees",
                newName: "Id");

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
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
