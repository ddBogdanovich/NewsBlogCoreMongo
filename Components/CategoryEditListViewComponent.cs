using NewsBlogCoreMongo.Persistence;

namespace NewsBlogCoreMongo.Components
{
    using Microsoft.AspNetCore.Mvc;


    public class CategoryEditListViewComponent : ViewComponent
    {
        private readonly IBlogRepository _blogRepository;

        public CategoryEditListViewComponent(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_blogRepository.GetExistingCategories().Result);
        }
    }
}