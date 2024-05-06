using HumPsi.Core.Models;

namespace HumPsi.DataAccess.Entites;

public class HeadlinesEntity
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string TitlePhoto { get; set; } = string.Empty;

    public Guid SectionId { get; set; }
    public Core.Models.Section Section { get; set; }

    public List<Core.Models.Articles> Articles { get; set; } = [];
}