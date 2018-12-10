namespace MongoBlog.Core
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using NewsBlogCoreMongo.Models;

    public interface IImageService
    {
        Task<Image> UploadPhoto(IFormFile file, string uploadsFolderPath);
    }
}