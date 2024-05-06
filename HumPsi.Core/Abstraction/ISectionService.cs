using HumPsi.Core.Models;

namespace HumPsi.Core.Repositories;

public interface ISectionService
{
    Task<Guid> CreateSection(Section section, List<Headlines> headlinesList);

    Task<List<Section>> GetAllSection();
    
    Task<Guid> UpdateSection(Guid id, string title, List<Headlines> headlinesList);
    
    Task<Guid> DeleteSection(Guid id);
}