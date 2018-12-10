namespace MongoBlog.Core
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using NewsBlogCoreMongo.Models;

    public class ImageService : IImageService
    {
        private IImageStorage _imageStorage;

        public ImageService(IImageStorage imageStorage)
        {
            _imageStorage = imageStorage;
        }

        public async Task<Image> UploadPhoto(IFormFile file, string uploadsFolderPath)
        {
            var fileId = await _imageStorage.StoreImage(uploadsFolderPath, file);
            var imageName = Path.GetFileName(file.FileName);

            var newImage = new Image
            {
                FileId = fileId,
                OriginalFileName = imageName,
                Extension = Path.GetExtension(imageName)
            };

            return newImage;
        }
    }
}