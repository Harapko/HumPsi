namespace HumPsi.Data.MsSql.Models;

public class HeadlinesEntity
{
    public const int MAX_TITLE_LENGHT = 50;

    private HeadlinesEntity(Guid id, string title, string titlePhoto, Guid sectionId, SectionEntity section)
    {
        Id = id;
        Title = title;
        TitlePhoto = titlePhoto;
        SectionId = sectionId;
        Section = section;
    }
   
    
    public Guid Id { get;  }

    public string Title { get;  } = string.Empty;

    public string TitlePhoto { get;  } = string.Empty;

    public Guid SectionId { get;  }
    public SectionEntity Section { get;  }

    public List<ArticlesEntity> Articles { get;  } = [];

    public static (HeadlinesEntity headlines, string Error) Create(Guid id, string title, string titlePhoto,
        Guid sectionId, SectionEntity section)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGHT)
        {
            error = "Title can't be empty or longer then 50 symbols";
        }

        if (string.IsNullOrEmpty(titlePhoto))
        {
            error = "Title photo is required";
        }
        
        var headlines = new HeadlinesEntity(id, title, titlePhoto, sectionId, section);

        return (headlines, error);
    }
}