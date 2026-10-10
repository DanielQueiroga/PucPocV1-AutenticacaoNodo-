using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PucPocV1.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarAreasETecnologias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AreaConhecimento",
                columns: new[] { "ID", "Nome" },
                values: new object[,]
                {
                    { 1, "Desenvolvimento Web" },
                    { 2, "Banco de Dados" },
                    { 3, "Desenvolvimento Mobile" },
                    { 4, "Inteligência Artificial" },
                    { 5, "Segurança da Informação" }
                });

            migrationBuilder.InsertData(
                table: "Tecnologia",
                columns: new[] { "ID", "Nome" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Java" },
                    { 3, "JavaScript" },
                    { 4, "Python" },
                    { 5, "SQL Server" },
                    { 6, "ASP.NET Core" },
                    { 7, "React" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaConhecimento",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AreaConhecimento",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AreaConhecimento",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AreaConhecimento",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AreaConhecimento",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tecnologia",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}
