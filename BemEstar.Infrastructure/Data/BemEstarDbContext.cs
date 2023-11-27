using BemEstar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BemEstar.Infrastructure.Data
{
    public class BemEstarDbContext : DbContext
    {
        public BemEstarDbContext() { }

        public BemEstarDbContext(DbContextOptions<BemEstarDbContext> options) : base(options) { }

        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Refeicao> Refeicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Alimento>().HasKey(x => x.IdAlimento);
            modelBuilder.Entity<Refeicao>().HasKey(x => x.IdRefeicao);

            modelBuilder.Entity<Alimento>()
                .HasOne(r => r.Refeicao)
                .WithMany(a => a.Alimentos)
                .HasForeignKey(x => x.IdRefeicao);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("DefaultConnection");
            }
        }

    }
}
