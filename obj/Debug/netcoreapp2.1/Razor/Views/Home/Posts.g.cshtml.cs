#pragma checksum "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58b023ebc4c47c106050c3fa9e9dac02630f3d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Posts), @"mvc.1.0.view", @"/Views/Home/Posts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Posts.cshtml", typeof(AspNetCore.Views_Home_Posts))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/dd/NewsBlogCoreMongoDb/Views/_ViewImports.cshtml"
using MongoBlog;

#line default
#line hidden
#line 2 "/home/dd/NewsBlogCoreMongoDb/Views/_ViewImports.cshtml"
using MongoBlog.Models;

#line default
#line hidden
#line 3 "/home/dd/NewsBlogCoreMongoDb/Views/_ViewImports.cshtml"
using MongoBlog.HtmlHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58b023ebc4c47c106050c3fa9e9dac02630f3d6", @"/Views/Home/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
  
    ViewBag.Title = "All Posts";

#line default
#line hidden
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
 foreach (var post in Model)
{

#line default
#line hidden
            BeginContext(70, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(79, 10, false);
#line 7 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
   Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(89, 4, true);
            WriteLiteral(" by ");
            EndContext();
            BeginContext(94, 11, false);
#line 7 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
                  Write(post.Author);

#line default
#line hidden
            EndContext();
            BeginContext(105, 4, true);
            WriteLiteral(" on ");
            EndContext();
            BeginContext(110, 17, false);
#line 7 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
                                  Write(post.CreatedAtUtc);

#line default
#line hidden
            EndContext();
            BeginContext(127, 13, true);
            WriteLiteral("</h2>\n    <p>");
            EndContext();
            BeginContext(141, 65, false);
#line 8 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
  Write(post.Content.Substring(0, Math.Min(post.Content.Length - 1, 200)));

#line default
#line hidden
            EndContext();
            BeginContext(206, 45, true);
            WriteLiteral("</p>\n    <p><a class=\"btn btn-default btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 251, "\"", 307, 1);
#line 9 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
WriteAttributeValue("", 258, Url.Action("Post", "Home", new { id = post.Id }), 258, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(308, 22, true);
            WriteLiteral(">View &raquo;</a></p>\n");
            EndContext();
#line 10 "/home/dd/NewsBlogCoreMongoDb/Views/Home/Posts.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
