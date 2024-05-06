using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class PhotoEntity
{
    public Guid Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string FileExtension { get; set; } = string.Empty;
    public Guid ArticleId { get; set; }
    public Core.Models.Articles Articles { get; set; }
}