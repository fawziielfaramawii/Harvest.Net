using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net.Core.Migrations
{
    /// <inheritdoc />
    public partial class omar1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emps_departments_DepartmentId",
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

            migrationBuilder.RenameIndex(
                name: "IX_Emps_DepartmentId",
                table: "employees",
                newName: "IX_employees_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentId",
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

            migrationBuilder.RenameIndex(
                name: "IX_employees_DepartmentId",
                schema: "HR",
                table: "Emps",
                newName: "IX_Emps_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emps",
                schema: "HR",
                table: "Emps",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emps_departments_DepartmentId",
                schema: "HR",
                table: "Emps",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
