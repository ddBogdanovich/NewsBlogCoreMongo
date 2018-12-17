namespace M101DotNet.WebApp.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Linq.Expressions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using MongoBlog.Repository;
    using NewsBlogCoreMongo.Models;
    using Microsoft.Extensions.Configuration;

    [Authorize]
    public class NewsController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        
        private int Pagesize = 5;
        private IConfiguration _configuration { get; }
        private IHostingEnvironment _env;

        public NewsController(IBlogRepository blogRepository, IConfiguration configuration, IHostingEnvironment env)
        {
            _blogRepository = blogRepository;
            _configuration = configuration;
            _env = env;
        }
        
        
        public async Task<ActionResult> List(string category, int page = 1)
        {
       
            Expression<Func<NewsItem, bool>> filter = x => true;

            if (!string.IsNullOrWhiteSpace(category))
            {
                filter = x => x.Category == category;
            }
            
            var model = new NewsListViewModel
            {
                News = await _blogRepository.GetNewsFiltered(page, Pagesize, category),
                  
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = Pagesize,
                    TotalItems =  await _blogRepository.GetNewsCount(filter)
                },
             
                CurrentCategory = category
            };
            return View(model);
            
        }
        
        
        public ActionResult Demo()
        {
            return View("DemoPage");
        }
        
        
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var newsItem = _blogRepository.FindNewsItem(id).Result;

            if (newsItem == null)
            {
                return NotFound();
            }

            var model = new NewsItemViewModel()
            {
                newsItem = newsItem,
                uploadsFolder = _configuration.GetSection("UploadsFolder").Value,
                blankImageName = _configuration.GetSection("BlankImageName").Value,
                wwwRootPath = _env.WebRootPath

            };
            
            return View(model);
        }
               
               
        public ActionResult Contact() 
        {
            return View();
        }               
    }
}