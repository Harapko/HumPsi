using HumPsi.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.Core.Configurations;

public class PhotoConfiguration : IEntityTypeConfiguration<PhotoEntity>
{
    public void Configure(EntityTypeBuilder<PhotoEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasOne(p => p.Articles)
            .WithMany(a => a.Photos)
            .HasForeignKey(p=>p.ArticleId);


    }
}