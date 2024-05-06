namespace HumPsi.Core.Models;


public class Photo
{
    private Photo(Guid id, string filePath, string fileExtension, Guid articleId, Articles articles)
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
    public Articles Articles { get;  }

    public static (Photo photoEntity, string Error) Create(Guid id, string filePath, string fileExtension, Guid articleId, Articles articles)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(filePath))
        {
            error = "File can't have empty path";
        }
        
        var photo = new Photo(id, filePath, fileExtension, articleId, articles);
        return (photo, error);
    }
}