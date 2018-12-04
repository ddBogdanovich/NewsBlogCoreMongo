#pragma checksum "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7440ba60129b61ea479194f9845fed04ae1a3274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsItems_Delete), @"mvc.1.0.view", @"/Views/NewsItems/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsItems/Delete.cshtml", typeof(AspNetCore.Views_NewsItems_Delete))]
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
#line 1 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
using System.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7440ba60129b61ea479194f9845fed04ae1a3274", @"/Views/NewsItems/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsItems_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsBlogCoreMongo.Models.NewsItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 61, true);
            WriteLiteral("using System.Net;\r\nusing System.Web;\r\nusing System.Web.Mvc;\r\n");
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
  
   
    var resizedBody = @Model.newsItem.Body.Split(' ').Take(150);
    Model.newsItem.Body = string.Join(" ", resizedBody);

#line default
#line hidden
            BeginContext(279, 249, true);
            WriteLiteral("\r\n\r\n\r\n<h3 style=\"color: crimson\">Are you sure you want to delete this?</h3>\r\n<div>\r\n\r\n    <table class=\"table table-bordered table-condensed table-hover brd\">\r\n\r\n\r\n        <tr>\r\n\r\n            <td>\r\n                <span style=\"font-weight: bolder\"> ");
            EndContext();
            BeginContext(529, 54, false);
#line 24 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
                                              Write(Html.DisplayFor(modelItem => @Model.newsItem.Headline));

#line default
#line hidden
            EndContext();
            BeginContext(583, 47, true);
            WriteLiteral("</span>\r\n                <hr>\r\n                ");
            EndContext();
            BeginContext(631, 30, false);
#line 26 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
           Write(Model.newsItem.Body.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(661, 27, true);
            WriteLiteral(";\r\n                <hr>\r\n\r\n");
            EndContext();
#line 29 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
                 if (@Model.newsItem.Images != null && @Model.newsItem.Images.Count() > 0)
                {
                    

#line default
#line hidden
#line 40 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
                           
                        
                    }

#line default
#line hidden
            BeginContext(1432, 74, true);
            WriteLiteral("                }\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1507, 58, false);
#line 47 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
           Write(Html.DisplayFor(modelItem => @Model.newsItem.CreatedAtUtc));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 50 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
            BeginContext(1687, 23, false);
#line 52 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1712, 195, true);
            WriteLiteral("                    <div class=\"form-actions no-color\">\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" style=\"float: inherit\" />\r\n                    </div>\r\n");
            EndContext();
#line 56 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
                }

#line default
#line hidden
            BeginContext(1926, 129, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n\r\n\r\n    </table>\r\n\r\n   \r\n\r\n\r\n    <div class=\"clear\"></div>\r\n    <span style=\"font-size: 13px;\">");
            EndContext();
            BeginContext(2056, 83, false);
#line 67 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Delete.cshtml"
                              Write(Html.ActionLink("<<< Back to List", "List", null, new { style = "color: #EB7F1A" }));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 23, true);
            WriteLiteral("</span>\r\n\r\n\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsBlogCoreMongo.Models.NewsItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591