using HumPsi.DataAccess.Configurations;
using HumPsi.Core.Models;
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
    }
}