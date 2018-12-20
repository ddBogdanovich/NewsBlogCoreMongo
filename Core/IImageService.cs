namespace NewsBlogCoreMongo.Core
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Models;
   
    public interface IImageService
    {
        Task<Image> UploadImage(IFormFile file, string uploadsFolderPath);

        void DeleteImage(string filename);
    }
}