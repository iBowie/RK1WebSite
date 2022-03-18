using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RK1WebSite.Migrations
{
    public partial class ApiNameForCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiName",
                table: "Categories");
        }
    }
}
