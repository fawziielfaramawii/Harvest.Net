using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCProject.Migrations
{
    /// <inheritdoc />
    public partial class procGetEmployeeByID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create proc proc_GetEmployeeByID
                                @id int
                                as
                                begin
                                select*from Emplyees where EmpId=@id
                                end
                                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure proc_GetEmployeeByID");
        }
    }
}
