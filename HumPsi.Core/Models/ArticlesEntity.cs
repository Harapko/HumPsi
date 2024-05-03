using System.ComponentModel.DataAnnotations.Schema;

namespace HumPsi.Data.MsSql.Models;

public class ArticlesEntity
{
    
    public Guid Id { get;  }

    public string Title { get;  } = string.Empty;
    public string SubTitle { get;  } = string.Empty;
    

    public List<string> ContentTitle { get;  } = [];
    [Column(TypeName = "nvarchar(24)")]
    public List<string> Content { get;  } = [];


    public string ShortContentTitle { get;  } = string.Empty;
    [Column(TypeName = "nvarchar(24)")]
    public string ShortContent { get;  } = string.Empty;


    public Guid HeadlinesId { get;  }
    public HeadlinesEntity Headlines { get;  }
    
    public List<PhotoEntity>? Photos { get;  } = [];
}