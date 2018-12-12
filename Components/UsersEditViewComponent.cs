namespace MongoBlog.Components
{

    using System.Linq;
    using M101DotNet.WebApp.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class UsersEditViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersEditViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Users = _userManager.Users.ToArray();

            return View();
        }
    }
}