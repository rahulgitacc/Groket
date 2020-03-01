using Groket.Domain.Enums;
using Groket.Domain.Models.Marketing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.MarketingMapping
{
    /// <summary>
    /// Get or Set the fund transaction entity
    /// </summary>
    public class FundTransactionConfiguration : IEntityTypeConfiguration<FundTransaction>
    {
        public void Configure(EntityTypeBuilder<FundTransaction> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.RowStatus)
                .IsRequired()
                .HasDefaultValue((int)RowStatus.Active);

            builder.Property(f => f.Created)
                .IsRequired()
                .HasDefaultValueSql("GetDate()");

            builder.Property(f => f.Owner)
                .IsRequired();

            builder.Property(f => f.IsCredited)
                .IsRequired();

            builder.Property(f => f.TotalFund)
                .IsRequired();

            builder.HasOne(f => f.Expenditure)
                .WithOne(f => f.FundTransaction)
                .HasForeignKey<FundTransaction>(f => f.FkExpenditureId);

        }
    }
}
