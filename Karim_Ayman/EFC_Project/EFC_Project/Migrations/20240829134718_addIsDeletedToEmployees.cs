using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCProject.Migrations
{
    /// <inheritdoc />
    public partial class addIsDeletedToEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Emplyees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Emplyees");
        }
    }
}
