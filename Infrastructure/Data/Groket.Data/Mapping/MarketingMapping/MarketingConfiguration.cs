using Groket.Domain.Models.Marketing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Groket.Data.Mapping.MarketingMapping
{
    public class MarketingConfiguration : IEntityTypeConfiguration<Marketing>
    {
        public void Configure(EntityTypeBuilder<Marketing> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.CampaignName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.CampaigningArea)
                .HasMaxLength(60);

            builder.Property(m => m.AssignedTo)
                .IsRequired();

            builder.Property(m => m.ScheduleDate)
                .IsRequired()
                .HasDefaultValueSql("GetDate()");

        }
    }
}
