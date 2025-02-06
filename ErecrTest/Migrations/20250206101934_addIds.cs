using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErecrTest.Migrations
{
    /// <inheritdoc />
    public partial class addIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recruteurs",
                newName: "RecruteurId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Offres",
                newName: "OffreId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Candidat",
                newName: "CandidatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecruteurId",
                table: "Recruteurs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OffreId",
                table: "Offres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CandidatId",
                table: "Candidat",
                newName: "Id");
        }
    }
}
