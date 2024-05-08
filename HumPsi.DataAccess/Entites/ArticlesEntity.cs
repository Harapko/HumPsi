using System.ComponentModel.DataAnnotations.Schema;
using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class ArticlesEntity
{
    
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string? SubTitle { get; set; } = string.Empty;
    

    public List<string>? ContentTitle { get; set; } = [];
    [Column(TypeName = "nvarchar(50)")]
    public List<string>? Content { get; set; } = [];


    public string? ShortContentTitle { get; set; } = string.Empty;
    [Column(TypeName = "nvarchar(50)")]
    public string? ShortContent { get; set; } = string.Empty;


    public Guid HeadlinesId { get; set; }

    public HeadlinesEntity Headlines { get; set; }
    
    public List<PhotoEntity>? Photos { get; set; } = [];
}