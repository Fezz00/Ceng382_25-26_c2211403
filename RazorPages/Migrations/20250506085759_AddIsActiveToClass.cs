using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveToClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Classes");
        }
    }
}
