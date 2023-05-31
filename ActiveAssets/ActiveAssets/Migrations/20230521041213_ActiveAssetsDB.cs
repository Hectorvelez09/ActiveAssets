using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActiveAssets.Migrations
{
    /// <inheritdoc />
    public partial class ActiveAssetsDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cedula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecioAlquiler = table.Column<double>(type: "float", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantHabitaciones = table.Column<int>(type: "int", nullable: false),
                    CantBathrooms = table.Column<int>(type: "int", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    IdTipoInmueble = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CedulaPropietario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    Cedula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesCompraArriendo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdInmueble = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CedulaCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesCompraArriendo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelefonosClientes",
                columns: table => new
                {
                    CedulaCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonosClientes", x => x.CedulaCliente);
                });

            migrationBuilder.CreateTable(
                name: "TelefonosPropietarios",
                columns: table => new
                {
                    CedulaPropietario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonosPropietarios", x => x.CedulaPropietario);
                });

            migrationBuilder.CreateTable(
                name: "TiposInmuebles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposInmuebles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Cedula",
                table: "Clientes",
                column: "Cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_Id",
                table: "Inmuebles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Propietarios_Cedula",
                table: "Propietarios",
                column: "Cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesCompraArriendo_Id",
                table: "SolicitudesCompraArriendo",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefonosClientes_CedulaCliente",
                table: "TelefonosClientes",
                column: "CedulaCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefonosPropietarios_CedulaPropietario",
                table: "TelefonosPropietarios",
                column: "CedulaPropietario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposInmuebles_Id",
                table: "TiposInmuebles",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "SolicitudesCompraArriendo");

            migrationBuilder.DropTable(
                name: "TelefonosClientes");

            migrationBuilder.DropTable(
                name: "TelefonosPropietarios");

            migrationBuilder.DropTable(
                name: "TiposInmuebles");
        }
    }
}
