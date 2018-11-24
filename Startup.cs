using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.Mongo;
using M101DotNet.WebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
             
            services.AddIdentityMongoDbProvider<ApplicationUser>(options =>
            {
                options.ConnectionString = "mongodb://127.0.0.1:27017/blog";
            });
            
            services.AddOptions();
            services.AddSingleton<IBlogRepository, BlogRepository>();
            
            services.Configure<Settings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoConnection:Database").Value;
            });
            
            services
                .AddLocalization(options => options.ResourcesPath = "Resources");
            
            
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
            
            
            services.AddWebOptimizer(pipeline =>
                pipeline.AddJavaScriptBundle("~/js/scripts.js", 
                    "~/lib/bootstrap/dist/js/bootstrap.js",
                    "~/lib/jquery/dist/respond.min.js",
                    "~/lib/jquery/dist/jquery.fancybox.js",
                    "~/lib/jquery/dist/jquery.mousewheel-3.0.6.pack.js",
                    "~/lib/jquery/dist/jquery.bxslider.js")                                     
                );


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

            app.UseHttpsRedirection();

            app.UseCookiePolicy();

            app.UseWebOptimizer();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}