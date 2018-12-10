namespace MongoBlog.Core
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public class FileSystemImageStorage : IImageStorage
    {
        public async Task<string> StoreImage(string uploadsFolderPath, IFormFile file)
        {
            if (!Directory.Exists(uploadsFolderPath))
            {
                Directory.CreateDirectory(uploadsFolderPath);
            }

            var fileName = Guid.NewGuid().ToString();
            var filepath = Path.Combine(uploadsFolderPath, fileName + Path.GetExtension(file.FileName));

            using (var fileStream = new FileStream(filepath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}