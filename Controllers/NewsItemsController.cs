using Microsoft.AspNetCore.Authorization;

namespace M101DotNet.WebApp.Controllers
{
    
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.Extensions.Configuration;
    using MongoBlog.Core;
    using MongoBlog.Repository;
    using NewsBlogCoreMongo.Models;
    
    
    [Authorize(Roles = "Administrator, Moderator")]
    public class NewsItemsController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IHostingEnvironment _env;
        private readonly IImageService _imageService;
        private IConfiguration _configuration { get; }


        public NewsItemsController(IBlogRepository blogRepository, IConfiguration configuration,
            IHostingEnvironment env, IImageService imageService)
        {
            _blogRepository = blogRepository;
            _configuration = configuration;
            _imageService = imageService;
            _env = env;
        }


        public ActionResult List()
        {
            return View();
        }


        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var newsItem = await _blogRepository.FindNewsItem(id);

            if (newsItem == null)
            {
                return NotFound();
            }

            return View(newsItem);
        }


        public ActionResult Create()
        {
            PopulateCategoriesDropDownList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Headline,Body,CreatedAtUtc,Category")]
            NewsItem newsItem, IFormCollection files)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (files.Files.Any(x => x != null))
                    {
                        var imagesList = new List<Image>();
                        var uploadDir = _configuration.GetSection("UploadsFolder").Value;
                        var uploadsFolderPath = Path.Combine(_env.WebRootPath + uploadDir);

                        foreach (var file in files.Files)
                        {
                            var image = await _imageService.UploadPhoto(file, uploadsFolderPath);
                            imagesList.Add(image);
                        }

                        newsItem.Images = imagesList;
                    }

                    await _blogRepository.InsertNewsItemAsync(newsItem);
                    return RedirectToAction("List");
                }
            }
            catch
            {
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            PopulateCategoriesDropDownList(newsItem.Category);
            return View(newsItem);
        }


        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var newsItem = await _blogRepository.FindNewsItem(id);

            if (newsItem == null)
            {
                return NotFound();
            }

            PopulateCategoriesDropDownList(newsItem.Category);

            return View(GenerateNewsItemViewModel(newsItem));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(NewsItem newsItem, IList<IFormFile> files)
        {
            var imagesList = new List<Image>();
            try
            {
                if (ModelState.IsValid)
                {
                    if (files.Count(file => file != null) > 0)
                    {
                        var uploadDir = _configuration.GetSection("UploadsFolder").Value;
                        var absolutePath = _env.WebRootPath + uploadDir;
                        if (Directory.Exists(absolutePath))
                        {
                            foreach (var file in files)
                            {
                                var imageName = Path.GetFileName(file.FileName);

                                var newImage = new Image
                                {
                                    FileId = Guid.NewGuid().ToString(),
                                    OriginalFileName = imageName,
                                    Extension = Path.GetExtension(imageName)
                                };

                                imagesList.Add(newImage);
                                var imagePath = Path.Combine(absolutePath, newImage.FileId + newImage.Extension);

                                using (var fileStream = new FileStream(imagePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                }
                            }
                        }
                    }

                    newsItem.Images = imagesList;
                    await _blogRepository.UpdateNewsItemAsync(newsItem);
                    return RedirectToAction("List");
                }
            }
            catch
            {
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            PopulateCategoriesDropDownList(newsItem.Category);
            return View(newsItem);
        }


        [HttpPost]
        public async Task<JsonResult> DeleteFile(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                Response.StatusCode = (int) HttpStatusCode.BadRequest;
                return Json(new {Result = "Error"});
            }

            try
            {
                Image image = await _blogRepository.GetImage(id);

                if (image == null)
                {
                    Response.StatusCode = (int) HttpStatusCode.NotFound;
                    return Json(new {Result = "Error"});
                }

                await _blogRepository.DeleteImage(image.FileId);


                var uploadDir = _configuration.GetSection("UploadsFolder").Value;
                var absolutePath = _env.WebRootPath + uploadDir + image.FileId + image.Extension;

                if (System.IO.File.Exists(absolutePath))
                {
                    System.IO.File.Delete(absolutePath);
                }

                return Json(new {Result = "OK"});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "ERROR", Message = ex.Message});
            }
        }

        public FileResult Download(String p, String d)
        {
            var uploadDir = _configuration.GetSection("UploadsFolder").Value;
            var absolutePath = _env.WebRootPath;
            var imagePath = absolutePath + uploadDir + p;
            return File((imagePath), System.Net.Mime.MediaTypeNames.Application.Octet, d);
        }


        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var newsItem = await _blogRepository.FindNewsItem(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            return View(GenerateNewsItemViewModel(newsItem));
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                _blogRepository.DeleteNewsItem(id);
            }
            catch
            {
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("Delete", new {id = id});
            }

            return RedirectToAction("List");
        }


        private async void PopulateCategoriesDropDownList(object selectedCategory = null)
        {
            var categoriesQuery = await _blogRepository.GetExistingCategories();
            ViewData["Category"] = new SelectList(categoriesQuery, "Name", "Name", selectedCategory);
        }

        private NewsItemViewModel GenerateNewsItemViewModel(NewsItem item)
        {
            return new NewsItemViewModel()
            {
                newsItem = item,
                uploadsFolder = _configuration.GetSection("UploadsFolder").Value,
                blankImageName = _configuration.GetSection("BlankImageName").Value,
                wwwRootPath = _env.WebRootPath
            };
        }
    }
}