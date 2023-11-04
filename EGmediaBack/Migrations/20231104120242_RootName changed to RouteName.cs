using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGmediaBack.Migrations
{
    /// <inheritdoc />
    public partial class RootNamechangedtoRouteName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RootName",
                table: "services",
                newName: "RouteName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RouteName",
                table: "services",
                newName: "RootName");
        }
    }
}
