using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obl_Prog_3.Migrations
{
    /// <inheritdoc />
    public partial class CreacionAdministrativosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroTrabajador",
                table: "Personas",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroTrabajador",
                table: "Personas");
        }
    }
}
