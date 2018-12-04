using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using MongoBlog.Repository;
using NewsBlogCoreMongo.Models;

namespace M101DotNet.WebApp.Controllers
{
  // [Authorize(Roles = "Administrator, Moderator")]
    public class NewsItemsController : Controller
    {

        private readonly IBlogRepository _blogRepository;
        private IConfiguration _configuration { get; }
        private IHostingEnvironment _env;


        public ActionResult List()
        {
            return View();
        }


        public NewsItemsController(IBlogRepository blogRepository, IConfiguration configuration, IHostingEnvironment env)
        {
            _blogRepository = blogRepository;
            _configuration = configuration;
            _env = env;
        }


        public async Task<ActionResult> Index()
        {
            var news = await _blogRepository.GetNews();
            var newsViewModel = news.Select(x => new NewsItemViewModel()
            {
                newsItem = x,
                uploadsFolder = _configuration.GetSection("UploadsFolder").Value,
                blankImageName = _configuration.GetSection("BlankImageName").Value,
                wwwRootPath = _env.WebRootPath

            });
            return View(newsViewModel);
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
        public async  Task<IActionResult> Create([Bind("ID,Headline,Body,Created,NewsCategoryID")] NewsItem newsItem, 
            IList<IFormFile> files)
        {
            try
            {
                var imagesList = new List<Image>();

                if (ModelState.IsValid)

                {

                    if (files.Count(file => file != null) > 0)
                    {
                        var uploadDir = _configuration.GetSection("UploadsFolder").Value;
                        var absolutePath = Path.Combine(_env.WebRootPath, uploadDir);

                        if (!Directory.Exists(absolutePath))
                        {
                            Directory.CreateDirectory(absolutePath);
                        }

                        foreach (var file in files)
                        {

                            var imageName = Path.GetFileName(file.FileName);

                            var newImage = new Image
                            {
                                ImageName = imageName,
                                Extension = Path.GetExtension(imageName)

                            };

                            imagesList.Add(newImage);
                            var imagePath = Path.Combine(absolutePath, newImage.Id + newImage.Extension);
                            
                            using (var fileStream = new FileStream(imagePath, FileMode.Create)) {
                                await file.CopyToAsync(fileStream);
                            }                         
                           
                        }
                    }
                    newsItem.Images = imagesList;
                    await _blogRepository.InsertNewsItemAsync(newsItem);
                    return RedirectToAction("List");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
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
            return View(newsItem);
        }


        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Headline,Body,Created,NewsCategoryID")] NewsItem newsItem, IEnumerable<HttpPostedFileBase> upload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var uploadDir = ConfigurationManager.AppSettings["FilePath"].ToString();
                    var absolutePath = this.HttpContext.Server.MapPath(uploadDir);

                    if (upload.Count(file => file != null) > 0)
                    {
                        if (Directory.Exists(absolutePath))
                        {
                            foreach (var file in upload)
                            {


                                var imageName = Path.GetFileName(file.FileName);

                                var newImage = new MediaTypeNames.Image
                                {
                                    Id = Guid.NewGuid(),
                                    ImageName = imageName,
                                    Extension = Path.GetExtension(imageName),
                                    NewsItemId = newsItem.ID

                                };

                                var imagePath = Path.Combine(Server.MapPath(uploadDir), newImage.Id + newImage.Extension);
                                file.SaveAs(imagePath);
                                repository.SaveImage(newImage);
                            }
                        }
                    }


                    repository.SaveNewsItem(newsItem);
                    return RedirectToAction("List");
                }

            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            PopulateCategoriesDropDownList(newsItem.NewsCategoryID);
            return View(newsItem);
        }*/


        /*[HttpPost]
        public JsonResult DeleteFile(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Result = "Error" });
            }
            try
            {
                Guid guid = new Guid(id);
                MediaTypeNames.Image image = repository.FindImage(guid);
                if (image == null)
                {
                    Response.StatusCode = (int)HttpStatusCode.NotFound;
                    return Json(new { Result = "Error" });
                }

                repository.DeleteImage(image);

                var uploadDir = ConfigurationManager.AppSettings["FilePath"].ToString();
                var path = Path.Combine(Server.MapPath(uploadDir), image.Id + image.Extension);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }*/

        /*public FileResult Download(String p, String d)
        {
            var uploadDir = ConfigurationManager.AppSettings["FilePath"].ToString();
            return File(Path.Combine(Server.MapPath(uploadDir), p), System.Net.Mime.MediaTypeNames.Application.Octet, d);
        }*/



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
            return View(newsItem);
        }


/*        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                repository.DeleteNewsItem(id);
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("Delete", new { id = id });
            }

            return RedirectToAction("List");
        }*/


        private async void  PopulateCategoriesDropDownList(object selectedCategory = null)
        {
            var categoriesQuery = await _blogRepository.GetActualCategories();
            ViewBag.NewsCategoryID = new SelectList(categoriesQuery, "Name", "Name", selectedCategory);
        }


    }
}