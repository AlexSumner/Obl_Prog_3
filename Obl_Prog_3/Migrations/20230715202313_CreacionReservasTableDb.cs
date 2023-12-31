﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obl_Prog_3.Migrations
{
    /// <inheritdoc />
    public partial class CreacionReservasTableDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionId = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    Asientos = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservas_Personas_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_FuncionId",
                table: "Reservas",
                column: "FuncionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
