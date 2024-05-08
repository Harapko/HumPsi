using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;


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
            .WithOne(p => p.Articles)
            .HasForeignKey(p => p.ArticlesId);


        builder.Property(a => a.Title)
            .IsRequired()
            .HasMaxLength(Articles.MAX_TITLE_LENGHT);


    }
}