using Microsoft.EntityFrameworkCore;
using WatchCatalog.Models;

namespace WatchCatalogAPI.Data
{
    public class WatchCatalogDbContext : DbContext
    {
        public WatchCatalogDbContext(DbContextOptions<WatchCatalogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Purchase> Purchases => Set<Purchase>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchases");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Price).HasColumnType("decimal(18,2)");
            });
        }
    }
}
