using HumPsi.Core.Models;
using HumPsi.Data.MsSql.Abstraction.Headline;

namespace HumPsi.Application;

public class HeadlinesService : IHeadlineService
{
    private readonly IHeadlinesRepository _headlinesRepository;

    public HeadlinesService(IHeadlinesRepository headlinesRepository)
    {
        _headlinesRepository = headlinesRepository;
    }
    
    public async Task<List<Headlines>> GetAllHeadlines()
    {
        return await _headlinesRepository.Get();
    }
    
    public async Task<List<Headlines>> GetHeadlineBySectionId(Guid id)
    {
        return await _headlinesRepository.GetBySectionId(id);
    }

    public async Task<Guid> CreateHeadlines(Headlines headlines)
    {
        return await _headlinesRepository.Create(headlines);
    }

    public async Task<Guid> UpdateHeadlines(Guid id, string title)
    {
        return await _headlinesRepository.Update(id, title);
    }

    public async Task<Guid> DeleteHeadlines(Guid id)
    {
        return await _headlinesRepository.Delete(id);
    }
}