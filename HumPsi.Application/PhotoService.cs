using System.Runtime.InteropServices.JavaScript;
using CSharpFunctionalExtensions;
using HumPsi.Core.Models;
using HumPsi.Data.MsSql.Abstraction.Photo;
using HumPsi.DataAccess.Entites;
using Microsoft.AspNetCore.Http;

namespace HumPsi.Application;

public class PhotoService : IPhotoService
{
    public async Task<(Photo photoEntity, string Error)> CreatePhoto(Guid id,IFormFile titleImage, string path)
    {
        try
        {
            var fileName = Path.GetFileName(titleImage.FileName);
            var filePath = Path.Combine(path, fileName);

            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await titleImage.CopyToAsync(stream);
            }

            var image = Photo.Create(id ,filePath);

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