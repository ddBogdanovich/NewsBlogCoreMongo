/*using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using MongoDB.Driver;
using M101DotNet.WebApp.Models;
using M101DotNet.WebApp.Models.Account;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace M101DotNet.WebApp.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }*/

            //  var blogContext = new BlogContext();
            //   var user = await blogContext.Users.Find(x => x.Email == model.Email).SingleOrDefaultAsync();
            //if (user == null)
            // {
            //   ModelState.AddModelError("Email", "Email address has not been registered.");
            //   return View(model);
            //}

           // var claims = new ClaimsIdentity(new[]
               // {
              //      new Claim(ClaimTypes.Name, user.Name),
            //        new Claim(ClaimTypes.Email, user.Email)
            //    },
          //      "ApplicationCookie");
//
        //    var claimsIdentity = new ClaimsIdentity(
        //        claims, CookieAuthenticationDefaults.AuthenticationScheme);
           // var context = Request.GetOwinContext();
         //   var authManager = Request.HttpContext.Authentication;
           // authManager.SignInAsync(identity);


/*            return Redirect(GetRedirectUrl(model.ReturnUrl));
        }

        [HttpPost]
        public ActionResult Logout()
        {
            var authManager = Request.HttpContext.Authentication;
           // var authManager = context.Authentication;

            authManager.SignOutAsync("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //   var blogContext = new BlogContext();
            //   var user = new User
            //     {
            //         Name = model.Name,
            //         Email = model.Email
            //    };

            //    await blogContext.Users.InsertOneAsync(user);
            return RedirectToAction("Index", "Home");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
          //  AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return  RedirectToAction("List", "News");
        }
    }
}*/