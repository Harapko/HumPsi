namespace HumPsi.Core.Models;

public class Headlines
{
    public const int MAX_TITLE_LENGHT = 50;

    private Headlines(Guid id, string title, string titlePhoto, Guid sectionId, Section section)
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
    public Section Section { get;  }

    public List<Articles> Articles { get;  } = [];

    public static (Headlines headlines, string Error) Create(Guid id, string title, string titlePhoto,
        Guid sectionId, Section section)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGHT)
        {
            error = "Title headlines can't be empty or longer then 50 symbols";
        }

        if (sectionId.Equals(null))
        {
            error = "Headlines must have a section";
        }
        
        var headlines = new Headlines(id, title, titlePhoto, sectionId, section);

        return (headlines, error);
    }
}