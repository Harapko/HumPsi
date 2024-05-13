using HumPsi.Core.Models;
using Microsoft.AspNetCore.Http;

namespace HumPsi.Data.MsSql.Abstraction.Headline;

public interface IHeadlinesRepository
{
    Task<List<Headlines>> Get();
    Task<List<Headlines>> GetBySectionId(Guid sectionId);
    Task<Guid> Create(Headlines headlines);
    Task<Guid> Update(Guid id, string title);
    Task<Guid> Delete(Guid id);
}