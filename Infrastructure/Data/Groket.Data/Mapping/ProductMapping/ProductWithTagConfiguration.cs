using Groket.Domain.Models.ProductsModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.ProductMapping
{
    /// <summary>
    /// Set the configuration relationship between the product and tag
    /// </summary>
    class ProductWithTagConfiguration : IEntityTypeConfiguration<ProductWithTag>
    {
        public void Configure(EntityTypeBuilder<ProductWithTag> builder)
        {
            builder.HasKey(pt => new { pt.FkProductId, pt.FkProductTagId });
        }
    }
}
