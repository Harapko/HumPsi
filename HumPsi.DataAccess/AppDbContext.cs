using HumPsi.Core.Models;
using HumPsi.DataAccess.Configurations;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace HumPsi.DataAccess;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<SectionEntity> Section { get; set; }
    
    public DbSet<HeadlinesEntity> Headlines { get; set; }
    
    public DbSet<ArticlesEntity> Articles { get; set; }
    
    public DbSet<PhotoEntity> Photo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SectionConfiguration());
        modelBuilder.ApplyConfiguration(new HeadlinesConfiguration());
        modelBuilder.ApplyConfiguration(new ArticlesConfiguration());
        modelBuilder.ApplyConfiguration(new PhotoConfiguration());
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SectionEntity>().HasData(
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Biochemistry", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Histology", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Cardiovascular", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Respiratory", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Gastrointestinal", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Urinary", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Reproductive", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Neurology", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Endocrine", Headlines = []},
            new SectionEntity{Id = Guid.NewGuid(), TitleSection = "Immunology/Haematology", Headlines = []}
        );

    }
}