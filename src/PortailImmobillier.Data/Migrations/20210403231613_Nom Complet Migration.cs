using Microsoft.EntityFrameworkCore.Migrations;

namespace PortailImmobillier.Data.Migrations
{
    public partial class NomCompletMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomComplet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomComplet",
                table: "AspNetUsers");
        }
    }
}
