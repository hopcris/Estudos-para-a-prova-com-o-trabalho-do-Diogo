using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIdeGerenciamentoDomestico.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comodos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comodos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    ComodoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarefas_Comodos_ComodoId",
                        column: x => x.ComodoId,
                        principalTable: "Comodos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TarefasConcluidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataConclusao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MoradorId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComodoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarefasConcluidas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TarefasConcluidas_Comodos_ComodoId",
                        column: x => x.ComodoId,
                        principalTable: "Comodos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TarefasConcluidas_Moradores_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "Moradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_ComodoId",
                table: "Tarefas",
                column: "ComodoId");

            migrationBuilder.CreateIndex(
                name: "IX_TarefasConcluidas_ComodoId",
                table: "TarefasConcluidas",
                column: "ComodoId");

            migrationBuilder.CreateIndex(
                name: "IX_TarefasConcluidas_MoradorId",
                table: "TarefasConcluidas",
                column: "MoradorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "TarefasConcluidas");

            migrationBuilder.DropTable(
                name: "Comodos");

            migrationBuilder.DropTable(
                name: "Moradores");
        }
    }
}
