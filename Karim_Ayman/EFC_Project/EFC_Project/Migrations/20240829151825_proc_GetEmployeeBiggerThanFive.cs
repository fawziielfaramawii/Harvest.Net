using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCProject.Migrations
{
    /// <inheritdoc />
    public partial class procGetEmployeeBiggerThanFive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            create proc proc_GetEmployeeBiggerThanFive
            @id int
            as
            begin
            select*from Emplyees where @id>5
            end


            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop procedure proc_GetEmployeeBiggerThanFive");
        }
    }
}
