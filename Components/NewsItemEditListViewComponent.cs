using System.Linq;
using System.Threading.Tasks;

namespace MongoBlog.Components
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Repository;
    using NewsBlogCoreMongo.Models;


    public class NewsItemEditListViewComponent : ViewComponent
    {
        private readonly IBlogRepository _blogRepository;
        private IConfiguration _configuration { get; }
        private IHostingEnvironment _env;

        public NewsItemEditListViewComponent(IBlogRepository blogRepository, IConfiguration configuration,
            IHostingEnvironment env)
        {
            _blogRepository = blogRepository;
            _configuration = configuration;
            _env = env;
        }

        public IViewComponentResult Invoke()
        {
            var blankImage = _configuration.GetSection("BlankImageName").Value;
            var uploadsFolder = _configuration.GetSection("UploadsFolder").Value;

            var news = _blogRepository.GetNews().Result;
            var newsViewModel = news.Select(x => new NewsItemViewModel
            {
                newsItem = x,
                uploadsFolder = uploadsFolder,
                wwwRootPath = _env.WebRootPath
            });
            return View(newsViewModel);
        }
    }
}