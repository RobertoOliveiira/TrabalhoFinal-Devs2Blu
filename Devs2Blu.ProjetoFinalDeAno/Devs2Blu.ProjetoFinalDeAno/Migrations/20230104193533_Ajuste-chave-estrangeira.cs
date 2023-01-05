using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetoFinalDeAno.Migrations
{
    /// <inheritdoc />
    public partial class Ajustechaveestrangeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdEndereco",
                table: "Cliente",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_IdEndereco",
                table: "Cliente",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_IdEndereco",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_IdEndereco",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id");
        }
    }
}
