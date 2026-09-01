using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TM_TIPOS_DE_VISIBILIDAD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_De_Visibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Baja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Mod = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_TIPOS_DE_VISIBILIDAD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TM_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Baja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Mod = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Baja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Mod = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id_Visibilidad = table.Column<int>(type: "int", nullable: false),
                    Id_Cuenta = table.Column<int>(type: "int", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_CONTENIDO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TM_CONTENIDO_TM_CUENTAS_Id_Cuenta",
                        column: x => x.Id_Cuenta,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_Id_Visibilidad",
                        column: x => x.Id_Visibilidad,
                        principalTable: "TM_TIPOS_DE_VISIBILIDAD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TR_CUENTAS_SEGUIDORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cuenta = table.Column<int>(type: "int", nullable: false),
                    Id_Cuenta_Seguida = table.Column<int>(type: "int", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_CUENTAS_SEGUIDORES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Id_Cuenta",
                        column: x => x.Id_Cuenta,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Id_Cuenta_Seguida",
                        column: x => x.Id_Cuenta_Seguida,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TR_CONTENIDO_CUENTAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Contenido = table.Column<int>(type: "int", nullable: false),
                    Id_Cuenta = table.Column<int>(type: "int", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR_CONTENIDO_CUENTAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TR_CONTENIDO_CUENTAS_TM_CONTENIDO_Id_Contenido",
                        column: x => x.Id_Contenido,
                        principalTable: "TM_CONTENIDO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TR_CONTENIDO_CUENTAS_TM_CUENTAS_Id_Cuenta",
                        column: x => x.Id_Cuenta,
                        principalTable: "TM_CUENTAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                columns: new[] { "Id", "Fecha_Alta", "Fecha_Baja", "Fecha_Mod", "Tipo_De_Visibilidad" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4389), null, null, "Publico" },
                    { 2, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4391), null, null, "Privado" },
                    { 3, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4393), null, null, "Oculto" }
                });

            migrationBuilder.InsertData(
                table: "TM_USUARIOS",
                columns: new[] { "Id", "Contrasena", "Correo", "Descripcion", "Fecha_Alta", "Fecha_Baja", "Fecha_Mod" },
                values: new object[,]
                {
                    { 1, "123321", "ejemplo@gmail.com", "Hola mundo", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4316), null, null },
                    { 2, "Contrasena", "abc@gmail.com", "cba", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4365), null, null },
                    { 3, "Hi!", "hello@gmail.com", "soy usuario num.3", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4369), null, null },
                    { 4, "######", "user@gmail.com", "##### ### ####", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4372), null, null }
                });

            migrationBuilder.InsertData(
                table: "TM_CUENTAS",
                columns: new[] { "Id", "Bio", "Contrasena", "Fecha_Alta", "Fecha_Baja", "Fecha_Mod", "Foto", "Nombre_Cuenta", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Cuenta n.1", "IAmJuan", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4376), null, null, "foto1.png", "Juan", 1 },
                    { 2, "Bla bla bla", "pepe", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4379), null, null, "foto2.png", "Pepe", 2 },
                    { 3, ".", ".", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4382), null, null, "foto3.png", "Trevor", 3 },
                    { 4, "Afton", "Help", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4384), null, null, "foto4.png", "William", 4 },
                    { 5, "The Mimic", "...", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4386), null, null, "foto5.png", "Mimic", 4 }
                });

            migrationBuilder.InsertData(
                table: "TM_CONTENIDO",
                columns: new[] { "Id", "Descripcion", "Fecha_Alta", "Id_Cuenta", "Id_Visibilidad", "Media", "Titulo" },
                values: new object[,]
                {
                    { 1, "descripcion descripcion descripcion", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4398), 2, 2, "foto6.png", "Hello." },
                    { 2, "Self explanatory", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4400), 3, 1, "foto7.png", "Beach" },
                    { 3, "Can you read this?", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4403), 4, 3, "foto8.png", "Help" },
                    { 4, "Doesn't need explaining", new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4405), 3, 1, "foto8.png", "Forest" }
                });

            migrationBuilder.InsertData(
                table: "TR_CUENTAS_SEGUIDORES",
                columns: new[] { "Id", "Fecha_Alta", "Id_Cuenta", "Id_Cuenta_Seguida" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4416), 1, 3 },
                    { 2, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4418), 2, 3 },
                    { 3, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4420), 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "TR_CONTENIDO_CUENTAS",
                columns: new[] { "Id", "Fecha_Alta", "Id_Contenido", "Id_Cuenta" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4407), 1, 2 },
                    { 2, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4410), 2, 3 },
                    { 3, new DateTime(2026, 9, 1, 18, 30, 25, 316, DateTimeKind.Local).AddTicks(4412), 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_Id_Cuenta",
                table: "TM_CONTENIDO",
                column: "Id_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_Id_Visibilidad",
                table: "TM_CONTENIDO",
                column: "Id_Visibilidad");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CUENTAS_UsuarioId",
                table: "TM_CUENTAS",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_Id_Contenido",
                table: "TR_CONTENIDO_CUENTAS",
                column: "Id_Contenido");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_Id_Cuenta",
                table: "TR_CONTENIDO_CUENTAS",
                column: "Id_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Id_Cuenta",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Id_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Id_Cuenta_Seguida",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Id_Cuenta_Seguida");
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
                name: "TM_TIPOS_DE_VISIBILIDAD");

            migrationBuilder.DropTable(
                name: "TM_USUARIOS");
        }
    }
}
