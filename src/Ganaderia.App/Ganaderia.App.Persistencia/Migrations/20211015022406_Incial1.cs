using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class Incial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FarmId",
                table: "Herds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Herds_FarmId",
                table: "Herds",
                column: "FarmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Herds_Farms_FarmId",
                table: "Herds",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herds_Farms_FarmId",
                table: "Herds");

            migrationBuilder.DropIndex(
                name: "IX_Herds_FarmId",
                table: "Herds");

            migrationBuilder.DropColumn(
                name: "FarmId",
                table: "Herds");
        }
    }
}
