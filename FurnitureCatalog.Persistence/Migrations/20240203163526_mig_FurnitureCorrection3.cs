using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureCatalog.Persistence.Migrations
{
    public partial class mig_FurnitureCorrection3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SpecificationId",
                table: "BaseEntities");

            migrationBuilder.RenameColumn(
                name: "SpecificationId",
                table: "BaseEntities",
                newName: "FurnitureId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntities_SpecificationId",
                table: "BaseEntities",
                newName: "IX_BaseEntities_FurnitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_FurnitureId",
                table: "BaseEntities",
                column: "FurnitureId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_FurnitureId",
                table: "BaseEntities");

            migrationBuilder.RenameColumn(
                name: "FurnitureId",
                table: "BaseEntities",
                newName: "SpecificationId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntities_FurnitureId",
                table: "BaseEntities",
                newName: "IX_BaseEntities_SpecificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SpecificationId",
                table: "BaseEntities",
                column: "SpecificationId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
