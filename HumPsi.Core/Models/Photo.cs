namespace HumPsi.Core.Models;


public class Photo
{
    private Photo()
    {
        
    }
    
    private Photo(Guid id,string filePath)
    {
        Id = id;
        FilePath = filePath;
    }
    
    
    public Guid Id { get;  }
    public string FilePath { get; } = string.Empty;
    

    public static (Photo photoEntity, string Error) Create(Guid id,string filePath)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(filePath))
        {
            error = "File can't have empty path";
        }
        
        var photo = new Photo(id, filePath);
        return (photo, error);
    }
}