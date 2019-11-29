using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstMigrationas.Migrations
{
    public partial class addedPerformance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Performance",
                table: "Students",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Performance",
                table: "Students");
        }
    }
}
