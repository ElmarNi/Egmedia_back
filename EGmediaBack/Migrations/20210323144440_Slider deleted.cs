using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class Sliderdeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aside_Header = table.Column<string>(nullable: false),
                    Aside_ImageUrl = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Header_First_Word = table.Column<string>(nullable: false),
                    Header_Second_Word = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliders", x => x.Id);
                });
        }
    }
}
