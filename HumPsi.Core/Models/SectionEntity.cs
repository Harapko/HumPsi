namespace HumPsi.Core.Models;


public class SectionEntity
{

    public const int MAX_TITLE_LENGHT = 50;

    private SectionEntity(Guid  id, string titleSection, List<HeadlinesEntity> headlines)
    {
        Id = id;
        TitleSection = titleSection;
        Headlines = headlines;
    }
    
    public Guid Id { get;  }

    public string TitleSection { get;  } = string.Empty;

    public List<HeadlinesEntity>? Headlines { get;  } = [];

    public static (SectionEntity sectionEntity, string Error) Create(Guid id, string titleSection,
        List<HeadlinesEntity> headlines)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(titleSection) || titleSection.Length > MAX_TITLE_LENGHT)
        {
            error = "Title section can't be empty or longer then 50 symbols";
        }
        
        
        var section = new SectionEntity(id, titleSection, headlines);
        return (section, error);
    }
}

