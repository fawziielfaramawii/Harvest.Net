using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCProject.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneEmpAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<int>(type: "int", nullable: false),
                    Gov = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Address_Emplyees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Emplyees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
