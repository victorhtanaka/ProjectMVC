using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acessorios",
                columns: table => new
                {
                    CodAcessorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAcessorio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessorios", x => x.CodAcessorio);
                });

            migrationBuilder.CreateTable(
                name: "AcessoriosCarros",
                columns: table => new
                {
                    CodAcessorioCarro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkAcessorioCodAcessorio = table.Column<int>(type: "int", nullable: false),
                    FkCarroCodCarro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcessoriosCarros", x => x.CodAcessorioCarro);
                });

            migrationBuilder.CreateTable(
                name: "AdminInfos",
                columns: table => new
                {
                    CodAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginAdmin = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SenhaAdmin = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FkFilialCodFilial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminInfos", x => x.CodAdmin);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    CodAgenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAgenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Km = table.Column<float>(type: "real", nullable: false),
                    FkFuncionarioCodFuncionario = table.Column<int>(type: "int", nullable: false),
                    FkServicoCodServico = table.Column<int>(type: "int", nullable: false),
                    FkClienteCodCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.CodAgenda);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    CodCarro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumChassi = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    ModeloCarro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MarcaCarro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AnoCarro = table.Column<int>(type: "int", nullable: false),
                    CorCarro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ValorCarro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KmCarro = table.Column<float>(type: "real", nullable: false),
                    FkFilialCodFilial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.CodCarro);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPFCliente = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EndCliente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailCliente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TelCliente = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DataNasc = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodCliente);
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    CodFilial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFilial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.CodFilial);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPFFuncionario = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EndFuncionario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailFuncionario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TelFuncionario = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DataNasc = table.Column<DateOnly>(type: "date", nullable: false),
                    SalarioFuncionario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FkFilialCodFilial = table.Column<int>(type: "int", nullable: false),
                    FkFuncaoCodFuncao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.CodFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    CodFuncao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescricaoFuncao = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.CodFuncao);
                });

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    CodRelatorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescRelatorio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FkAgendaCodAgenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.CodRelatorio);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    CodServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeServico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescServico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.CodServico);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    CodVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVenda = table.Column<DateOnly>(type: "date", nullable: false),
                    UltimaRevisao = table.Column<DateOnly>(type: "date", nullable: false),
                    FkClienteCodCliente = table.Column<int>(type: "int", nullable: false),
                    FkCarroCodCarro = table.Column<int>(type: "int", nullable: false),
                    FkFuncionarioCodFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.CodVenda);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acessorios");

            migrationBuilder.DropTable(
                name: "AcessoriosCarros");

            migrationBuilder.DropTable(
                name: "AdminInfos");

            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "Relatorios");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
