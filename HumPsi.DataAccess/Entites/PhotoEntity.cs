using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class PhotoEntity
{
    public Guid Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    
}