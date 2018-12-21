namespace NewsBlogCoreMongo.Controllers
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
    using Microsoft.AspNetCore.Authorization;
    using Core;
    using Persistence;
    using Core.Models;
    using ViewModels;


    [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
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
            NewsItem newsItem, IFormFileCollection files)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (files.Any(x => x != null))
                    {
                        var imagesList = new List<Image>();
                        var uploadDir = "/" + _configuration.GetSection("UploadsFolder").Value;
                        var uploadsFolderPath = Path.Combine(_env.WebRootPath + uploadDir);

                        foreach (var file in files)
                        {
                            var image = await _imageService.UploadImage(file, uploadsFolderPath);
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
            return View(GenerateNewsItemViewModel(newsItem));
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
        public async Task<IActionResult> Edit(NewsItem newsItem, IFormFileCollection files)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var imagesList = new List<Image>();

                    if (files.Any(x => x != null))
                    {
                        var uploadDir = "/" + _configuration.GetSection("UploadsFolder").Value;
                        var uploadsFolderPath = Path.Combine(_env.WebRootPath + uploadDir);

                        foreach (var file in files)
                        {
                            var image = await _imageService.UploadImage(file, uploadsFolderPath);
                            imagesList.Add(image);
                        }
                    }

                    var foundNewsItem = await _blogRepository.FindNewsItem(newsItem.Id);

                    if (foundNewsItem == null)
                    {
                        return NotFound();
                    }

                    newsItem.Images = foundNewsItem.Images ?? new List<Image>();
                    newsItem.Images.AddRange(imagesList);


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
            return View(GenerateNewsItemViewModel(newsItem));
        }


        [HttpPost]
        public async Task<JsonResult> DeleteFile(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                Response.StatusCode = (int) HttpStatusCode.BadRequest;
                return Json(new {Result = "Error"});
            }

            try
            {
                var image = await _blogRepository.GetImage(id);

                if (image == null)
                {
                    Response.StatusCode = (int) HttpStatusCode.NotFound;
                    return Json(new {Result = "Error"});
                }

                await _blogRepository.DeleteImage(image.FileId);


                var uploadDir = "/" + _configuration.GetSection("UploadsFolder").Value;
                var absolutePath = _env.WebRootPath + uploadDir + image.FileId + image.Extension;

                _imageService.DeleteImage(absolutePath);

                return Json(new {Response  = "OK"});
            }
            catch (Exception ex)
            {
                return Json(new {Response  = "ERROR"});
            }
        }

        public FileResult Download(string p, string d)
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