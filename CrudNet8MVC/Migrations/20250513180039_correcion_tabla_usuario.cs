using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudNet8MVC.Migrations
{
    /// <inheritdoc />
    public partial class correcion_tabla_usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "usuario",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "usuario",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "usuario",
                newName: "dni");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "usuario",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "usuario",
                newName: "fecha_creacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "usuario",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "usuario",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "dni",
                table: "usuario",
                newName: "DNI");

            migrationBuilder.RenameColumn(
                name: "correo",
                table: "usuario",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "usuario",
                newName: "FechaCreacion");
        }
    }
}
