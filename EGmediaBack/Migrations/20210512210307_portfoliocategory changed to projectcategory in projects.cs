using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class portfoliocategorychangedtoprojectcategoryinprojects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_projectCategories_PortfolioCategoryId",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "PortfolioCategoryId",
                table: "projects",
                newName: "ProjectCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_projects_PortfolioCategoryId",
                table: "projects",
                newName: "IX_projects_ProjectCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_projectCategories_ProjectCategoryId",
                table: "projects",
                column: "ProjectCategoryId",
                principalTable: "projectCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_projectCategories_ProjectCategoryId",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "ProjectCategoryId",
                table: "projects",
                newName: "PortfolioCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_projects_ProjectCategoryId",
                table: "projects",
                newName: "IX_projects_PortfolioCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_projectCategories_PortfolioCategoryId",
                table: "projects",
                column: "PortfolioCategoryId",
                principalTable: "projectCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
