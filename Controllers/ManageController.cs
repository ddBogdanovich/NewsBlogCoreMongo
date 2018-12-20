namespace NewsBlogCoreMongo.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using AspNetCore.Identity.Mongo.Model;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Auth;
    

    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<MongoRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ManageController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<MongoRole> roleManager
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        #region Roles

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> UpdateUsersRole(string id, string role)
        {
            var roles = _roleManager.Roles.Select(m => m.Name).ToList();
            if (!string.IsNullOrEmpty(role) && roles.Contains(role))
            {
                var user = await _userManager.FindByIdAsync(id);

                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid User ID");
                    return ViewComponent("UsersEdit");
                }

                var currentUsersRole = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
                await _userManager.RemoveFromRoleAsync(user, currentUsersRole);
                var result = await _userManager.AddToRoleAsync(user, role);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                else
                {
                    ViewData["message"] = "Role Changed Successful";
                }
            }

            return RedirectToAction("Edit", id);
        }

        #endregion

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return Redirect("~/Manage");
            }

            var roles = _roleManager.Roles.ToList();
            var currentUsersRole = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            ViewBag.CurrentRole = currentUsersRole;
            ViewBag.Roles = new SelectList(roles, "Name", "Name", currentUsersRole);
            ;
            return View("Edit", user);
        }


        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return NotFound();
            }
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (id != null)
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    var result = await _userManager.DeleteAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("List", "NewsItems");
                    }
                }
            }

            return BadRequest();
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Update(ApplicationUser model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid User ID");
                return ViewComponent("UsersEdit");
            }

            user.UserName = model.UserName;
            user.Email = model.Email;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            else
            {
                ViewData["message"] = "Update Successful";
            }

            return RedirectToAction("Edit", model.Id);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(string id, string oldpassword, string newpassword)
        {
            var user = await _userManager.FindByIdAsync(id);
            var result = await _userManager.ChangePasswordAsync(user, oldpassword, newpassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            else
            {
                ViewData["message"] = "Password changed Successful";
            }

            return RedirectToAction("Edit", id);
        }
    }
}