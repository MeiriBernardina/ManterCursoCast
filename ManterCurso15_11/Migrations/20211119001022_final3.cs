using Microsoft.EntityFrameworkCore.Migrations;

namespace ManterCurso15_11.Migrations
{
    public partial class final3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Categoria_CategoriaId1",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_CategoriaId1",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "CategoriaId1",
                table: "Curso");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Curso",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeCategoria",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curso_CategoriaId",
                table: "Curso",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Categoria_CategoriaId",
                table: "Curso",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Categoria_CategoriaId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_CategoriaId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "NomeCategoria",
                table: "Curso");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaId",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId1",
                table: "Curso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curso_CategoriaId1",
                table: "Curso",
                column: "CategoriaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Categoria_CategoriaId1",
                table: "Curso",
                column: "CategoriaId1",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
