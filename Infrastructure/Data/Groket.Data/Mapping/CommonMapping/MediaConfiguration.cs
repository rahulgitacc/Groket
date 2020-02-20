
using Groket.Domain.Models.CommonModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.CommonMapping
{
    /// <summary>
    /// Set the configuration of the Media entity
    /// </summary>
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Caption)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.FileName)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(m => m.Brand)
                .WithOne(m => m.Media)
                .HasForeignKey<Media>(m => m.FkBrandId);

            builder.HasOne(m => m.Product)
                .WithMany(m => m.Media)
                .HasForeignKey(m => m.FkProductId);

            builder.HasOne(m => m.Catalog)
                .WithOne(m => m.Media)
                .HasForeignKey<Media>(m => m.FkCatalogId);

            builder.HasOne(m => m.Category)
                .WithOne(m => m.Media)
                .HasForeignKey<Media>(m => m.FkCategoryId);

        }
    }
}
