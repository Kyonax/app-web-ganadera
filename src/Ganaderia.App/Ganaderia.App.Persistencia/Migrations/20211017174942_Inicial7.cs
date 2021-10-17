using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class Inicial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pathologies",
                table: "Pathologies");

            migrationBuilder.RenameTable(
                name: "Pathologies",
                newName: "Pathology");

            migrationBuilder.AddColumn<bool>(
                name: "KeepCool",
                table: "Vaccines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pathology",
                table: "Pathology",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pathology",
                table: "Pathology");

            migrationBuilder.DropColumn(
                name: "KeepCool",
                table: "Vaccines");

            migrationBuilder.RenameTable(
                name: "Pathology",
                newName: "Pathologies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pathologies",
                table: "Pathologies",
                column: "Id");
        }
    }
}
