namespace HumPsi.DataAccess.Entites;

public class ArticlesPhotoEntity
{
    public Guid Id { get; set; }
    public string FilePath { get; set; }

    public Guid ArticlesId { get; set; }
    public ArticlesEntity Articles { get; set; }
}