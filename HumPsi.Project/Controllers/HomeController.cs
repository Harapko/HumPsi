using HumPsi.Core.Repositories;
using HumPsiProject.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HumPsiProject.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ISectionService  _sectionService;

    public HomeController(ISectionService sectionService)
    {
        _sectionService = sectionService;
    }

    [HttpGet]
    public async Task<ActionResult<List<SectionResponse>>> GetSection()
    {
        var section = await _sectionService.GetAllSection();

        var response = section.Select(s => new SectionResponse(s.Id, s.TitleSection, s.Headlines));

        return Ok(response);
    }
}