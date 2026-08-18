using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TM_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Baja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Mod = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_USUARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TM_CUENTAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Baja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Mod = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_CUENTAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TM_CUENTAS_TM_USUARIOS_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TM_USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TM_CONTENIDO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuentaId = table.Column<int>(type: "int", nullable: true),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_CONTENIDO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TM_CONTENIDO_TM_CUENTAS_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TR_CUENTAS_SEGUIDORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuentaId = table.Column<int>(type: "int", nullable: true),
                    Id_Cuenta_Seguida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuenta_SeguidaId = table.Column<int>(type: "int", nullable: true),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_CUENTAS_SEGUIDORES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Cuenta_SeguidaId",
                        column: x => x.Cuenta_SeguidaId,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TR_CONTENIDO_CUENTAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContenidoId = table.Column<int>(type: "int", nullable: true),
                    Id_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuentaId = table.Column<int>(type: "int", nullable: true),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_CONTENIDO_CUENTAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TR_CONTENIDO_CUENTAS_TM_CONTENIDO_ContenidoId",
                        column: x => x.ContenidoId,
                        principalTable: "TM_CONTENIDO",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TR_CONTENIDO_CUENTAS_TM_CUENTAS_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_CuentaId",
                table: "TM_CONTENIDO",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CUENTAS_UsuarioId",
                table: "TM_CUENTAS",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_ContenidoId",
                table: "TR_CONTENIDO_CUENTAS",
                column: "ContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_CuentaId",
                table: "TR_CONTENIDO_CUENTAS",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Cuenta_SeguidaId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_CuentaId",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "CuentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropTable(
                name: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropTable(
                name: "TM_CONTENIDO");

            migrationBuilder.DropTable(
                name: "TM_CUENTAS");

            migrationBuilder.DropTable(
                name: "TM_USUARIOS");
        }
    }
}
