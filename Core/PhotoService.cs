namespace NewsBlogCoreMongo.Core
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Models;
    
    public class ImageService : IImageService
    {
        private IImageStorage _imageStorage;

        public ImageService(IImageStorage imageStorage)
        {
            _imageStorage = imageStorage;
        }

        public async Task<Image> UploadImage(IFormFile file, string uploadsFolderPath)
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

        public void DeleteImage(string filename)
        {
            _imageStorage.DeleteImage(filename);
        }
    }
}