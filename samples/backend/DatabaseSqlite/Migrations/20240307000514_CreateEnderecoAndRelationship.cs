using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSqlite.Migrations
{
    /// <inheritdoc />
    public partial class CreateEnderecoAndRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Atendimentos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rua = table.Column<string>(type: "TEXT", nullable: false),
                    Cep = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_EnderecoId",
                table: "Atendimentos",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Enderecos_EnderecoId",
                table: "Atendimentos",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Enderecos_EnderecoId",
                table: "Atendimentos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_EnderecoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Atendimentos");
        }
    }
}
