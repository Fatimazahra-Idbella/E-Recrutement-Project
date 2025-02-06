using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ErecrTest.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidature_Candidat_CandidatId",
                table: "Candidature");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidature_Offres_OffreId",
                table: "Candidature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidature",
                table: "Candidature");

            migrationBuilder.RenameTable(
                name: "Candidature",
                newName: "Candidatures");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Candidatures",
                newName: "CandidatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidature_OffreId",
                table: "Candidatures",
                newName: "IX_Candidatures_OffreId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidature_CandidatId",
                table: "Candidatures",
                newName: "IX_Candidatures_CandidatId");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Candidat",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Candidatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidatures",
                table: "Candidatures",
                column: "CandidatureId");

            migrationBuilder.InsertData(
                table: "Candidat",
                columns: new[] { "CandidatId", "Age", "AnneeExperience", "CV", "Diplome", "Nom", "Prenom", "Titre" },
                values: new object[,]
                {
                    { 1, 25, 4, "ahmed_benhami_cv.pdf", "Engineering degree in Computer Science", "Ahmed", "Benhami", "Software Engineer" },
                    { 2, 28, 5, "leila_mouhssine_cv.pdf", "Master in GIS", "Leila", "Mouhssine", "Surveyor" },
                    { 3, 32, 8, "omar_berrada_cv.pdf", "Engineering degree in Civil Engineering", "Omar", "Berrada", "Civil Engineer" },
                    { 4, 24, 3, "fatima_zahra_cv.pdf", "Bachelor in Web Design", "Fatima", "Zahra", "Graphic Designer" },
                    { 5, 26, 5, "mariam_alaoui_cv.pdf", "Bachelor in Web Design", "Mariam", "Alaoui", "Graphic Designer" }
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "OffreId", "Poste", "Profil", "RecruteurId", "Remuneration", "Secteur", "TypeContrat" },
                values: new object[,]
                {
                    { 1, "GIS Data Analyst", "Engineer", 1, 20500m, "Public", "Permanent" },
                    { 2, "Software Engineer", "Engineer + 3 years of experience", 2, 21500m, "Private", "Permanent" },
                    { 6, "Geomatician Surveyor", "Master in GIS", 1, 10000m, "Public", "Permanent" }
                });

            migrationBuilder.UpdateData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 1,
                columns: new[] { "Email", "Nom", "Tel" },
                values: new object[] { "khalid.elidrissi.auc@gmail.com", "Khalid El Idrissi", "0788912500" });

            migrationBuilder.UpdateData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 2,
                columns: new[] { "Email", "Nom", "Tel" },
                values: new object[] { "sara.bensaid.maroctelecom@gmail.com", "Sara Bensaid", "0633597601" });

            migrationBuilder.InsertData(
                table: "Recruteurs",
                columns: new[] { "RecruteurId", "Email", "Nom", "Tel" },
                values: new object[,]
                {
                    { 3, "hassan.amrani.tgcc@gmail.com", "Hassan Amrani", "0635954768" },
                    { 4, "nadia.tazi.onee@gmail.com", "Nadia Tazi", "0622062209" },
                    { 5, "mehdi.benjelloun.sopriam@gmail.com", "Mehdi Benjelloun", "0694587512" },
                    { 6, "amina.ouhibi.lyautey@gmail.com", "Amina Ouhibi", "0621548781" },
                    { 7, "youssef.elfassi.digismart@gmail.com", "Youssef Elfassi", "0643957159" },
                    { 8, "rachid.alaoui.um6p@gmail.com", "Rachid Alaoui", "0781659872" }
                });

            migrationBuilder.InsertData(
                table: "Candidatures",
                columns: new[] { "CandidatureId", "CandidatId", "DatePostulation", "OffreId", "State" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pending" },
                    { 2, 2, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "OffreId", "Poste", "Profil", "RecruteurId", "Remuneration", "Secteur", "TypeContrat" },
                values: new object[,]
                {
                    { 3, "Machine Learning Engineer", "Engineer", 8, 22000m, "Private", "Permanent" },
                    { 4, "Civil Engineer", "Engineer", 3, 10500m, "Private", "Permanent" },
                    { 5, "Electrical Engineer", "Engineer", 4, 15500m, "Private", "Permanent" },
                    { 7, "Social Media Manager", "Bachelor + 3 years of experience", 5, 8000m, "Private", "Permanent" },
                    { 8, "Highschool English Teacher", "Bachelor in English", 6, 6000m, "Private", "Permanent" },
                    { 9, "Web Designer", "Bachelor in Web Design", 7, 8000m, "Private", "Temporary" }
                });

            migrationBuilder.InsertData(
                table: "Candidatures",
                columns: new[] { "CandidatureId", "CandidatId", "DatePostulation", "OffreId", "State" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Accepted" },
                    { 4, 4, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Rejected" },
                    { 5, 5, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Accepted" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidat_Nom",
                table: "Candidat",
                column: "Nom");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatures_Candidat_CandidatId",
                table: "Candidatures",
                column: "CandidatId",
                principalTable: "Candidat",
                principalColumn: "CandidatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatures_Offres_OffreId",
                table: "Candidatures",
                column: "OffreId",
                principalTable: "Offres",
                principalColumn: "OffreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatures_Candidat_CandidatId",
                table: "Candidatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidatures_Offres_OffreId",
                table: "Candidatures");

            migrationBuilder.DropIndex(
                name: "IX_Candidat_Nom",
                table: "Candidat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidatures",
                table: "Candidatures");

            migrationBuilder.DeleteData(
                table: "Candidatures",
                keyColumn: "CandidatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidatures",
                keyColumn: "CandidatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candidatures",
                keyColumn: "CandidatureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candidatures",
                keyColumn: "CandidatureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candidatures",
                keyColumn: "CandidatureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candidat",
                keyColumn: "CandidatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidat",
                keyColumn: "CandidatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candidat",
                keyColumn: "CandidatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candidat",
                keyColumn: "CandidatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candidat",
                keyColumn: "CandidatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "OffreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "State",
                table: "Candidatures");

            migrationBuilder.RenameTable(
                name: "Candidatures",
                newName: "Candidature");

            migrationBuilder.RenameColumn(
                name: "CandidatureId",
                table: "Candidature",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Candidatures_OffreId",
                table: "Candidature",
                newName: "IX_Candidature_OffreId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidatures_CandidatId",
                table: "Candidature",
                newName: "IX_Candidature_CandidatId");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Candidat",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidature",
                table: "Candidature",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 1,
                columns: new[] { "Email", "Nom", "Tel" },
                values: new object[] { "fatiezzahra@gmail.com", "venus", "123456789" });

            migrationBuilder.UpdateData(
                table: "Recruteurs",
                keyColumn: "RecruteurId",
                keyValue: 2,
                columns: new[] { "Email", "Nom", "Tel" },
                values: new object[] { "mrsomebody@gmail.com", "Mr Somebody", "987654321" });

            migrationBuilder.AddForeignKey(
                name: "FK_Candidature_Candidat_CandidatId",
                table: "Candidature",
                column: "CandidatId",
                principalTable: "Candidat",
                principalColumn: "CandidatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidature_Offres_OffreId",
                table: "Candidature",
                column: "OffreId",
                principalTable: "Offres",
                principalColumn: "OffreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
