using HumPsi.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.Core.Configurations;

public class HeadlinesConfiguration : IEntityTypeConfiguration<HeadlinesEntity>
{
    public void Configure(EntityTypeBuilder<HeadlinesEntity> builder)
    {
        builder.HasKey(h => h.Id);

        builder
            .HasMany(h => h.Articles)
            .WithOne(a => a.Headlines);

        builder
            .HasOne(h => h.Section)
            .WithMany(s=>s.Headlines)
            .HasForeignKey(h=>h.SectionId);

        


    }
}