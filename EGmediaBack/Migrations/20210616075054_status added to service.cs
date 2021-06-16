using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class statusaddedtoservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "services",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "services");
        }
    }
}
