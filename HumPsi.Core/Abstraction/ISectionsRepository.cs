using HumPsi.Core.Models;

namespace HumPsi.Core.Repositories;

public interface ISectionsRepository
{
    Task<Guid> Create(Section section, List<Headlines> headlinesList);

    Task<List<Section>> Get();
    
    Task<Guid> Update(Guid id, string title, List<Headlines> headlinesList);
    
    Task<Guid> Delete(Guid id);
    
}