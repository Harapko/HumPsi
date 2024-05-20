using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;


public class HeadlinesPhotoConfiguration : IEntityTypeConfiguration<HeadlinesPhotoEntity>
{
    public void Configure(EntityTypeBuilder<HeadlinesPhotoEntity> builder)
    {
        builder.HasKey(hp => hp.Id);

        builder
            .HasOne(p => p.Headline)
            .WithMany(hp => hp.Photo)
            .HasForeignKey(p => p.HeadlinesId);
    }
}