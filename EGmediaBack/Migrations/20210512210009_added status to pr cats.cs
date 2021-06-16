using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class addedstatustoprcats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "projectCategories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "projectCategories");
        }
    }
}
