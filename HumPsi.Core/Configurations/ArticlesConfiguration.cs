using HumPsi.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.Core.Configurations;


public class ArticlesConfiguration : IEntityTypeConfiguration<ArticlesEntity>
{
    public void Configure(EntityTypeBuilder<ArticlesEntity> builder)
    {
        builder.HasKey(a => a.Id);

        builder
            .HasOne(a => a.Headlines)
            .WithMany(h => h.Articles)
            .HasForeignKey(a=>a.HeadlinesId);

        builder
            .HasMany(a => a.Photos)
            .WithOne(p => p.Articles);




    }
}