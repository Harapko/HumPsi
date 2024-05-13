using HumPsi.Core.Models;

namespace HumPsi.Core.Repositories;

public interface ISectionService
{
    Task<Guid> CreateSection(Section section);

    Task<List<Section>> GetAllSection();
    
    Task<Guid> UpdateSection(Guid id, string title);
    
    Task<Guid> DeleteSection(Guid id);
}