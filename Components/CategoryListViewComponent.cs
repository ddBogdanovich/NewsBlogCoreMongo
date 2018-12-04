namespace MongoBlog.Components
{
    using Microsoft.AspNetCore.Mvc;
    using Repository;
    using System.Linq;
    
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