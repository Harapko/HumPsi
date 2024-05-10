using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;

namespace HumPsiProject.Contracts;

public record SectionResponse(Guid id, string titleSection, List<Headlines>? headlinesList)
{
    
}