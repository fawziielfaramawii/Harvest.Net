using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Net.Core.Migrations
{
    /// <inheritdoc />
    public partial class addseedingdata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "id", "location", "name" },
                values: new object[,]
                {
                    { 4, "mansoura", "IT" },
                    { 5, "Cairo", "Hr" },
                    { 6, "Alex", "Cs" },
                    { 7, "Aswan", "Is" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: 7);
        }
    }
}
