using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net.Core.Migrations
{
    /// <inheritdoc />
    public partial class procproc_getemp_by_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create proc proc_getemp_by_id
                @id int
                as 
                begin
                select * from [dbo].[employees] as emp where emp.id=id
                end");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE proc_getemp_by_id");
        }
    }
}
