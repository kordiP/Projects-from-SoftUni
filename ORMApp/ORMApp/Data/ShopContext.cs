using Microsoft.EntityFrameworkCore;
using ORMApp.Data.Models;

namespace ORMApp.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {

        }
        public ShopContext(DbContextOptions options)
            : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (Configuration.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
