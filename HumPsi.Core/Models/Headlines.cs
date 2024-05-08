namespace HumPsi.Core.Models;

public class Headlines
{
    public const int MAX_TITLE_LENGHT = 50;

    private Headlines()
    {
        
    }
    
    private Headlines(Guid id, string title, Guid? titlePhotoId , Photo? photo, Guid sectionId, Section section, List<Articles>? articlesList)
    {
        Id = id;
        Title = title;
        TitlePhotoId = titlePhotoId;
        Photo = photo;
        SectionId = sectionId;
        Section = section;
        Articles = articlesList;
    }
   
    
    public Guid Id { get;  }
    public string Title { get;  } = string.Empty;
    
    public Guid SectionId { get;  }
    public Section Section { get;  }
    
    public Guid? TitlePhotoId { get; }
    public Photo? Photo { get; }
    
    public List<Articles>? Articles { get;  } = [];

    public static (Headlines headlines, string Error) Create(Guid id, string title, Guid? titlePhotoId , Photo? photo,
        Guid sectionId, Section section, List<Articles>? articlesList)
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
        
        var headlines = new Headlines(id, title, titlePhotoId, photo, sectionId, section, articlesList);

        return (headlines, error);
    }
}