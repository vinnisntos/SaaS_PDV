using Microsoft.EntityFrameworkCore;
using SaaS_PDV.Core.Models.Entities;
using System.Configuration;



namespace SaaS_PDV.Data
{
    public class AppDbContext : DbContext
    {
        // construtores necessarios para o Entity Framework
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // conexão com o banco de dados SQL Server no Azure, nao alterar essa string.
                optionsBuilder.UseSqlServer("Server=tcp:vinniciussantos.database.windows.net,1433;Initial Catalog=database-vinnicius;Persist Security Info=False;User ID=adminvinnicius;Password=Vinni2005@!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}