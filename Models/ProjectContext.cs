using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<AcessorioCarro> AcessoriosCarros { get; set; } = null!;
        public DbSet<Acessorio> Acessorios { get; set; } = null!;
        public DbSet<Agenda> Agendas { get; set; } = null!;
        public DbSet<Carro> Carros { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Filial> Filiais { get; set; } = null!;
        public DbSet<Funcao> Funcoes { get; set; } = null!;
        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Relatorio> Relatorios { get; set; } = null!;
        public DbSet<Servico> Servicos { get; set; } = null!;
        public DbSet<Venda> Vendas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-H6HOM7Q\SQLEXPRESS;Database=ProjectMVC;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}