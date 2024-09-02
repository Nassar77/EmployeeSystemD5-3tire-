using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSystem.DAl.Migrations
{
    /// <inheritdoc />
    public partial class addsalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Employee",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employee");
        }
    }
}
