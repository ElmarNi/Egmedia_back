using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class Sliderfirstandsecondword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Header",
                table: "sliders",
                newName: "Header_Second_Word");

            migrationBuilder.AddColumn<string>(
                name: "Header_First_Word",
                table: "sliders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header_First_Word",
                table: "sliders");

            migrationBuilder.RenameColumn(
                name: "Header_Second_Word",
                table: "sliders",
                newName: "Header");
        }
    }
}
