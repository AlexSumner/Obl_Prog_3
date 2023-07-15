using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obl_Prog_3.Migrations
{
    /// <inheritdoc />
    public partial class CreacionUsuarioTableDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");
        }
    }
}
