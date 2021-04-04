using Microsoft.EntityFrameworkCore.Migrations;

namespace PortailImmobillier.Data.Migrations.ApplicationDb
{
    public partial class AddedcolumnstoAnnonceEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Annonces",
                newName: "Titre");

            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Annonces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Chambres",
                table: "Annonces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactPhoneNumber",
                table: "Annonces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Annonces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Annonces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Prix",
                table: "Annonces",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Toilettes",
                table: "Annonces",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Annonces");

            migrationBuilder.DropColumn(
                name: "Chambres",
                table: "Annonces");

            migrationBuilder.DropColumn(
                name: "ContactPhoneNumber",
                table: "Annonces");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Annonces");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Annonces");

            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Annonces");

            migrationBuilder.DropColumn(
                name: "Toilettes",
                table: "Annonces");

            migrationBuilder.RenameColumn(
                name: "Titre",
                table: "Annonces",
                newName: "Title");
        }
    }
}
