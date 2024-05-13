using CSharpFunctionalExtensions;
using HumPsi.Core.Models;
using HumPsi.Data.MsSql.Abstraction.Headline;
using HumPsi.Data.MsSql.Abstraction.Photo;
using HumPsi.DataAccess.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HumPsi.DataAccess.Repositories;

public class HeadlinesRepository : IHeadlinesRepository
{

    private readonly AppDbContext _context;
    
    
    public HeadlinesRepository(AppDbContext context, IPhotoService photoService)
    {
        _context = context;
    }
    
    public async Task<List<Headlines>> Get()
    {
        var headlinesEntity = await _context.Headlines
            .AsNoTracking()
            .Include(h => h.Articles)
            .Include(h => h.Photo)
            .Include(h => h.Section)
            .ToListAsync();

        var headlines = headlinesEntity
            .Select(h => Headlines.Create(h.Id, h.Title, h.Photo, h.SectionId, new List<Articles>()).headlines)
            .ToList();
        
        return headlines;
    }

    public async Task<List<Headlines>> GetBySectionId(Guid sectionId)
    {
        var headlinesEntity = await _context.Headlines
            .AsNoTracking()
            .Include(h => h.Articles)
            .Include(h => h.Photo)
            .Include(h => h.Section)
            .ToListAsync();

        var headlines = headlinesEntity
            .Select(h => Headlines.Create(h.Id, h.Title, h.Photo, h.SectionId, new List<Articles>()).headlines)
            .Where(h=>h.SectionId==sectionId)
            .ToList();
        
        return headlines;
    }
    
    public async Task<Guid> Create(Headlines headlines)
    {
        var headlineEntity = new HeadlinesEntity()
        {
            Id = headlines.Id,
            Title = headlines.Title,
            Photo = headlines.Photo,
            SectionId = headlines.SectionId,
            Articles = new List<ArticlesEntity>()
        };
        await _context.Headlines.AddAsync(headlineEntity);
        await _context.SaveChangesAsync();
        return headlineEntity.Id;
    }

    public async Task<Guid> Update(Guid id, string title)
    {
        await _context.Headlines
            .Where(h=>h.Id==id)
            .ExecuteUpdateAsync(set=>set
                .SetProperty(h=>h.Title,title));

        return id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _context.Headlines
            .Where(h => h.Id == id)
            .ExecuteDeleteAsync();
        return id;
    }
}