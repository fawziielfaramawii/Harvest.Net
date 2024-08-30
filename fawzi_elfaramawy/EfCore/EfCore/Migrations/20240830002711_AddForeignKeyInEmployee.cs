using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyInEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Employees",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(YEAR ,   [BirthDate] ,GETDATE())",
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(YEAR ,   [DateOfBirth] ,GETDATE())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Employees",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(YEAR ,   [DateOfBirth] ,GETDATE())",
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(YEAR ,   [BirthDate] ,GETDATE())");
        }
    }
}
