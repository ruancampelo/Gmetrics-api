using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class GmetricsContext : DbContext
    {
        public GmetricsContext(DbContextOptions<GmetricsContext> options) : base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>()
                .Property(p => p.Criacao).HasColumnName("dt_criacao");
            modelBuilder.Entity<Log>()
                .Property(p => p.TipoLog).HasColumnName("Tipo_Log");
            modelBuilder.Entity<Log>()
                .Property(p => p.IdProduto).HasColumnName("id_produto");

        }
    }
}
