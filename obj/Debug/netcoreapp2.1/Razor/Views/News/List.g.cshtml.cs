#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe3aadfcdd0528e075ef6121d3af1c34e3b059b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_List), @"mvc.1.0.view", @"/Views/News/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/List.cshtml", typeof(AspNetCore.Views_News_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe3aadfcdd0528e075ef6121d3af1c34e3b059b", @"/Views/News/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_News_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsBlogCoreMongo.Models.NewsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::MongoBlog.HtmlHelpers.PageLinkTagHelper __MongoBlog_HtmlHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml"
  
    ViewBag.Title = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml"
 foreach (var p in Model.News)
{
    var resizedBody = p.Body.Split(' ').Take(150);
    p.Body = string.Join(" ", resizedBody);
    

#line default
#line hidden
            BeginContext(278, 42, false);
#line 13 "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml"
Write(await Component.InvokeAsync("NewsItem", p));

#line default
#line hidden
            EndContext();
#line 13 "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml"
                                                  //change to renderpartial async
}

#line default
#line hidden
            BeginContext(358, 34, true);
            WriteLiteral("\r\n<div class=\"page_links\">\r\n\r\n    ");
            EndContext();
            BeginContext(392, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29823d3191214bb1be468b5ddcb1635a", async() => {
            }
            );
            __MongoBlog_HtmlHelpers_PageLinkTagHelper = CreateTagHelper<global::MongoBlog.HtmlHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__MongoBlog_HtmlHelpers_PageLinkTagHelper);
#line 18 "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml"
__MongoBlog_HtmlHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MongoBlog_HtmlHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MongoBlog_HtmlHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__MongoBlog_HtmlHelpers_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "MongoBlog.HtmlHelpers.PageLinkTagHelper", "PageUrlValues"));
            }
#line 18 "/home/dd/NewsBlogASPCoreMongo/Views/News/List.cshtml"
__MongoBlog_HtmlHelpers_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __MongoBlog_HtmlHelpers_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(508, 163, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"clear\"></div>\r\n    <div class=\"page_bottom\">\r\n        <p>Back To : <a href=\"#\">Top</a> | <a href=\"News/List\">Home</a></p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsBlogCoreMongo.Models.NewsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
