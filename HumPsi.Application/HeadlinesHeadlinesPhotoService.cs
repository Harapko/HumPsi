using HumPsi.Core.Models;
using HumPsi.Data.MsSql.Abstraction.Photo;
using Microsoft.AspNetCore.Http;

namespace HumPsi.Application;

public class HeadlinesHeadlinesPhotoService : IHeadlinesPhotoService
{
    public async Task<(HeadlinesPhoto photoEntity, string Error)> CreatePhoto(Guid id,IFormFile titleImage, string path, Guid headlinesId)
    {
        try
        {
            var fileName = Path.GetFileName(titleImage.FileName);
            var filePath = Path.Combine(path, fileName);

            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await titleImage.CopyToAsync(stream);
            }

            var image = HeadlinesPhoto.Create(id ,filePath, headlinesId);

            return image;
        }
        catch (Exception e)
        {
            var error = string.Empty;
            error = e.Message;
            return (null, error);
        }
        
    }
}