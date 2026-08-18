using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visibilidad",
                table: "TM_CONTENIDO");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TR_CUENTAS_SEGUIDORES",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TR_CONTENIDO_CUENTAS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Mod",
                table: "TM_USUARIOS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Baja",
                table: "TM_USUARIOS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TM_USUARIOS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Mod",
                table: "TM_CUENTAS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Baja",
                table: "TM_CUENTAS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TM_CUENTAS",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TM_CONTENIDO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Id_Visibilidad",
                table: "TM_CONTENIDO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VisibilidadId",
                table: "TM_CONTENIDO",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_VisibilidadId",
                table: "TM_CONTENIDO",
                column: "VisibilidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_VisibilidadId",
                table: "TM_CONTENIDO",
                column: "VisibilidadId",
                principalTable: "TM_TIPOS_DE_VISIBILIDAD",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_VisibilidadId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropTable(
                name: "TM_TIPOS_DE_VISIBILIDAD");

            migrationBuilder.DropIndex(
                name: "IX_TM_CONTENIDO_VisibilidadId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropColumn(
                name: "Id_Visibilidad",
                table: "TM_CONTENIDO");

            migrationBuilder.DropColumn(
                name: "VisibilidadId",
                table: "TM_CONTENIDO");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TR_CUENTAS_SEGUIDORES",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TR_CONTENIDO_CUENTAS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Mod",
                table: "TM_USUARIOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Baja",
                table: "TM_USUARIOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TM_USUARIOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Mod",
                table: "TM_CUENTAS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Baja",
                table: "TM_CUENTAS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TM_CUENTAS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Alta",
                table: "TM_CONTENIDO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Visibilidad",
                table: "TM_CONTENIDO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
