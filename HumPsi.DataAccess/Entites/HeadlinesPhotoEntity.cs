using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class HeadlinesPhotoEntity
{
    public Guid Id { get; set; }
    public string FilePath { get; set; } = string.Empty;

    public Guid HeadlinesId { get; set; }
    public HeadlinesEntity? Headline { get; set; }
    
}