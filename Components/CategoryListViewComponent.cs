using NewsBlogCoreMongo.Persistence;

namespace NewsBlogCoreMongo.Components
{
    using Microsoft.AspNetCore.Mvc;

    public class CategoryListViewComponent : ViewComponent
    {
        private readonly IBlogRepository _repository;

        public CategoryListViewComponent(IBlogRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(string category = null)
        {
            ViewBag.SelectedCategory = category;

            var categories = _repository.GetActualCategories().Result;

            return View(categories);
        }
    }
}