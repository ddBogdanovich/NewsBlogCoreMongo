namespace MongoBlog.Components
{
    using Microsoft.AspNetCore.Mvc;
    using MongoBlog.Repository;
    using System.Linq;
    using System.Threading.Tasks;
    
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

            return View(categories.Select(x => x.Name).ToList());
        }        
    }
}