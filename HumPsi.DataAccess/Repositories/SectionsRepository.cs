using HumPsi.Core.Models;
using HumPsi.Core.Repositories;
using HumPsi.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Section = HumPsi.Core.Models.Section;

namespace HumPsi.DataAccess.Repositories;

public class SectionsRepository : ISectionsRepository
{
    private readonly AppDbContext _context;
    
    public SectionsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Section>> Get()
    {
        var sectionEntity = await _context.Section
            .AsNoTracking()
            .Include(s => s.Headlines)
            .ToListAsync();

        var sections = sectionEntity
            .Select(s => Section.Create(s.Id, s.TitleSection, s.Headlines).sectionEntity)
            .ToList();

        return sections;
    }

    public async Task<Guid> Create(Section section, List<Headlines> headlinesList)
    {
        var sectionEntity = new SectionEntity()
        {
            Id = section.Id,
            TitleSection = section.TitleSection,
            Headlines = headlinesList
        };

        await _context.Section.AddAsync(sectionEntity);
        await _context.SaveChangesAsync();

        return sectionEntity.Id;
    }

    public async Task<Guid> Update(Guid id, string title, List<Headlines> headlinesList)
    {
        await _context.Section
            .Where(s => s.Id == id)
            .ExecuteUpdateAsync(set => set
                .SetProperty(s => s.TitleSection, s => title)
                .SetProperty(s => s.Headlines, s => headlinesList));

        return id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _context.Section
            .Where(s => s.Id == id)
            .ExecuteDeleteAsync();

        return id;
    }
}