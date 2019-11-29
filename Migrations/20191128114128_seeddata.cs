using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstMigrationas.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudId", "Address", "DeptName", "Marks", "Name", "Performance" },
                values: new object[] { 1L, "New York", "Developer", 90, "John", "Good" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudId",
                keyValue: 1L);
        }
    }
}
