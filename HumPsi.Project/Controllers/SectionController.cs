using HumPsi.Core.Repositories;
using HumPsiProject.Contracts;
using HumPsiProject.Contracts.Section;
using Microsoft.AspNetCore.Mvc;

namespace HumPsiProject.Controllers;

[ApiController]
public class SectionController : ControllerBase
{
    private readonly ISectionService  _sectionService;

    public SectionController(ISectionService sectionService)
    {
        _sectionService = sectionService;
    }

    [HttpGet]
    [Route("/getSection")]
    public async Task<ActionResult<List<SectionResponse>>> GetSection(Guid id)
    {
        var section = await _sectionService.GetAllSection();

        var response = section.Select(s => new SectionResponse(s.Id, s.TitleSection));

        return Ok(response);
    }
}