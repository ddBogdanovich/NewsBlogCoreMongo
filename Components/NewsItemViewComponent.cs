using Microsoft.AspNetCore.Hosting;

namespace MongoBlog.Components
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using NewsBlogCoreMongo.Models;

    
    
    public class NewsItemViewComponent : ViewComponent
    {
        private IConfiguration _configuration { get; }
        private IHostingEnvironment _env;

        public NewsItemViewComponent( IConfiguration configuration, IHostingEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        public IViewComponentResult Invoke(NewsItem item)
        {
            var blankImage = _configuration.GetSection("BlankImageName").Value;
            var uploadsFolder = _configuration.GetSection("UploadsFolder").Value;

            var viewModel =  new NewsItemViewModel()
            {
                newsItem = item,
                blankImageName = blankImage,
                uploadsFolder = uploadsFolder,
                wwwRootPath = _env.WebRootPath
            };
       
            return View(viewModel);
        }        
    }


}


