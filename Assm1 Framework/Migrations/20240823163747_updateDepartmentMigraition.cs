using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assm1_Framework.Migrations
{
    /// <inheritdoc />
    public partial class updateDepartmentMigraition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Departments");
        }
    }
}
