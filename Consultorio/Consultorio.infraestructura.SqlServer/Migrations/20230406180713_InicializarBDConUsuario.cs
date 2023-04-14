using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.infraestructura.SqlServer.Migrations
{
    public partial class InicializarBDConUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropTable(
                name: "Users");

            
        }
    }
}
