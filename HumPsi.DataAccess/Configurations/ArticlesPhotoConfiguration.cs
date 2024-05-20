using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;

public class ArticlesPhotoConfiguration : IEntityTypeConfiguration<ArticlesPhotoEntity>
{
    public void Configure(EntityTypeBuilder<ArticlesPhotoEntity> builder)
    {
        builder
            .HasKey(ap => ap.Id);

        builder
            .HasOne(ap => ap.Articles)
            .WithMany(a => a.Photos)
            .HasForeignKey(ap => ap.ArticlesId);
    }
}