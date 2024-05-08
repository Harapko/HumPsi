using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class PhotoEntity
{
    public Guid Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    
    public Guid? HeadlinesId { get; set; }
    public HeadlinesEntity? Headlines { get; set; }
    
    public Guid? ArticlesId { get; set; }
    public ArticlesEntity? Articles { get; set; }
}