using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureCatalog.Persistence.Migrations
{
    public partial class mig_CategoryCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ParentId",
                table: "BaseEntities",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ParentId",
                table: "BaseEntities",
                column: "ParentId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ParentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ParentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "BaseEntities");
        }
    }
}
