namespace HumPsi.Data.MsSql.Models;

public class SectionEntity
{

    private SectionEntity(Guid  id, string titleSection, List<HeadlinesEntity> headlines)
    {
        Id = id;
        TitleSection = titleSection;
        Headlines = headlines;
    }
    
    public Guid Id { get;  }

    public string TitleSection { get;  } = string.Empty;

    public List<HeadlinesEntity> Headlines { get;  } = [];
    
    
}

