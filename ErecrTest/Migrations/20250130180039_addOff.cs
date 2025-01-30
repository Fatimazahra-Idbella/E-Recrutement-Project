using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ErecrTest.Migrations
{
    /// <inheritdoc />
    public partial class addOff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "Id", "Poste", "Profil", "RecruteurId", "Remuneration", "Secteur", "TypeContrat" },
                values: new object[,]
                {
                    { 1, "Software Developer", "Engineer", 0, 50000m, "IT", "CDI" },
                    { 2, "Financial Analyst", "Master", 0, 40000m, "Finance", "CDD" },
                    { 3, "Marketing Manager", "Licence", 0, 45000m, "Marketing", "CDI" },
                    { 4, "HR Specialist", "Master", 0, 42000m, "HR", "CDD" },
                    { 5, "Mechanical Engineer", "Engineer", 0, 55000m, "Engineering", "CDI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
