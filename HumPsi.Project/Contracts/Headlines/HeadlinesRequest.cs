using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;

namespace HumPsiProject.Contracts.Headlines;

public record HeadlinesRequest(
    Guid HeadlinesId,
    string Title,
    Guid SectionId,
    IFormFile filePath
);
