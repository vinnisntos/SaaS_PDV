using Microsoft.EntityFrameworkCore;
using SaaS_PDV.Models;
using System.Configuration;



namespace SaaS_PDV.Data
{
    public class AppDbContext : DbContext
    {
        // Construtores necessários para o EF Core 10/VS 2026
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
                // Conexão local que depois será trocada pela do Azure
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SaaS_PDV_DB;Trusted_Connection=True;");
            }
        }
    }
}