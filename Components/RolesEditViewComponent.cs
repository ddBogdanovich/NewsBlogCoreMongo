namespace NewsBlogCoreMongo.Components
{
    using System.Linq;
    using AspNetCore.Identity.Mongo.Model;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    
    public class RolesEditViewComponent : ViewComponent
    {
        private readonly RoleManager<MongoRole> _roleManager;

        public RolesEditViewComponent(RoleManager<MongoRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Roles = _roleManager.Roles.ToList();

            return View();
        }
    }
}