using Groket.Domain.Models.ProductsModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Groket.Data.Mapping.ProductMapping
{
    /// <summary>
    /// Set the configuration of the Product tags entity
    /// </summary>
    public class ProductTagsConfiguration : IEntityTypeConfiguration<ProductTags>
    {
        public void Configure(EntityTypeBuilder<ProductTags> builder)
        {
            builder.HasKey(pt => pt.Id);
        }
    }
}
