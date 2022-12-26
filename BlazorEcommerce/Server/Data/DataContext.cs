

using BlazorEcommerce.Server.Data.Config;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new ProductConfig(modelBuilder.Entity<Product>());
            new CategoryConfig(modelBuilder.Entity<Category>());

        }
    }
}
