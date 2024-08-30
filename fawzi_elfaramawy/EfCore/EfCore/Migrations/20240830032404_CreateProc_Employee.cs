using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.Migrations
{
    /// <inheritdoc />
    public partial class CreateProc_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create proc Proc_Employee
                         as
                  begin
                 select * from Employees where Id>5
                  end"); 

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure Proc_Employee ");
        }
    }
}
