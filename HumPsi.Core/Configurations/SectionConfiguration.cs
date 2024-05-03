using HumPsi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.Core.Configurations;

public class SectionConfiguration : IEntityTypeConfiguration<SectionEntity>
{
    public void Configure(EntityTypeBuilder<SectionEntity> builder)
    {
        builder.HasKey(s => s.Id);

        builder
            .HasMany(s => s.Headlines)
            .WithOne(h=>h.Section);
        

    }
}