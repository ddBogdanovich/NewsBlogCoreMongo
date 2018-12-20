namespace NewsBlogCoreMongo.Core
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    
    public interface IImageStorage
    {
        Task<string> StoreImage(string uploadsFolderPath, IFormFile file);
        void DeleteImage(string filename);
    }
}