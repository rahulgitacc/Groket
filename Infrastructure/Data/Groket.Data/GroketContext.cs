using System;
using Microsoft.EntityFrameworkCore;
using Groket.Domain.Models.ProductsModel;
using Groket.Domain.Models.CommonModel;
using Groket.Domain.Models.CatalogModel;

namespace Groket.Data
{
    public class GroketContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .IsRequired();
                
                entity.Property(e => e.Slug)
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsRequired();

                entity.HasOne(e => e.Media)
                    .WithOne();

                entity.HasMany(e => e.Products)
                    .WithOne();
            });
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Media> Media { get; set; }
    }
}
