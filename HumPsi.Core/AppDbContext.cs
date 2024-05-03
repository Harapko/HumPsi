using HumPsi.Data.MsSql.Configurations;
using HumPsi.Data.MsSql.Models;
using Microsoft.EntityFrameworkCore;

namespace HumPsi.Data.MsSql;

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