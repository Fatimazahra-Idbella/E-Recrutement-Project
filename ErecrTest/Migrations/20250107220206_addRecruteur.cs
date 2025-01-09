using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ErecrTest.Migrations
{
    /// <inheritdoc />
    public partial class addRecruteur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recruteurs",
                columns: new[] { "Id", "Email", "Nom", "Tel" },
                values: new object[,]
                {
                    { 1, "fatiezzahra@gmail.com", "venus", "123456789" },
                    { 2, "mrsomebody@gmail.com", "Mr Somebody", "987654321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recruteurs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
