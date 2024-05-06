using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Headlines = HumPsi.Core.Models.Headlines;

namespace HumPsi.DataAccess.Configurations;


public class HeadlinesConfiguration : IEntityTypeConfiguration<Headlines>
{
    public void Configure(EntityTypeBuilder<Headlines> builder)
    {
        builder.HasKey(h => h.Id);

        builder
            .HasMany(h => h.Articles)
            .WithOne(a => a.Headlines);

        builder
            .HasOne(h => h.Section)
            .WithMany(s=>s.Headlines)
            .HasForeignKey(h=>h.SectionId);

        builder.Property(h => h.Title)
            .IsRequired()
            .HasMaxLength(Headlines.MAX_TITLE_LENGHT);



    }
}