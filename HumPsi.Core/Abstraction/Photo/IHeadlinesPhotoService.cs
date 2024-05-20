using Microsoft.AspNetCore.Http;

namespace HumPsi.Data.MsSql.Abstraction.Photo;

public interface IHeadlinesPhotoService
{
    Task<(Core.Models.HeadlinesPhoto photoEntity, string Error)> CreatePhoto(Guid id,IFormFile titleImage, string path, Guid headlinesId);
}