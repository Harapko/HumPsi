namespace HumPsi.Core.Models;


public class PhotoEntity
{
    private PhotoEntity(Guid id, string filePath, string fileExtension, Guid articleId, ArticlesEntity articles)
    {
        Id = id;
        FilePath = filePath;
        FileExtension = fileExtension;
        ArticleId = articleId;
        Articles = articles;
    }
    
    public Guid Id { get;  }
    public string FilePath { get; } = string.Empty;
    public string FileExtension { get; } = string.Empty;
    public Guid ArticleId { get;  }
    public ArticlesEntity Articles { get;  }

    public static (PhotoEntity photoEntity, string Error) Create(Guid id, string filePath, string fileExtension, Guid articleId, ArticlesEntity articles)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(filePath))
        {
            error = "File can't have empty path";
        }
        
        var photo = new PhotoEntity(id, filePath, fileExtension, articleId, articles);
        return (photo, error);
    }
}