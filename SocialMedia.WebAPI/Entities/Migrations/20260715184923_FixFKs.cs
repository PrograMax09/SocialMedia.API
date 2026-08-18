using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class FixFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TM_CONTENIDO_TM_CUENTAS_CuentaId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_VisibilidadId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CONTENIDO_ContenidoId",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CUENTAS_CuentaId",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_CuentaId",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES");
            
            migrationBuilder.DropIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_CuentaId",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_ContenidoId",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_CuentaId",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropIndex(
                name: "IX_TM_CONTENIDO_CuentaId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropIndex(
                name: "IX_TM_CONTENIDO_VisibilidadId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropColumn(
                name: "CuentaId",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropColumn(
                name: "Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropColumn(
                name: "ContenidoId",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropColumn(
                name: "CuentaId",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropColumn(
                name: "CuentaId",
                table: "TM_CONTENIDO");

            migrationBuilder.DropColumn(
                name: "VisibilidadId",
                table: "TM_CONTENIDO");

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 7, 15, 19, 49, 22, 658, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Id_Cuenta",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Id_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Id_Cuenta_Seguida",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Id_Cuenta_Seguida");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_Id_Contenido",
                table: "TR_CONTENIDO_CUENTAS",
                column: "Id_Contenido");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_Id_Cuenta",
                table: "TR_CONTENIDO_CUENTAS",
                column: "Id_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_Id_Cuenta",
                table: "TM_CONTENIDO",
                column: "Id_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_Id_Visibilidad",
                table: "TM_CONTENIDO",
                column: "Id_Visibilidad");

            migrationBuilder.AddForeignKey(
                name: "FK_TM_CONTENIDO_TM_CUENTAS_Id_Cuenta",
                table: "TM_CONTENIDO",
                column: "Id_Cuenta",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_Id_Visibilidad",
                table: "TM_CONTENIDO",
                column: "Id_Visibilidad",
                principalTable: "TM_TIPOS_DE_VISIBILIDAD",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CONTENIDO_Id_Contenido",
                table: "TR_CONTENIDO_CUENTAS",
                column: "Id_Contenido",
                principalTable: "TM_CONTENIDO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CUENTAS_Id_Cuenta",
                table: "TR_CONTENIDO_CUENTAS",
                column: "Id_Cuenta",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Id_Cuenta",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Id_Cuenta",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Id_Cuenta_Seguida",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Id_Cuenta_Seguida",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TM_CONTENIDO_TM_CUENTAS_Id_Cuenta",
                table: "TM_CONTENIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_Id_Visibilidad",
                table: "TM_CONTENIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CONTENIDO_Id_Contenido",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CUENTAS_Id_Cuenta",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Id_Cuenta",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Id_Cuenta_Seguida",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Id_Cuenta",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Id_Cuenta_Seguida",
                table: "TR_CUENTAS_SEGUIDORES");

            migrationBuilder.DropIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_Id_Contenido",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_Id_Cuenta",
                table: "TR_CONTENIDO_CUENTAS");

            migrationBuilder.DropIndex(
                name: "IX_TM_CONTENIDO_Id_Cuenta",
                table: "TM_CONTENIDO");

            migrationBuilder.DropIndex(
                name: "IX_TM_CONTENIDO_Id_Visibilidad",
                table: "TM_CONTENIDO");

            migrationBuilder.AddColumn<int>(
                name: "CuentaId",
                table: "TR_CUENTAS_SEGUIDORES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContenidoId",
                table: "TR_CONTENIDO_CUENTAS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CuentaId",
                table: "TR_CONTENIDO_CUENTAS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CuentaId",
                table: "TM_CONTENIDO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisibilidadId",
                table: "TM_CONTENIDO",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CuentaId", "Fecha_Alta", "VisibilidadId" },
                values: new object[] { null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2170), null });

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CuentaId", "Fecha_Alta", "VisibilidadId" },
                values: new object[] { null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2173), null });

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CuentaId", "Fecha_Alta", "VisibilidadId" },
                values: new object[] { null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2174), null });

            migrationBuilder.UpdateData(
                table: "TM_CONTENIDO",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CuentaId", "Fecha_Alta", "VisibilidadId" },
                values: new object[] { null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2176), null });

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "TM_CUENTAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "TM_TIPOS_DE_VISIBILIDAD",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "TM_USUARIOS",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha_Alta",
                value: new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContenidoId", "CuentaId", "Fecha_Alta" },
                values: new object[] { null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContenidoId", "CuentaId", "Fecha_Alta" },
                values: new object[] { null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "TR_CONTENIDO_CUENTAS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ContenidoId", "CuentaId", "Fecha_Alta" },
                values: new object[] { null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CuentaId", "Cuenta_SeguidaId", "Fecha_Alta" },
                values: new object[] { null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CuentaId", "Cuenta_SeguidaId", "Fecha_Alta" },
                values: new object[] { null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "TR_CUENTAS_SEGUIDORES",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CuentaId", "Cuenta_SeguidaId", "Fecha_Alta" },
                values: new object[] { null, null, new DateTime(2026, 3, 10, 19, 41, 51, 859, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Cuenta_SeguidaId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CUENTAS_SEGUIDORES_CuentaId",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_ContenidoId",
                table: "TR_CONTENIDO_CUENTAS",
                column: "ContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TR_CONTENIDO_CUENTAS_CuentaId",
                table: "TR_CONTENIDO_CUENTAS",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_CuentaId",
                table: "TM_CONTENIDO",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_TM_CONTENIDO_VisibilidadId",
                table: "TM_CONTENIDO",
                column: "VisibilidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_TM_CONTENIDO_TM_CUENTAS_CuentaId",
                table: "TM_CONTENIDO",
                column: "CuentaId",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TM_CONTENIDO_TM_TIPOS_DE_VISIBILIDAD_VisibilidadId",
                table: "TM_CONTENIDO",
                column: "VisibilidadId",
                principalTable: "TM_TIPOS_DE_VISIBILIDAD",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CONTENIDO_ContenidoId",
                table: "TR_CONTENIDO_CUENTAS",
                column: "ContenidoId",
                principalTable: "TM_CONTENIDO",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CONTENIDO_CUENTAS_TM_CUENTAS_CuentaId",
                table: "TR_CONTENIDO_CUENTAS",
                column: "CuentaId",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_CuentaId",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "CuentaId",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TR_CUENTAS_SEGUIDORES_TM_CUENTAS_Cuenta_SeguidaId",
                table: "TR_CUENTAS_SEGUIDORES",
                column: "Cuenta_SeguidaId",
                principalTable: "TM_CUENTAS",
                principalColumn: "Id");
        }
    }
}
