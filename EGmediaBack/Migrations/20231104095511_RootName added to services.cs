using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGmediaBack.Migrations
{
    /// <inheritdoc />
    public partial class RootNameaddedtoservices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RootName",
                table: "services",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RootName",
                table: "services");
        }
    }
}
