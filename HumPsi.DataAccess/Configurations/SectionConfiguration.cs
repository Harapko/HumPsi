using HumPsi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;

public class SectionConfiguration : IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> builder)
    {
        builder.HasKey(s => s.Id);

        builder
            .HasMany(s => s.Headlines)
            .WithOne(h=>h.Section);

        builder.Property(s => s.TitleSection)
            .IsRequired()
            .HasMaxLength(Section.MAX_TITLE_LENGHT);

    }
}