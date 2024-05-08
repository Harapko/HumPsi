using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;

public class SectionConfiguration : IEntityTypeConfiguration<SectionEntity>
{
    public void Configure(EntityTypeBuilder<SectionEntity> builder)
    {
        builder.HasKey(s => s.Id);

        builder
            .HasMany(s => s.Headlines)
            .WithOne(h => h.Section)
            .HasForeignKey(h=>h.SectionId);
        
        
        builder.Property(s => s.TitleSection)
            .IsRequired()
            .HasMaxLength(Section.MAX_TITLE_LENGHT);

    }
}