using NewsBlogCoreMongo.Auth;

namespace NewsBlogCoreMongo.Components
{
    using System.Linq;
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