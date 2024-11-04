using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureCatalog.Persistence.Migrations
{
    public partial class mig_FurnitureCorrection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Furnitures_CategoryId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Furnitures_CategoryId",
                table: "BaseEntities",
                column: "Furnitures_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Furnitures_CategoryId",
                table: "BaseEntities",
                column: "Furnitures_CategoryId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Furnitures_CategoryId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Furnitures_CategoryId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Furnitures_CategoryId",
                table: "BaseEntities");
        }
    }
}
