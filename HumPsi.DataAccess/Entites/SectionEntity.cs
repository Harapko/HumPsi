using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class SectionEntity
{
    public Guid Id { get; set; }

    public string TitleSection { get; set; } = string.Empty;

    public List<HeadlinesEntity>? Headlines { get; set; } = [];
}