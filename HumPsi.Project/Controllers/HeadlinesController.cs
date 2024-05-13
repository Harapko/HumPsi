using HumPsi.Core.Models;
using HumPsi.Data.MsSql.Abstraction.Headline;
using HumPsi.Data.MsSql.Abstraction.Photo;
using HumPsiProject.Contracts.Headlines;
using Microsoft.AspNetCore.Mvc;

namespace HumPsiProject.Controllers;

[ApiController]
public class HeadlinesController : ControllerBase
{
    private readonly IHeadlineService _headlineService;
    private readonly IPhotoService _photoService;
    private readonly string _staticFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photo/headlines");

    public HeadlinesController(IHeadlineService headlineService, IPhotoService photoService)
    {
        _headlineService = headlineService;
        _photoService = photoService;
    }

    [HttpGet]
    [Route("/headlinesGet")]
    public async Task<ActionResult<List<HeadlinesResponseForNavMenu>>> GetAllHeadlines()
    {
        var headlines = await _headlineService.GetAllHeadlines();

        var response = headlines.Select(h => new HeadlinesResponseForNavMenu(h.Id, h.Title));

        return Ok(response);
    }

    [HttpPost]
    [Route("/headlinesCreate")]
    public async Task<ActionResult<Guid>>  CreateHeadlines([FromBody] HeadlinesRequest request)
    {
        var image = _photoService.CreatePhoto(Guid.NewGuid() ,request.filePath, _staticFilePath).Result.photoEntity;
        var (headlines, error) = Headlines.Create(
            Guid.NewGuid(),
            request.Title,
            image,
            request.SectionId,
            new List<Articles>()
        );
        
        if (!string.IsNullOrEmpty(error))
        {
            return BadRequest(error);
        }

        var headlineId = _headlineService.CreateHeadlines(headlines);
        
        return Ok(headlineId);
    }
}