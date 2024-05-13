using Microsoft.AspNetCore.Http;

namespace HumPsi.Data.MsSql.Abstraction.Photo;

public interface IPhotoService
{
    Task<(Core.Models.Photo photoEntity, string Error)> CreatePhoto(Guid id,IFormFile titleImage, string path);
}