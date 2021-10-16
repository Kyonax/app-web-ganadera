using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class Inicial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Users_AssignedVetId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Users_RancherId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Herds_Farms_FarmId",
                table: "Herds");

            migrationBuilder.DropForeignKey(
                name: "FK_Pathologies_Specimens_SpecimenId",
                table: "Pathologies");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimens_Herds_HerdId",
                table: "Specimens");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccines_Specimens_SpecimenId",
                table: "Vaccines");

            migrationBuilder.DropIndex(
                name: "IX_Vaccines_SpecimenId",
                table: "Vaccines");

            migrationBuilder.DropIndex(
                name: "IX_Specimens_HerdId",
                table: "Specimens");

            migrationBuilder.DropIndex(
                name: "IX_Pathologies_SpecimenId",
                table: "Pathologies");

            migrationBuilder.DropIndex(
                name: "IX_Herds_FarmId",
                table: "Herds");

            migrationBuilder.DropIndex(
                name: "IX_Farms_AssignedVetId",
                table: "Farms");

            migrationBuilder.DropIndex(
                name: "IX_Farms_RancherId",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "SpecimenId",
                table: "Vaccines");

            migrationBuilder.DropColumn(
                name: "HerdId",
                table: "Specimens");

            migrationBuilder.DropColumn(
                name: "SpecimenId",
                table: "Pathologies");

            migrationBuilder.DropColumn(
                name: "FarmId",
                table: "Herds");

            migrationBuilder.DropColumn(
                name: "AssignedVetId",
                table: "Farms");

            migrationBuilder.DropColumn(
                name: "RancherId",
                table: "Farms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecimenId",
                table: "Vaccines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HerdId",
                table: "Specimens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecimenId",
                table: "Pathologies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FarmId",
                table: "Herds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignedVetId",
                table: "Farms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RancherId",
                table: "Farms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_SpecimenId",
                table: "Vaccines",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_HerdId",
                table: "Specimens",
                column: "HerdId");

            migrationBuilder.CreateIndex(
                name: "IX_Pathologies_SpecimenId",
                table: "Pathologies",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_Herds_FarmId",
                table: "Herds",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_AssignedVetId",
                table: "Farms",
                column: "AssignedVetId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_RancherId",
                table: "Farms",
                column: "RancherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Users_AssignedVetId",
                table: "Farms",
                column: "AssignedVetId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Users_RancherId",
                table: "Farms",
                column: "RancherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Herds_Farms_FarmId",
                table: "Herds",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pathologies_Specimens_SpecimenId",
                table: "Pathologies",
                column: "SpecimenId",
                principalTable: "Specimens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specimens_Herds_HerdId",
                table: "Specimens",
                column: "HerdId",
                principalTable: "Herds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_Specimens_SpecimenId",
                table: "Vaccines",
                column: "SpecimenId",
                principalTable: "Specimens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
