using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PucPocV1.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNiveisAcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NivelAcesso",
                columns: new[] { "ID", "Descricao" },
                values: new object[,]
                {
                    { 1, "Mentorado" },
                    { 2, "Mentor" },
                    { 3, "Administrador" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NivelAcesso",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NivelAcesso",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NivelAcesso",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
