namespace HumPsi.Data.MsSql.Models;

public class HeadlinesEntity
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public Guid SectionId { get; set; }

    public SectionEntity SectionEntity { get; set; }
}