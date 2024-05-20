using System.Runtime.InteropServices.JavaScript;

namespace HumPsi.Core.Models;

public class ArticlesPhoto
{
    private ArticlesPhoto(Guid id, string filePath, Guid articlesId)
    {
        Id = id;
        FilePath = filePath;
        ArticlesId = articlesId;
    }
    
    public Guid Id { get;  }
    public string FilePath { get; }

    public Guid ArticlesId { get; }
    public Articles? Articles { get; }
    
    public static (ArticlesPhoto articlesPhoto, string Error) Create(Guid id, string filePath, Guid articlesId)
    {
        var error = string.Empty;
        
        var articlePhoto = new ArticlesPhoto(id, filePath, articlesId);
        return (articlePhoto, error);
    }
}