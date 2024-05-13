using HumPsi.Core.Models;

namespace HumPsi.Data.MsSql.Abstraction.Headline;

public interface IHeadlineService
{
    Task<List<Headlines>> GetAllHeadlines();
    Task<List<Headlines>> GetHeadlineBySectionId(Guid id);
    Task<Guid> CreateHeadlines(Headlines headlines);
    Task<Guid> UpdateHeadlines(Guid id, string title);
    Task<Guid> DeleteHeadlines(Guid id);
}