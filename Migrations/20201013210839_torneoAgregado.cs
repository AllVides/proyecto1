using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto1.Migrations
{
    public partial class torneoAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Usuario_UsuarioIdUsuario",
                table: "Partida");

            migrationBuilder.DropIndex(
                name: "IX_Partida_UsuarioIdUsuario",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Partida");

            migrationBuilder.CreateTable(
                name: "Torneo",
                columns: table => new
                {
                    IdTorneo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    tamaño = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneo", x => x.IdTorneo);
                });

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false),
                    IdTorneo = table.Column<int>(nullable: false),
                    posicion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante", x => new { x.IdUsuario, x.IdTorneo });
                    table.ForeignKey(
                        name: "FK_Participante_Torneo_IdTorneo",
                        column: x => x.IdTorneo,
                        principalTable: "Torneo",
                        principalColumn: "IdTorneo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participante_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partida_IdUsuario",
                table: "Partida",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_IdTorneo",
                table: "Participante",
                column: "IdTorneo");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Usuario_IdUsuario",
                table: "Partida",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Usuario_IdUsuario",
                table: "Partida");

            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.DropTable(
                name: "Torneo");

            migrationBuilder.DropIndex(
                name: "IX_Partida_IdUsuario",
                table: "Partida");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Partida",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partida_UsuarioIdUsuario",
                table: "Partida",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Usuario_UsuarioIdUsuario",
                table: "Partida",
                column: "UsuarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
