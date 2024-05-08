namespace HumPsi.Core.Models;


public class Photo
{
    private Photo()
    {
        
    }
    
    private Photo(Guid id, string filePath, Guid? articleId, Articles? articles, Guid? headlinesId, Headlines? headlines)
    {
        Id = id;
        FilePath = filePath;
        ArticlesId = articleId;
        Articles = articles;
        HeadlinesId = headlinesId;
        Headlines = headlines;
    }
    
    public Guid Id { get;  }
    public string FilePath { get; } = string.Empty;
    public Guid? HeadlinesId { get; }
    public Headlines? Headlines { get; }
    public Guid? ArticlesId { get;  }
    public Articles? Articles { get;  }
    

    public static (Photo photoEntity, string Error) Create(Guid id, string filePath, Guid? articleId, Articles? articles, Guid? headlinesId, Headlines? headlines)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(filePath))
        {
            error = "File can't have empty path";
        }

        if (headlinesId == null && articleId == null)
        {
            error = "Photo can't be create";
        }
        
        var photo = new Photo(id, filePath, articleId, articles, headlinesId, headlines);
        return (photo, error);
    }
}