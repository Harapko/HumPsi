namespace HumPsi.Core.Models;


public class HeadlinesPhoto
{
    private HeadlinesPhoto()
    {
        
    }
    
    private HeadlinesPhoto(Guid id,string filePath, Guid headlinesId)
    {
        Id = id;
        FilePath = filePath;
        HeadlinesId = headlinesId;
    }
    
    
    public Guid Id { get;  }
    public string FilePath { get; } = string.Empty;
    
    public Guid ? HeadlinesId { get; }
    public Headlines? Headlines { get; }
    
    
    

    public static (HeadlinesPhoto photoEntity, string Error) Create(Guid id,string filePath, Guid headlinesId)
    {
        var error = string.Empty;

        // if (string.IsNullOrEmpty(filePath))
        // {
        //     error = "File can't have empty path";
        // }
        
        var photo = new HeadlinesPhoto(id, filePath, headlinesId);
        return (photo, error);
    }
}