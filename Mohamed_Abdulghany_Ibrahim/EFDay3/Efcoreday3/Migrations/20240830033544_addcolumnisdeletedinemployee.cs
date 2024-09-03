using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcoreday3.Migrations
{
    /// <inheritdoc />
    public partial class addcolumnisdeletedinemployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Isdeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isdeleted",
                table: "Employees");
        }
    }
}
