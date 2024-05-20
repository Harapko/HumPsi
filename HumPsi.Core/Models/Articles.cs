using System.ComponentModel.DataAnnotations.Schema;

namespace HumPsi.Core.Models;

public class Articles
{
    public const int MAX_TITLE_LENGHT = 50;

    private Articles()
    {
        
    }
    
    private Articles(Guid id, string title, string? subTitle, List<string>? contentTitle,
        List<string>? content, string? shortContentTitle, string? shortContent, Guid headlinesId)
    {
        Id = id;
        Title = title;
        SubTitle = subTitle;
        ContentTitle = contentTitle;
        Content = content;
        ShortContentTitle = shortContentTitle;
        ShortContent = shortContent;
        HeadlinesId = headlinesId;
    }
    
    public Guid Id { get; }

    public string Title { get;  } = string.Empty;
    public string? SubTitle { get;  } = string.Empty;
    

    public List<string>? ContentTitle { get;  } = [];
    [Column(TypeName = "nvarchar(50)")]
    public List<string>? Content { get;  } = [];


    public string? ShortContentTitle { get;  } = string.Empty;
    [Column(TypeName = "nvarchar(50)")]
    public string? ShortContent { get;  } = string.Empty;


    public Guid HeadlinesId { get;  }
    public Headlines Headlines { get;  }
    
    
    public List<HeadlinesPhoto>? Photos { get;  } = [];

    public static (Articles articlesEntity, string Error) Create(Guid id, string title, string? subTitle,
        List<string>? contentTitle,
        List<string>? content, string? shortContentTitle, string? shortContent, Guid headlinesId)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGHT)
        {
            error = "Title section can't be empty or longer then 50 symbols";
        }
        
        
        var article = new Articles(id, title, subTitle, contentTitle, content, shortContentTitle, shortContent, headlinesId);

        return (article, error);
    }
}