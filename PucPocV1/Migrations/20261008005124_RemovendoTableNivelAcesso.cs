using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PucPocV1.Migrations
{
    /// <inheritdoc />
    public partial class RemovendoTableNivelAcesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_NivelAcesso_ID_Nivel_Acesso",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "NivelAcesso");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ID_Nivel_Acesso",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "ID_Nivel_Acesso",
                table: "Usuario",
                newName: "NivelAcesso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NivelAcesso",
                table: "Usuario",
                newName: "ID_Nivel_Acesso");

            migrationBuilder.CreateTable(
                name: "NivelAcesso",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelAcesso", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "NivelAcesso",
                columns: new[] { "ID", "Descricao" },
                values: new object[,]
                {
                    { 1, "Mentorado" },
                    { 2, "Mentor" },
                    { 3, "Administrador" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ID_Nivel_Acesso",
                table: "Usuario",
                column: "ID_Nivel_Acesso");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_NivelAcesso_ID_Nivel_Acesso",
                table: "Usuario",
                column: "ID_Nivel_Acesso",
                principalTable: "NivelAcesso",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
