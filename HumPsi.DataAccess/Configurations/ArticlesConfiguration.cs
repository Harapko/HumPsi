using HumPsi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;


public class ArticlesConfiguration : IEntityTypeConfiguration<Articles>
{
    public void Configure(EntityTypeBuilder<Articles> builder)
    {
        builder.HasKey(a => a.Id);

        builder
            .HasOne(a => a.Headlines)
            .WithMany(h => h.Articles)
            .HasForeignKey(a=>a.HeadlinesId);

        builder
            .HasMany(a => a.Photos)
            .WithOne(p => p.Articles);


        builder.Property(a => a.Title)
            .IsRequired()
            .HasMaxLength(Articles.MAX_TITLE_LENGHT);


    }
}