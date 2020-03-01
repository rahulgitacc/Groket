using Groket.Domain.Enums;
using Groket.Domain.Models.ProductsModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.ProductMapping
{
    /// <summary>
    /// Set the configuration of the Product entity
    /// </summary>
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.RowStatus)
                .IsRequired()
                .HasDefaultValue((int)RowStatus.Active);

            builder.Property(p => p.Created)
                .IsRequired()
                .HasDefaultValueSql("GetDate()");

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.ShortDescription)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.SpecialPrice)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.IsAllowToOrder)
                .HasDefaultValue(true);

            builder.HasMany(p => p.Media)
                .WithOne(p => p.Product);

            builder.HasOne(p => p.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.FkBrandId);

            builder.HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.FkCategoryId);

            builder.HasMany(p => p.PriceHistory)
                .WithOne(p => p.Product);

        }
    }
}
