namespace HumPsi.Core.Models;


public class Section
{

    public const int MAX_TITLE_LENGHT = 50;

    private Section()
    {
        
    }
    private Section(Guid  id, string titleSection)
    {
        Id = id;
        TitleSection = titleSection;
    }
    
    public Guid Id { get;  }

    public string TitleSection { get;  } = string.Empty;

    public List<Headlines>? Headlines { get;  } = [];

    public static (Section sectionEntity, string Error) Create(Guid id, string titleSection)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(titleSection) || titleSection.Length > MAX_TITLE_LENGHT)
        {
            error = "Title section can't be empty or longer then 50 symbols";
        }
        
        
        var section = new Section(id, titleSection);
        return (section, error);
    }
    //..
}

