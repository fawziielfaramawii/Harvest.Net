using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    public partial class AddConst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(@"
                            CREATE PROCEDURE GetEmployeesWithIdGreaterThan5
                            AS
                            BEGIN
                            SELECT * FROM Employees WHERE EmployeeId > 5
                            END");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop procedure GetEmployeesWithIdGreaterThan5 ");
        }
    }
}
