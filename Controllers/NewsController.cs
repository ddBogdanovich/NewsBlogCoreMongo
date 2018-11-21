using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using M101DotNet.WebApp.Models;
using M101DotNet.WebApp.Models.Home;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MongoBlog.Repository;
using NewsBlogCoreMongo.Models;

namespace M101DotNet.WebApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        
        private int Pagesize = 5;

        public NewsController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        
        public async Task<ActionResult> List(string category, int page = 1)
        {
       
            Expression<Func<NewsItem, bool>> filter = x => true;

            if (!string.IsNullOrWhiteSpace(category))
            {
                filter = x => x.Categories.Contains(category);
            }
            
            NewsListViewModel model = new NewsListViewModel
            {
                News = await _blogRepository.GetNewsFilered(page, Pagesize, category),
                  
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
        
        
        
        
    }
}