using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class Section
{
    public Guid Id { get; set; }

    public string TitleSection { get; set; } = string.Empty;

    public List<HeadlinesEntity>? Headlines { get; set; } = [];
}