using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCProject.Migrations
{
    /// <inheritdoc />
    public partial class SetConstraintsOverEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Emplyees",
                newName: "Full Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emplyees",
                newName: "EmpId");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Emplyees",
                type: "float",
                nullable: false,
                defaultValue: 5000.0,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Full Name",
                table: "Emplyees",
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
                name: "Full Name",
                table: "Emplyees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Emplyees",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Emplyees",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 5000.0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
