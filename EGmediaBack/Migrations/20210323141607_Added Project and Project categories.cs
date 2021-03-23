using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class AddedProjectandProjectcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projectCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    PortfolioCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projects_projectCategories_PortfolioCategoryId",
                        column: x => x.PortfolioCategoryId,
                        principalTable: "projectCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_projects_PortfolioCategoryId",
                table: "projects",
                column: "PortfolioCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "projectCategories");
        }
    }
}
