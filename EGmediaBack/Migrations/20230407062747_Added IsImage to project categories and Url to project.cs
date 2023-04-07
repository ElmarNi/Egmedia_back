using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGmediaBack.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsImagetoprojectcategoriesandUrltoproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "projectCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "projectCategories");
        }
    }
}
