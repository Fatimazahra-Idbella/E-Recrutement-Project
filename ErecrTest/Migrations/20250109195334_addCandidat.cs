using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErecrTest.Migrations
{
    /// <inheritdoc />
    public partial class addCandidat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diplome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnneeExperience = table.Column<int>(type: "int", nullable: false),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidature_CandidatId",
                table: "Candidature",
                column: "CandidatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidature_Candidat_CandidatId",
                table: "Candidature",
                column: "CandidatId",
                principalTable: "Candidat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidature_Candidat_CandidatId",
                table: "Candidature");

            migrationBuilder.DropTable(
                name: "Candidat");

            migrationBuilder.DropIndex(
                name: "IX_Candidature_CandidatId",
                table: "Candidature");
        }
    }
}
