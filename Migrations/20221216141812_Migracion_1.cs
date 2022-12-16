using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_3.Migrations
{
    public partial class Migracion_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_identificacion = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono_1 = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Telefono_2 = table.Column<int>(type: "int", maxLength: 10, nullable: true),
                    Correo_electronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
