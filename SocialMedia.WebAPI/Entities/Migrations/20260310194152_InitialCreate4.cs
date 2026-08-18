using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TM_CONTENIDO",
                columns: new[] { "Id", "CuentaId", "Descripcion", "Fecha_Alta", "Id_Cuenta", "Id_Visibilidad", "Media", "Titulo", "VisibilidadId" },
                values: new object[,]
                {
                    { 1, null, "descripcion descripcion descripcion", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2170), 2, 2, "foto6.png", "Hello.", null },
                    { 2, null, "Self explanatory", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2173), 3, 1, "foto7.png", "Beach", null },
                    { 3, null, "Can you read this?", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2174), 4, 3, "foto8.png", "Help", null },
                    { 4, null, "Doesn't need explaining", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2176), 3, 1, "foto8.png", "Forest", null }
                });

            migrationBuilder.InsertData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                columns: new[] { "Id", "Fecha_Alta", "Fecha_Baja", "Fecha_Mod", "Tipo_De_Visibilidad" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2161), null, null, "Publico" },
                    { 2, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2163), null, null, "Privado" },
                    { 3, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2165), null, null, "Oculto" }
                });

            migrationBuilder.InsertData(
                table: "TM_USUARIOS",
                columns: new[] { "Id", "Contrasena", "Correo", "Descripcion", "Fecha_Alta", "Fecha_Baja", "Fecha_Mod" },
                values: new object[,]
                {
                    { 1, "123321", "ejemplo@gmail.com", "Hola mundo", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2069), null, null },
                    { 2, "Contrasena", "abc@gmail.com", "cba", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2133), null, null },
                    { 3, "Hi!", "hello@gmail.com", "soy usuario num.3", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2136), null, null },
                    { 4, "######", "user@gmail.com", "##### ### ####", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2138), null, null }
                });

            migrationBuilder.InsertData(
                table: "TR_CONTENIDO_CUENTAS",
                columns: new[] { "Id", "ContenidoId", "CuentaId", "Fecha_Alta", "Id_Contenido", "Id_Cuenta" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2179), 1, 2 },
                    { 2, null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2181), 2, 3 },
                    { 3, null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2183), 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "TR_CUENTAS_SEGUIDORES",
                columns: new[] { "Id", "CuentaId", "Cuenta_SeguidaId", "Fecha_Alta", "Id_Cuenta", "Id_Cuenta_Seguida" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2187), 1, 3 },
                    { 2, null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2190), 2, 3 },
                    { 3, null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2192), 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "TM_CUENTAS",
                columns: new[] { "Id", "Bio", "Contrasena", "Fecha_Alta", "Fecha_Baja", "Fecha_Mod", "Foto", "Nombre_Cuenta", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Cuenta n.1", "IAmJuan", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2141), null, null, "foto1.png", "Juan", 1 },
                    { 2, "Bla bla bla", "pepe", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2146), null, null, "foto2.png", "Pepe", 2 },
                    { 3, ".", ".", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2148), null, null, "foto3.png", "Trevor", 3 },
                    { 4, "Afton", "Help", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2157), null, null, "foto4.png", "William", 4 },
                    { 5, "The Mimic", "...", new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2159), null, null, "foto5.png", "Mimic", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
