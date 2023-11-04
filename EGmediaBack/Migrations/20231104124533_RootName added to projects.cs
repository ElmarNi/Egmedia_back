using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGmediaBack.Migrations
{
    /// <inheritdoc />
    public partial class RootNameaddedtoprojects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RouteName",
                table: "services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouteName",
                table: "projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouteName",
                table: "projects");

            migrationBuilder.AlterColumn<string>(
                name: "RouteName",
                table: "services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
