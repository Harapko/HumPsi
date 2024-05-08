using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HumPsi.DataAccess.Configurations;


public class PhotoConfiguration : IEntityTypeConfiguration<PhotoEntity>
{
    public void Configure(EntityTypeBuilder<PhotoEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasOne(p => p.Articles)
            .WithMany(a => a.Photos)
            .HasForeignKey(p=>p.ArticlesId);
        
        builder
            .HasOne(p => p.Headlines)
            .WithOne(h => h.Photo)
            .HasForeignKey<PhotoEntity>(p => p.HeadlinesId);
        
        
        builder.Property(p => p.FilePath)
            .IsRequired();
    }
}