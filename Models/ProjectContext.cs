using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class ProjectContext : DbContext
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
        public DbSet<AdminInfo> AdminInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YOURSERVER;Database=ProjectMVC;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acessorio>()
                .HasIndex(a => a.NomeAcessorio)
                .IsUnique();

            modelBuilder.Entity<Carro>()
                .HasIndex(c => c.NumChassi)
                .IsUnique();

            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.CPFCliente)
                .IsUnique();

            modelBuilder.Entity<Filial>()
                .HasIndex(f => f.NomeFilial)
                .IsUnique();

            modelBuilder.Entity<Funcao>()
                .HasIndex(f => f.NomeFuncao)
                .IsUnique();

            modelBuilder.Entity<Funcionario>()
                .HasIndex(f => f.CPFFuncionario)
                .IsUnique();

            modelBuilder.Entity<Servico>()
                .HasIndex(s => s.NomeServico)
                .IsUnique();

            modelBuilder.Entity<Agenda>()
                .HasIndex(a => new {a.DataAgenda, a.FkFuncionarioCodFuncionario})
                .IsUnique();

        }
    }
}
