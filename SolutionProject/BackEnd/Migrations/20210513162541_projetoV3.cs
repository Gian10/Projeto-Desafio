using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class projetoV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agendamentoManutencao",
                columns: table => new
                {
                    AgendamentoManutencaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataManutencao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlacaVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Servico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmServico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendamentoManutencao", x => x.AgendamentoManutencaoId);
                });

            migrationBuilder.CreateTable(
                name: "registroManutencaos",
                columns: table => new
                {
                    RegistroManutencaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRegistroManutencao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlacaVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registroManutencaos", x => x.RegistroManutencaoId);
                });

            migrationBuilder.CreateTable(
                name: "veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoFabricacao = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculos", x => x.VeiculoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agendamentoManutencao");

            migrationBuilder.DropTable(
                name: "registroManutencaos");

            migrationBuilder.DropTable(
                name: "veiculos");
        }
    }
}
