using HumPsi.Core.Models;


namespace HumPsi.Core.Repositories;

public interface ISectionsRepository
{
    Task<Guid> Create(Section section);

    Task<List<Section>> Get();
    
    Task<Guid> Update(Guid id, string title);
    
    Task<Guid> Delete(Guid id);
    
}