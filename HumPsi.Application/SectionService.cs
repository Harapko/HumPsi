using HumPsi.Core.Models;
using HumPsi.Core.Repositories;

namespace HumPsi.Application;

public class SectionService : ISectionService
{
    private readonly ISectionsRepository _sectionsRepository;
    public SectionService(ISectionsRepository sectionsRepository)
    {
        _sectionsRepository = sectionsRepository;
    }

    public async Task<List<Section>> GetAllSection()
    {
        return await _sectionsRepository.Get();
    }

    public async Task<Guid> CreateSection(Section section)
    {
        return await _sectionsRepository.Create(section);
    }

    public async Task<Guid> UpdateSection(Guid id, string title, List<Headlines> headlinesList)
    {
        return await _sectionsRepository.Update(id, title, headlinesList);
    }

    public async Task<Guid> DeleteSection(Guid id)
    {
        return await _sectionsRepository.Delete(id);
    }
}