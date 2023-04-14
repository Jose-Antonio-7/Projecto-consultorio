using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.infraestructura.SqlServer.Migrations
{
    public partial class migracionManual20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    DireccionCliente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin direccion"),
                    TelefonoCliente = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false, defaultValue: "Sin numero"),
                    NombreCliente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin nombre"),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin apellido")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CedulaDoctor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin cedula"),
                    TelefonoDoctor = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false, defaultValue: "Sin numero"),
                    NombreDoctor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin nombre"),
                    ApellidoDoctor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin apellido")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin login"),
                    ContraseñaUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin Contraseña")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DireccionConsulta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Sin direccion"),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClienteId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Doctores_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_ClienteId",
                table: "Consultas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_DoctorId",
                table: "Consultas",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Doctores");
        }
    }
}
