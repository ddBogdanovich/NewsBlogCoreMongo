#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a3611ac608ee5a646ea48dcab65b20e5c511806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 1 "/home/dd/NewsBlogASPCoreMongo/Views/_ViewImports.cshtml"
using MongoBlog;

#line default
#line hidden
#line 2 "/home/dd/NewsBlogASPCoreMongo/Views/_ViewImports.cshtml"
using MongoBlog.Models;

#line default
#line hidden
#line 3 "/home/dd/NewsBlogASPCoreMongo/Views/_ViewImports.cshtml"
using MongoBlog.HtmlHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3611ac608ee5a646ea48dcab65b20e5c511806", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
  
    ViewBag.Title = Model.Post.Title;

#line default
#line hidden
            BeginContext(43, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(49, 13, false);
#line 5 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(62, 10, true);
            WriteLiteral("</h2>\n\n<p>");
            EndContext();
            BeginContext(73, 17, false);
#line 7 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
Write(Model.Post.Author);

#line default
#line hidden
            EndContext();
            BeginContext(90, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(99, 23, false);
#line 8 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
Write(Model.Post.CreatedAtUtc);

#line default
#line hidden
            EndContext();
            BeginContext(122, 9, true);
            WriteLiteral("</p>\n<p>\n");
            EndContext();
#line 10 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
     foreach (var tag in Model.Post.Tags)
    {

#line default
#line hidden
            BeginContext(179, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 189, "\"", 243, 1);
#line 12 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
WriteAttributeValue("", 196, Url.Action("Posts", "Home", new { tag = tag }), 196, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(246, 3, false);
#line 12 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
                                                             Write(tag);

#line default
#line hidden
            EndContext();
            BeginContext(249, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 13 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
    }

#line default
#line hidden
            BeginContext(260, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(269, 18, false);
#line 15 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
Write(Model.Post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(287, 24, true);
            WriteLiteral("</p>\n\n<h3>Comments</h3>\n");
            EndContext();
#line 18 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
  
    int index = 0;

#line default
#line hidden
#line 21 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
 foreach (var comment in Model.Post.Comments)
{

#line default
#line hidden
            BeginContext(383, 8, true);
            WriteLiteral("    <h5>");
            EndContext();
            BeginContext(392, 14, false);
#line 23 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
   Write(comment.Author);

#line default
#line hidden
            EndContext();
            BeginContext(406, 4, true);
            WriteLiteral(" on ");
            EndContext();
            BeginContext(411, 20, false);
#line 23 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
                      Write(comment.CreatedAtUtc);

#line default
#line hidden
            EndContext();
            BeginContext(431, 13, true);
            WriteLiteral("</h5>\n    <p>");
            EndContext();
            BeginContext(445, 15, false);
#line 24 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
  Write(comment.Content);

#line default
#line hidden
            EndContext();
            BeginContext(460, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 25 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
    if (User.Identity.IsAuthenticated)
    {
        using (Html.BeginForm("CommentLike", "Home"))
        {

#line default
#line hidden
            BeginContext(574, 46, true);
            WriteLiteral("            <input type=\"hidden\" name=\"PostId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 620, "\"", 642, 1);
#line 29 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
WriteAttributeValue("", 628, Model.Post.Id, 628, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(643, 49, true);
            WriteLiteral(" />\n            <input type=\"hidden\" name=\"Index\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 692, "\"", 706, 1);
#line 30 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
WriteAttributeValue("", 700, index, 700, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(707, 69, true);
            WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-default btn-sm\">");
            EndContext();
            BeginContext(777, 13, false);
#line 31 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
                                                            Write(comment.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(790, 16, true);
            WriteLiteral(" Likes</button>\n");
            EndContext();
#line 32 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
        }
    }
    index++;
}

#line default
#line hidden
            BeginContext(837, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 37 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(876, 25, true);
            WriteLiteral("    <h3>Add Comment</h3>\n");
            EndContext();
#line 40 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
    using (Html.BeginForm("NewComment", "Home"))
    {

#line default
#line hidden
            BeginContext(956, 42, true);
            WriteLiteral("        <input type=\"hidden\" name=\"PostId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 998, "\"", 1020, 1);
#line 42 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
WriteAttributeValue("", 1006, Model.Post.Id, 1006, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1021, 156, true);
            WriteLiteral(" />\n        <textarea name=\"Content\"></textarea>\n        <p>\n            <button type=\"submit\" class=\"btn btn-default\">Submit &raquo;</button>\n        </p>\n");
            EndContext();
#line 47 "/home/dd/NewsBlogASPCoreMongo/Views/Home/Post.cshtml"
    }
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
