using System.Globalization;
using AspNetCore.Identity.Mongo;
using AspNetCore.Identity.Mongo.Model;
using Example.CustomUser.Services;
using M101DotNet.WebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoBlog.Core;
using MongoBlog.Models;
using MongoBlog.Repository;

namespace MongoBlog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
             
/*            services.AddIdentityMongoDbProvider<ApplicationUser, MongoRole>(options =>
            {
                options.ConnectionString = "mongodb://127.0.0.1:27017/blog";
            });*/
            
            services.AddOptions();
            services.AddTransient<IImageService, ImageService>();
            services.AddTransient<IImageStorage, FileSystemImageStorage>();
            services.AddSingleton<IBlogRepository, BlogRepository>();
            services.AddTransient<IEmailSender, EmailSender>();
            
            services.Configure<Settings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoConnection:Database").Value;
            });
            
            services
                .AddLocalization(options => options.ResourcesPath = "Resources");
            
            
            services.AddIdentityMongoDbProvider<ApplicationUser, MongoRole>(identityOptions =>
            {
                identityOptions.Password.RequiredLength = 6;
                identityOptions.Password.RequireLowercase = true;
                identityOptions.Password.RequireUppercase = true;
                identityOptions.Password.RequireNonAlphanumeric = true;
                identityOptions.Password.RequireDigit = true;
            }, options =>
            {
                options.ConnectionString = "mongodb://127.0.0.1:27017/blog";
            });
            
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMvc()
                .AddViewLocalization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            services.AddWebOptimizer(pipeline =>
            {
                pipeline.AddJavaScriptBundle("/bundles/bootstrapBundle.min.js", 
                    "lib/Scripts/bootstrap.js", 
                    "lib/Scripts/respond.js",
                    "lib/tether/dist/js/tether.min.js",                
                    "lib/Scripts/jquery.fancybox.js",
                    "lib/Scripts/jquery.mousewheel-3.0.6.pack.js",
                    "lib/Scripts/jquery.bxslider.js");

                pipeline.AddJavaScriptBundle("/bundles/jsElements.js",

                    "lib/Scripts/moment.js",
                    "lib/Scripts/daterangepicker.js",
                    "lib/Scripts/fileinput.js"
                );

                pipeline.AddJavaScriptBundle("/bundles/jqval.js",

                    "lib/Scripts/jquery.validate.js"
                );
                
                pipeline.AddJavaScriptBundle("/bundles/modernizr.js",

                    "lib/Scripts/modernizr-2.8.3.js"
                );
                
                
                pipeline.AddCssBundle("/bundles/jsElements.css",
                    "css_/jsElementsCss/daterangepicker.css",
                    "css_/jsElementsCss/bootstrap-fileinput/css/fileinput.css"
                );     
                
                

                pipeline.AddCssBundle("/bundles/content.css",
                    "css_/bootstrap.css",
                    "css_/zocial.css",
                    "css_/style.css",
                    "css_/Site.css",
                    "css_/jquery.fancybox.css",
                    "css_/jquery.bxslider.css"
                );
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            
            app.UseDeveloperExceptionPage();
 
            var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ru"),
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("ru"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });
            
            app.UseHttpsRedirection();

            app.UseCookiePolicy();
            app.UseWebOptimizer();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "Error", template: "Error",
                    defaults: new { controller = "Error", action = "Error" });

                routes.MapRoute(
                    name: null,
                    template: "{category}/Page{productPage:int}",
                    defaults: new { controller = "News", action = "List" }
                );

                routes.MapRoute(
                    name: null,
                    template: "Page{productPage:int}",
                    defaults: new { controller = "News", action = "List", productPage = 1 }
                );

                routes.MapRoute(
                    name: null,
                    template: "{category}",
                    defaults: new { controller = "News", action = "List", productPage = 1 }
                );

                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new { controller = "News", action = "List", productPage = 1 });

                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });
        }
    }
}