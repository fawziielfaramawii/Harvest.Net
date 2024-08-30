using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task_3_ef_core.Migrations
{
    /// <inheritdoc />
    public partial class prop2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "Employees",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(YEAR , [brithdate] , GETDATE() )",
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(YEAR , [brithdate] , GETDATE() )");
        }
    }
}
