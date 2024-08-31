using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask3DEPI.Migrations
{
    /// <inheritdoc />
    public partial class createProc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE GetEmployeesWithIdGreaterThan5
                AS
                BEGIN
                    SELECT * 
                    FROM Employees
                    WHERE Id > 5
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetEmployeesWithIdGreaterThan5");

        }
    }
}
