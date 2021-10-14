using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAlunos2.Migrations
{
    public partial class AjusteModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semestre",
                table: "Turma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Semestre",
                table: "Turma",
                nullable: true);
        }
    }
}
