using Groket.Domain.Enums;
using Groket.Domain.Models.Marketing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.MarketingMapping
{
    public class ExpenditureConfiguration : IEntityTypeConfiguration<Expenditure>
    {
        /// <summary>
        /// Get or Set the Expenditure entity
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Expenditure> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.RowStatus)
                .IsRequired()
                .HasDefaultValue((int)RowStatus.Active);

            builder.Property(e => e.Created)
                .IsRequired()
                .HasDefaultValueSql("GetDate()");

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.Comment)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.ExpenditureType)
                .IsRequired();

            builder.Property(e => e.Cost)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.HasOne(e => e.Marketing)
                .WithOne(e => e.Expenditure)
                .HasForeignKey<Marketing>(e => e.FkExpenditureId);

        }
    }
}
