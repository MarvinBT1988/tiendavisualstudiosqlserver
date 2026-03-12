using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tienda.AppMVC.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarComentario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "Categorias");
        }
    }
}
