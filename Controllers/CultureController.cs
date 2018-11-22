using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace M101DotNet.WebApp.Controllers
{
    public class CultureController : Controller
    {
        
        private readonly List<string> cultures = new List<string>() { "ru", "en" };
        
        public ActionResult LangLinks()
        {
            return View();
        }



        public ActionResult ChangeCulture(string lang)
        {
            string returnUrl = Request.Headers["Referer"].ToString();
            var cookieOptions = new CookieOptions();
             
            
            if (!cultures.Contains(lang))
            {
                lang = "en";
            }
            
/*            string cookie = Request.Cookies["lang"];
            if (cookie != null)
            {  
                Response.Cookies.Append("lang", lang, cookieOptions); 
            }  
            else
            {   */   
                 Response.Cookies.Delete("lang"); 
                cookieOptions.HttpOnly = false;
                cookieOptions.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Append("lang", lang, cookieOptions);
          //  }
   
            return Redirect(returnUrl);
        }
    }
}