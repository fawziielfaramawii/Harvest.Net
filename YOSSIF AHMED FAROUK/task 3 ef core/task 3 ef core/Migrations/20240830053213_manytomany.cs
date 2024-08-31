using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task_3_ef_core.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addrsses",
                columns: table => new
                {
                    employeeid = table.Column<int>(type: "int", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gov = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addrsses", x => x.employeeid);
                    table.ForeignKey(
                        name: "FK_addrsses_Employees_employeeid",
                        column: x => x.employeeid,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dep_pro",
                columns: table => new
                {
                    projectId = table.Column<int>(type: "int", nullable: false),
                    DepartmentClass1id = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dep_pro", x => new { x.projectId, x.DepartmentClass1id });
                    table.ForeignKey(
                        name: "FK_dep_pro_DepartmentClass1s_DepartmentClass1id",
                        column: x => x.DepartmentClass1id,
                        principalTable: "DepartmentClass1s",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dep_pro_projects_projectId",
                        column: x => x.projectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentClass1project",
                columns: table => new
                {
                    departmentsID = table.Column<int>(type: "int", nullable: false),
                    projectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentClass1project", x => new { x.departmentsID, x.projectsId });
                    table.ForeignKey(
                        name: "FK_DepartmentClass1project_DepartmentClass1s_departmentsID",
                        column: x => x.departmentsID,
                        principalTable: "DepartmentClass1s",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentClass1project_projects_projectsId",
                        column: x => x.projectsId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dep_pro_DepartmentClass1id",
                table: "dep_pro",
                column: "DepartmentClass1id");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentClass1project_projectsId",
                table: "DepartmentClass1project",
                column: "projectsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addrsses");

            migrationBuilder.DropTable(
                name: "dep_pro");

            migrationBuilder.DropTable(
                name: "DepartmentClass1project");
        }
    }
}
