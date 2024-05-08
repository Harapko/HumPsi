using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class HeadlinesEntity
{
    
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    
    public Guid SectionId { get; set; }
    public SectionEntity Section { get; set; }
    
    public Guid? TitlePhotoId { get; set; }
    public PhotoEntity? Photo { get; set; }
    
    public List<ArticlesEntity>? Articles { get; set; } = [];
}