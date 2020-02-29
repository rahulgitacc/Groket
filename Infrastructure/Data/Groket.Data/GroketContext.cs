using Groket.Data.Mapping.CatalogMapping;
using Groket.Data.Mapping.CommonMapping;
using Groket.Data.Mapping.ProductMapping;
using Groket.Domain.Models.CatalogModel;
using Groket.Domain.Models.CommonModel;
using Groket.Domain.Models.ProductsModel;
using Microsoft.EntityFrameworkCore;

namespace Groket.Data
{
    /// <summary>
    /// Application database context
    /// </summary>
    public class GroketContext : DbContext
    {
        public GroketContext(DbContextOptions options)
               : base(options) { }


        /// <summary>
        /// Configure the db model
        /// </summary>
        /// <param name="modelBuilder">modelBuilder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPriceHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductWithTagConfiguration());
        }

        #region DbSet Properties

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPriceHistory> ProductPriceHistories { get; set; }
        public DbSet<ProductWithTag> ProductWithTags { get; set; }
        public DbSet<ProductTags> ProductTags { get; set; }

        #endregion

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=Groket;Trusted_Connection=True;MultipleActiveResultSets=true;");
        //}
    }
}
