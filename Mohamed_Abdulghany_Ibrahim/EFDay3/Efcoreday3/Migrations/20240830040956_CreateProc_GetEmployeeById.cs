using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcoreday3.Migrations
{
    /// <inheritdoc />
    public partial class CreateProc_GetEmployeeById : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create proc Proc_GetEmployeeById 
                            @id int 
                         as
                            begin
                            select * from Employees where EmpId=4
                            end");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure Proc_GetEmployeeById  ");
        }
    }
}
