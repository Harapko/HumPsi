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
    private readonly IHeadlinesPhotoService _headlinesPhotoService;
    private readonly string _staticFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photo/headlines");

    public HeadlinesController(IHeadlineService headlineService, IHeadlinesPhotoService headlinesPhotoService)
    {
        _headlineService = headlineService;
        _headlinesPhotoService = headlinesPhotoService;
    }

    [HttpGet]
    [Route("/getAllHeadlines")]
    public async Task<ActionResult<List<HeadlinesResponseForNavMenu>>> GetAllHeadlines()
    {
        var headlines = await _headlineService.GetAllHeadlines();

        var response = headlines.Select(h => new HeadlinesResponseForNavMenu(h.Id, h.Title));

        return Ok(response);
    }

    [HttpPost]
    [Route("/createHeadlines")]
    public async Task<ActionResult<Guid>>  CreateHeadlines([FromForm] HeadlinesRequest request)
    {
       
        var (headlines, error) = Headlines.Create(
            Guid.NewGuid(),
            request.title,
            request.sectionId
        );
        var image = _headlinesPhotoService.CreatePhoto(Guid.NewGuid() ,request.filePath, _staticFilePath, headlines.Id).Result.photoEntity;
        if (!string.IsNullOrEmpty(error))
        {
            return BadRequest(error);
        }

        var headlineId = _headlineService.CreateHeadlines(headlines);
        
        return Ok(headlineId);
    }
    
    
}