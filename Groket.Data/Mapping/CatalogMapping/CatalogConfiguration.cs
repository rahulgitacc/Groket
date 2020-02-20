using Groket.Domain.Models.CatalogModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.CatalogMapping
{
    /// <summary>
    /// Set the configuration of the Catalog entity
    /// </summary>
    public class CatalogConfiguration : IEntityTypeConfiguration<Catalog>
    {
        public void Configure(EntityTypeBuilder<Catalog> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Slug)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(c => c.MetaTitle)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.MetaKeywords)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.DisplayOrder)
                .ValueGeneratedOnAdd();

            builder.HasMany(c => c.Categories)
                .WithOne(c => c.Catalog);

            builder.HasOne(c => c.Media)
                .WithOne(c => c.Catalog);
        }
    }
}
