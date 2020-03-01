using Groket.Domain.Enums;
using Groket.Domain.Models.CatalogModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.CatalogMapping
{
    /// <summary>
    /// Set the configuration of the Category entity
    /// </summary>
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.RowStatus)
                .IsRequired()
                .HasDefaultValue((int)RowStatus.Active);

            builder.Property(c => c.Created)
                .IsRequired()
                .HasDefaultValueSql("GetDate()");

            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Slug)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.DisplayOrder)
                  .HasDefaultValue(0);

            builder.Property(c => c.IsPublished)
                .HasDefaultValue(true);

            builder.Property(c => c.IncludeInMenu)
                .HasDefaultValue(true);

            builder.HasOne(c => c.Media)
                .WithOne(c => c.Category);

            builder.HasOne(c => c.Catalog)
                .WithMany(c => c.Categories)
                .HasForeignKey(c => c.FkCatalogId);

            builder.HasMany(c => c.Products)
                .WithOne(c => c.Category);
        }
    }
}
