using Microsoft.EntityFrameworkCore.Migrations;

namespace EGmediaBack.Migrations
{
    public partial class servicesall3tablesnameschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceImages_Services_ServiceId",
                table: "ServiceImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceImages",
                table: "ServiceImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceCategories",
                table: "ServiceCategories");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "services");

            migrationBuilder.RenameTable(
                name: "ServiceImages",
                newName: "serviceImages");

            migrationBuilder.RenameTable(
                name: "ServiceCategories",
                newName: "serviceCategories");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ServiceCategoryId",
                table: "services",
                newName: "IX_services_ServiceCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceImages_ServiceId",
                table: "serviceImages",
                newName: "IX_serviceImages_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_services",
                table: "services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serviceImages",
                table: "serviceImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serviceCategories",
                table: "serviceCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_serviceImages_services_ServiceId",
                table: "serviceImages",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_services_serviceCategories_ServiceCategoryId",
                table: "services",
                column: "ServiceCategoryId",
                principalTable: "serviceCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serviceImages_services_ServiceId",
                table: "serviceImages");

            migrationBuilder.DropForeignKey(
                name: "FK_services_serviceCategories_ServiceCategoryId",
                table: "services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_services",
                table: "services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serviceImages",
                table: "serviceImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serviceCategories",
                table: "serviceCategories");

            migrationBuilder.RenameTable(
                name: "services",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "serviceImages",
                newName: "ServiceImages");

            migrationBuilder.RenameTable(
                name: "serviceCategories",
                newName: "ServiceCategories");

            migrationBuilder.RenameIndex(
                name: "IX_services_ServiceCategoryId",
                table: "Services",
                newName: "IX_Services_ServiceCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_serviceImages_ServiceId",
                table: "ServiceImages",
                newName: "IX_ServiceImages_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceImages",
                table: "ServiceImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceCategories",
                table: "ServiceCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceImages_Services_ServiceId",
                table: "ServiceImages",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryId",
                table: "Services",
                column: "ServiceCategoryId",
                principalTable: "ServiceCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
