using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto1.Migrations
{
    public partial class partidas : Migration
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
                    contraseña = table.Column<string>(maxLength: 8, nullable: false),
                    email = table.Column<string>(nullable: false),
                    pais = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    IdPartida = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(nullable: false),
                    numTurnos = table.Column<int>(nullable: false),
                    resultado = table.Column<string>(nullable: false),
                    adversario = table.Column<string>(nullable: false),
                    UsuarioIdUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.IdPartida);
                    table.ForeignKey(
                        name: "FK_Partida_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partida_UsuarioIdUsuario",
                table: "Partida",
                column: "UsuarioIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
