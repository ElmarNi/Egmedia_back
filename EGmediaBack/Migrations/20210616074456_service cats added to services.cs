using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class serviceCatsaddedtoservices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_serviceCategories_ServiceCategoryId",
                table: "services");

            migrationBuilder.DropIndex(
                name: "IX_services_ServiceCategoryId",
                table: "services");

            migrationBuilder.DropColumn(
                name: "ServiceCategoryId",
                table: "services");

            migrationBuilder.AddColumn<string>(
                name: "CategoryIconUrl",
                table: "services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryImageUrl",
                table: "services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "services",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "serviceCategories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_serviceCategories_ServiceId",
                table: "serviceCategories",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_serviceCategories_services_ServiceId",
                table: "serviceCategories",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serviceCategories_services_ServiceId",
                table: "serviceCategories");

            migrationBuilder.DropIndex(
                name: "IX_serviceCategories_ServiceId",
                table: "serviceCategories");

            migrationBuilder.DropColumn(
                name: "CategoryIconUrl",
                table: "services");

            migrationBuilder.DropColumn(
                name: "CategoryImageUrl",
                table: "services");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "services");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "serviceCategories");

            migrationBuilder.AddColumn<int>(
                name: "ServiceCategoryId",
                table: "services",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_services_ServiceCategoryId",
                table: "services",
                column: "ServiceCategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_services_serviceCategories_ServiceCategoryId",
                table: "services",
                column: "ServiceCategoryId",
                principalTable: "serviceCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
