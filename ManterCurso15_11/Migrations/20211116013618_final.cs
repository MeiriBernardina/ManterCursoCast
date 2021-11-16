using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManterCurso15_11.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Log_LogID",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_LogID",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "LogID",
                table: "Curso");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUltimaAtualizacao",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Log_CursoId",
                table: "Log",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Log_Curso_CursoId",
                table: "Log",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_Curso_CursoId",
                table: "Log");

            migrationBuilder.DropIndex(
                name: "IX_Log_CursoId",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "DataUltimaAtualizacao",
                table: "Log");

            migrationBuilder.AddColumn<int>(
                name: "LogID",
                table: "Curso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curso_LogID",
                table: "Curso",
                column: "LogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Log_LogID",
                table: "Curso",
                column: "LogID",
                principalTable: "Log",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
