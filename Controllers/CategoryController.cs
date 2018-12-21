namespace NewsBlogCoreMongo.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Models;
    using Persistence; 

    public class CategoryController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public CategoryController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }


        [Authorize]
        public async Task<IActionResult> CategoryList(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = await _blogRepository.GetActualCategories();

            return PartialView("Main", categories);
        }


        [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
        public ActionResult Create()
        {
            return View();
        }


        [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name")] NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.SaveCategoryItem(newsCategory);
                return RedirectToAction("List", "NewsItems");
            }

            return View(newsCategory);
        }


        [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var newsCategory = await _blogRepository.GetCategory(id);
            if (newsCategory == null)
            {
                return NotFound();
            }

            return View(newsCategory);
        }


        [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,Name")] NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.UpdateCategoryItem(newsCategory);
                return RedirectToAction("List", "NewsItems");
            }

            return View(newsCategory);
        }


        [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var newsCategory = await _blogRepository.GetCategory(id);
            if (newsCategory == null)
            {
                return NotFound();
            }

            return View(newsCategory);
        }


        [Authorize(Roles = "ADMINISTRATOR, MODERATOR")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            _blogRepository.DeleteCategoryItem(id);
            return RedirectToAction("List", "NewsItems");
        }
    }
}