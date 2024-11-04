using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureCatalog.Persistence.Migrations
{
    public partial class mig_DescriptionTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DescriptionTitle_CategoryId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionTitle_Name",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Specifications_FurnitureId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specifications_Value",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_DescriptionTitle_CategoryId",
                table: "BaseEntities",
                column: "DescriptionTitle_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Specifications_FurnitureId",
                table: "BaseEntities",
                column: "Specifications_FurnitureId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TitleId",
                table: "BaseEntities",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_DescriptionTitle_CategoryId",
                table: "BaseEntities",
                column: "DescriptionTitle_CategoryId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Specifications_FurnitureId",
                table: "BaseEntities",
                column: "Specifications_FurnitureId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TitleId",
                table: "BaseEntities",
                column: "TitleId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_DescriptionTitle_CategoryId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Specifications_FurnitureId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TitleId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_DescriptionTitle_CategoryId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Specifications_FurnitureId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TitleId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "DescriptionTitle_CategoryId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "DescriptionTitle_Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Specifications_FurnitureId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Specifications_Value",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "BaseEntities");
        }
    }
}
