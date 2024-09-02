using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net.Core.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentProject",
                columns: table => new
                {
                    departmentsid = table.Column<int>(type: "int", nullable: false),
                    projectsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentProject", x => new { x.departmentsid, x.projectsid });
                    table.ForeignKey(
                        name: "FK_DepartmentProject_departments_departmentsid",
                        column: x => x.departmentsid,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentProject_projects_projectsid",
                        column: x => x.projectsid,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "deptproject",
                columns: table => new
                {
                    departmentid = table.Column<int>(type: "int", nullable: false),
                    proid = table.Column<int>(type: "int", nullable: false),
                    Projectid = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deptproject", x => new { x.proid, x.departmentid });
                    table.ForeignKey(
                        name: "FK_deptproject_departments_departmentid",
                        column: x => x.departmentid,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_deptproject_projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentProject_projectsid",
                table: "DepartmentProject",
                column: "projectsid");

            migrationBuilder.CreateIndex(
                name: "IX_deptproject_departmentid",
                table: "deptproject",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_deptproject_Projectid",
                table: "deptproject",
                column: "Projectid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentProject");

            migrationBuilder.DropTable(
                name: "deptproject");
        }
    }
}
