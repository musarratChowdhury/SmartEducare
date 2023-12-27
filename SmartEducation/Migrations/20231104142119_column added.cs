using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartEducation.Migrations
{
    public partial class columnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Page",
                table: "Topics",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Page",
                table: "Topics");
        }
    }
}
