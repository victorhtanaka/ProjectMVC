﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectMVC.Models;

#nullable disable

namespace ProjectMVC.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectMVC.Models.Acessorio", b =>
                {
                    b.Property<int>("CodAcessorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodAcessorio"));

                    b.Property<string>("NomeAcessorio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodAcessorio");

                    b.ToTable("Acessorios");
                });

            modelBuilder.Entity("ProjectMVC.Models.AcessorioCarro", b =>
                {
                    b.Property<int>("CodAcessorioCarro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodAcessorioCarro"));

                    b.Property<int>("FkAcessorioCodAcessorio")
                        .HasColumnType("int");

                    b.Property<int>("FkCarroCodCarro")
                        .HasColumnType("int");

                    b.HasKey("CodAcessorioCarro");

                    b.ToTable("AcessoriosCarros");
                });

            modelBuilder.Entity("ProjectMVC.Models.AdminInfo", b =>
                {
                    b.Property<int>("CodAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodAdmin"));

                    b.Property<int>("FkFilialCodFilial")
                        .HasColumnType("int");

                    b.Property<string>("LoginAdmin")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SenhaAdmin")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CodAdmin");

                    b.ToTable("AdminInfos");
                });

            modelBuilder.Entity("ProjectMVC.Models.Agenda", b =>
                {
                    b.Property<int>("CodAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodAgenda"));

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAgenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkClienteCodCliente")
                        .HasColumnType("int");

                    b.Property<int>("FkFuncionarioCodFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("FkServicoCodServico")
                        .HasColumnType("int");

                    b.Property<float>("Km")
                        .HasColumnType("real");

                    b.Property<string>("Modelo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodAgenda");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("ProjectMVC.Models.Carro", b =>
                {
                    b.Property<int>("CodCarro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodCarro"));

                    b.Property<int>("AnoCarro")
                        .HasColumnType("int");

                    b.Property<string>("CorCarro")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("FkFilialCodFilial")
                        .HasColumnType("int");

                    b.Property<float>("KmCarro")
                        .HasColumnType("real");

                    b.Property<string>("MarcaCarro")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModeloCarro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumChassi")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<decimal>("ValorCarro")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodCarro");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("ProjectMVC.Models.Cliente", b =>
                {
                    b.Property<int>("CodCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodCliente"));

                    b.Property<string>("CPFCliente")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateOnly>("DataNasc")
                        .HasColumnType("date");

                    b.Property<string>("EmailCliente")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EndCliente")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TelCliente")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CodCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjectMVC.Models.Filial", b =>
                {
                    b.Property<int>("CodFilial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFilial"));

                    b.Property<string>("NomeFilial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CodFilial");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("ProjectMVC.Models.Funcao", b =>
                {
                    b.Property<int>("CodFuncao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFuncao"));

                    b.Property<string>("DescricaoFuncao")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NomeFuncao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CodFuncao");

                    b.ToTable("Funcoes");
                });

            modelBuilder.Entity("ProjectMVC.Models.Funcionario", b =>
                {
                    b.Property<int>("CodFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodFuncionario"));

                    b.Property<string>("CPFFuncionario")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateOnly>("DataNasc")
                        .HasColumnType("date");

                    b.Property<string>("EmailFuncionario")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EndFuncionario")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("FkFilialCodFilial")
                        .HasColumnType("int");

                    b.Property<int>("FkFuncaoCodFuncao")
                        .HasColumnType("int");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("SalarioFuncionario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TelFuncionario")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CodFuncionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ProjectMVC.Models.Relatorio", b =>
                {
                    b.Property<int>("CodRelatorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodRelatorio"));

                    b.Property<string>("DescRelatorio")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("FkAgendaCodAgenda")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodRelatorio");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("ProjectMVC.Models.Servico", b =>
                {
                    b.Property<int>("CodServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodServico"));

                    b.Property<string>("DescServico")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NomeServico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodServico");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("ProjectMVC.Models.Venda", b =>
                {
                    b.Property<int>("CodVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodVenda"));

                    b.Property<DateOnly>("DataVenda")
                        .HasColumnType("date");

                    b.Property<int>("FkCarroCodCarro")
                        .HasColumnType("int");

                    b.Property<int>("FkClienteCodCliente")
                        .HasColumnType("int");

                    b.Property<int>("FkFuncionarioCodFuncionario")
                        .HasColumnType("int");

                    b.Property<DateOnly>("UltimaRevisao")
                        .HasColumnType("date");

                    b.HasKey("CodVenda");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
