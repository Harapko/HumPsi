using HumPsi.Core.Models;
using HumPsi.DataAccess.Entites;

namespace HumPsiProject.Contracts.Headlines;

public record HeadlinesRequest(
    string title,
    Guid sectionId,
    IFormFile? filePath
);
