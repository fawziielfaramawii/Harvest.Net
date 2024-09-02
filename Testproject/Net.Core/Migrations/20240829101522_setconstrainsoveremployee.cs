using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net.Core.Migrations
{
    /// <inheritdoc />
    public partial class setconstrainsoveremployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_departmentid",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Emps",
                newSchema: "HR");

            migrationBuilder.RenameColumn(
                name: "name",
                schema: "HR",
                table: "Emps",
                newName: "FullNmae");

            migrationBuilder.RenameIndex(
                name: "IX_employees_departmentid",
                schema: "HR",
                table: "Emps",
                newName: "IX_Emps_departmentid");

            migrationBuilder.AlterColumn<string>(
                name: "FullNmae",
                schema: "HR",
                table: "Emps",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emps",
                schema: "HR",
                table: "Emps",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emps_departments_departmentid",
                schema: "HR",
                table: "Emps",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emps_departments_departmentid",
                schema: "HR",
                table: "Emps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emps",
                schema: "HR",
                table: "Emps");

            migrationBuilder.RenameTable(
                name: "Emps",
                schema: "HR",
                newName: "employees");

            migrationBuilder.RenameColumn(
                name: "FullNmae",
                table: "employees",
                newName: "name");

            migrationBuilder.RenameIndex(
                name: "IX_Emps_departmentid",
                table: "employees",
                newName: "IX_employees_departmentid");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_departmentid",
                table: "employees",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
