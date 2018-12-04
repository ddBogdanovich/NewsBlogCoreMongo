using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using MongoBlog.Repository;
using NewsBlogCoreMongo.Models;

namespace M101DotNet.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        
        public CategoryController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        
                /*[Authorize]*/
        public async Task<IActionResult> CategoryList(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = await _blogRepository.GetActualCategories();

            return PartialView("Main", categories);
        }


        /*[Authorize(Roles = "Administrator, Moderator")]*/
        public async Task<IActionResult> Index()
        {
            return View(await _blogRepository.GetExistingCategories());
        }

        /*[Authorize(Roles = "Administrator, Moderator")]*/
        public ActionResult Create()
        {
            return View();
        }


        /*[Authorize(Roles = "Administrator, Moderator")]*/
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

        /*[Authorize(Roles = "Administrator, Moderator")]*/
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

        /*[Authorize(Roles = "Administrator, Moderator")]*/
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

        /*[Authorize(Roles = "Administrator, Moderator")]*/
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


        /*[Authorize(Roles = "Administrator, Moderator")]*/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            _blogRepository.DeleteCategoryItem(id);
            return RedirectToAction("List", "NewsItems");
        }
        
    }
}