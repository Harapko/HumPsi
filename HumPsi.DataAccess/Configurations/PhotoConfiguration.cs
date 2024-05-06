using HumPsi.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;


public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
{
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasOne(p => p.Articles)
            .WithMany(a => a.Photos)
            .HasForeignKey(p=>p.ArticleId);


        builder.Property(p => p.FilePath)
            .IsRequired();
    }
}