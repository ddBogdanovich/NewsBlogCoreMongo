#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5358046670056d0a09095949739f375a92acaec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NewsItemEditList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NewsItemEditList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/NewsItemEditList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_NewsItemEditList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5358046670056d0a09095949739f375a92acaec", @"/Views/Shared/Components/NewsItemEditList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NewsItemEditList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewsBlogCoreMongo.Models.NewsItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NewsItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style-attribute", "width: 120px; height: 100px; margin-right: 5px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::MongoBlog.HtmlHelpers.ImageLinkTagHelper __MongoBlog_HtmlHelpers_ImageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(88, 37, true);
            WriteLiteral("\n<hr>\n<p class=\"btn-create-new\">\n    ");
            EndContext();
            BeginContext(125, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a1ec748a0e41b78441573858dc87ab", async() => {
                BeginContext(206, 13, true);
                WriteLiteral("Create New + ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 144, true);
            WriteLiteral("\n</p>\n\n<table class=\"table table-bordered table-condensed table-hover brd\">\n    <tr>\n\n        <th>\n            <span style=\"font-weight: bold\"> ");
            EndContext();
            BeginContext(368, 49, false);
#line 16 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
                                        Write(Html.DisplayNameFor(model => model.newsItem.Body));

#line default
#line hidden
            EndContext();
            BeginContext(417, 79, true);
            WriteLiteral("</span>\n        </th>\n        <th>\n            <span style=\"font-weight: bold\">");
            EndContext();
            BeginContext(497, 57, false);
#line 19 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
                                       Write(Html.DisplayNameFor(model => model.newsItem.CreatedAtUtc));

#line default
#line hidden
            EndContext();
            BeginContext(554, 119, true);
            WriteLiteral("</span>\n        </th>\n        <th>\n            <span style=\"font-weight: bold\">Actions</span>\n        </th>\n    </tr>\n\n");
            EndContext();
#line 26 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
     foreach (var item in Model)
    {
        var resizedBody = item.newsItem.Body.Split(' ').Take(150);
        item.newsItem.Body = string.Join(" ", resizedBody);

#line default
#line hidden
            BeginContext(839, 80, true);
            WriteLiteral("        <tr>\n            <td>\n                <span style=\"font-weight: bolder\">");
            EndContext();
            BeginContext(920, 22, false);
#line 32 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
                                             Write(item.newsItem.Headline);

#line default
#line hidden
            EndContext();
            BeginContext(942, 45, true);
            WriteLiteral("</span>\n                <hr>\n                ");
            EndContext();
            BeginContext(988, 18, false);
#line 34 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
           Write(item.newsItem.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 40, true);
            WriteLiteral(";\n                <hr/>\n                ");
            EndContext();
            BeginContext(1046, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6c2ab6a93704e6b99d83e3fc1831da8", async() => {
            }
            );
            __MongoBlog_HtmlHelpers_ImageLinkTagHelper = CreateTagHelper<global::MongoBlog.HtmlHelpers.ImageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__MongoBlog_HtmlHelpers_ImageLinkTagHelper);
#line 36 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
__MongoBlog_HtmlHelpers_ImageLinkTagHelper.model = item;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __MongoBlog_HtmlHelpers_ImageLinkTagHelper.model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MongoBlog_HtmlHelpers_ImageLinkTagHelper.StyleAttribute = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1150, 72, true);
            WriteLiteral("             \n            </td>\n            <td>\n                <label>");
            EndContext();
            BeginContext(1223, 26, false);
#line 39 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
                  Write(item.newsItem.CreatedAtUtc);

#line default
#line hidden
            EndContext();
            BeginContext(1249, 107, true);
            WriteLiteral("</label>\n            </td>\n            <td>\n                <p class=\"btn-create-new\">\n                    ");
            EndContext();
            BeginContext(1356, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de987cb465864b3ba61f1e76450d0d6a", async() => {
                BeginContext(1468, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
                                                                      WriteLiteral(item.newsItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1476, 38, true);
            WriteLiteral("\n                </p>\n                ");
            EndContext();
            BeginContext(1514, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "160598dcd9fb42c4ba25b1c5935b18eb", async() => {
                BeginContext(1627, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
                                                                    WriteLiteral(item.newsItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1637, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 48 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/NewsItemEditList/Default.cshtml"
    }

#line default
#line hidden
            BeginContext(1676, 143, true);
            WriteLiteral("\n</table>\n\n<div class=\"clear\"></div>\n<div class=\"page_bottom\">\n    <p>Back To : <a href=\"#\">Top</a> | <a href=\"News/List\">Home</a></p>\n</div>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewsBlogCoreMongo.Models.NewsItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
