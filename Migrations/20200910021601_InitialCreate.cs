using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: false),
                    nac = table.Column<DateTime>(nullable: false),
                    contraseña = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    pais = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Paritda",
                columns: table => new
                {
                    IdPartida = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(nullable: false),
                    UsuarioIdUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paritda", x => x.IdPartida);
                    table.ForeignKey(
                        name: "FK_Paritda_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    IdPartida = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ruta = table.Column<string>(nullable: true),
                    PartidaIdPartida = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.IdPartida);
                    table.ForeignKey(
                        name: "FK_Ruta_Paritda_PartidaIdPartida",
                        column: x => x.PartidaIdPartida,
                        principalTable: "Paritda",
                        principalColumn: "IdPartida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paritda_UsuarioIdUsuario",
                table: "Paritda",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Ruta_PartidaIdPartida",
                table: "Ruta",
                column: "PartidaIdPartida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ruta");

            migrationBuilder.DropTable(
                name: "Paritda");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
