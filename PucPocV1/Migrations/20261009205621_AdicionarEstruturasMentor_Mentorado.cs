using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PucPocV1.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarEstruturasMentor_Mentorado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaConhecimento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaConhecimento", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mentor_Usuario_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mentorado",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorado", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mentorado_Usuario_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MentorAreaConhecimento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Mentor = table.Column<int>(type: "int", nullable: false),
                    ID_AreaConhecimento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorAreaConhecimento", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MentorAreaConhecimento_AreaConhecimento_ID_AreaConhecimento",
                        column: x => x.ID_AreaConhecimento,
                        principalTable: "AreaConhecimento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentorAreaConhecimento_Mentor_ID_Mentor",
                        column: x => x.ID_Mentor,
                        principalTable: "Mentor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentorTecnologia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Mentor = table.Column<int>(type: "int", nullable: false),
                    ID_Tecnologia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorTecnologia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MentorTecnologia_Mentor_ID_Mentor",
                        column: x => x.ID_Mentor,
                        principalTable: "Mentor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentorTecnologia_Tecnologia_ID_Tecnologia",
                        column: x => x.ID_Tecnologia,
                        principalTable: "Tecnologia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_ID_Usuario",
                table: "Mentor",
                column: "ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorado_ID_Usuario",
                table: "Mentorado",
                column: "ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_MentorAreaConhecimento_ID_AreaConhecimento",
                table: "MentorAreaConhecimento",
                column: "ID_AreaConhecimento");

            migrationBuilder.CreateIndex(
                name: "IX_MentorAreaConhecimento_ID_Mentor",
                table: "MentorAreaConhecimento",
                column: "ID_Mentor");

            migrationBuilder.CreateIndex(
                name: "IX_MentorTecnologia_ID_Mentor",
                table: "MentorTecnologia",
                column: "ID_Mentor");

            migrationBuilder.CreateIndex(
                name: "IX_MentorTecnologia_ID_Tecnologia",
                table: "MentorTecnologia",
                column: "ID_Tecnologia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentorado");

            migrationBuilder.DropTable(
                name: "MentorAreaConhecimento");

            migrationBuilder.DropTable(
                name: "MentorTecnologia");

            migrationBuilder.DropTable(
                name: "AreaConhecimento");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "Tecnologia");
        }
    }
}
