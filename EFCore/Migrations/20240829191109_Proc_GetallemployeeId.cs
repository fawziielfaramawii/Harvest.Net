using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Proc_GetallemployeeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                            create proc  Proc_GetallemployeeId
                            @id int
                            as
                            begin
                            select * from Employees where Id =@id
                            end

                             ");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure Proc_GetallemployeeId");

        }
    }
}
