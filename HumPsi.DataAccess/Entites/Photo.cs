using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class Photo
{
    public Guid Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string FileExtension { get; set; } = string.Empty;
    public Guid ArticleId { get; set; }
    public ArticlesEntity Articles { get; set; }
}