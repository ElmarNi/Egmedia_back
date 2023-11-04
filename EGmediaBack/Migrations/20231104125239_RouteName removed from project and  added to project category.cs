using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGmediaBack.Migrations
{
    /// <inheritdoc />
    public partial class RouteNameremovedfromprojectandaddedtoprojectcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouteName",
                table: "projects");

            migrationBuilder.AddColumn<string>(
                name: "RouteName",
                table: "projectCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouteName",
                table: "projectCategories");

            migrationBuilder.AddColumn<string>(
                name: "RouteName",
                table: "projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
