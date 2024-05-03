namespace HumPsi.Data.MsSql.Models;

public class PhotoEntity
{
    private PhotoEntity(Guid id, byte[] bytes, string filePath, string fileExtension, decimal size, Guid articleId, ArticlesEntity articles)
    {
        Id = id;
        Bytes = bytes;
        FilePath = filePath;
        FileExtension = fileExtension;
        Size = size;
        ArticleId = articleId;
        Articles = articles;
    }
    
    public Guid Id { get;  }
    public byte[] Bytes { get; } = [];
    public string FilePath { get; } = string.Empty;
    public string FileExtension { get; } = string.Empty;
    public decimal Size { get;  }

    public Guid ArticleId { get;  }
    public ArticlesEntity Articles { get;  }
}