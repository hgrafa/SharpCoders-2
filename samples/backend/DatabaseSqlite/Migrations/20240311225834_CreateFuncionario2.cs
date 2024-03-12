using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSqlite.Migrations
{
    /// <inheritdoc />
    public partial class CreateFuncionario2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Funcionario_FuncionarioId",
                table: "Atendimentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.RenameTable(
                name: "Funcionario",
                newName: "Funcionarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Funcionarios_FuncionarioId",
                table: "Atendimentos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Funcionarios_FuncionarioId",
                table: "Atendimentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "Funcionario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Funcionario_FuncionarioId",
                table: "Atendimentos",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id");
        }
    }
}
