
using Groket.Domain.Models.ProductsModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.ProductMapping
{
    /// <summary>
    /// Set the configuration of the Product Price History entity
    /// </summary>
    public class ProductPriceHistoryConfiguration : IEntityTypeConfiguration<ProductPriceHistory>
    {
        public void Configure(EntityTypeBuilder<ProductPriceHistory> builder)
        {
            builder.HasKey(pph => pph.Id);

            builder.Property(pph => pph.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pph => pph.OldPrice)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(pph => pph.Product)
                .WithMany(pph => pph.PriceHistory)
                .HasForeignKey(pph => pph.FkProductId);

        }
    }
}
