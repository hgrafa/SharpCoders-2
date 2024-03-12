using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSqlite.Migrations
{
    /// <inheritdoc />
    public partial class CreateFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "Atendimentos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_FuncionarioId",
                table: "Atendimentos",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Funcionario_FuncionarioId",
                table: "Atendimentos",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Funcionario_FuncionarioId",
                table: "Atendimentos");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_FuncionarioId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Atendimentos");
        }
    }
}
