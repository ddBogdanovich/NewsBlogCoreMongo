#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e08c60f70568ca8dad6bcdf0daa5f65c53288f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RolesEdit_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RolesEdit/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RolesEdit/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RolesEdit_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08c60f70568ca8dad6bcdf0daa5f65c53288f38", @"/Views/Shared/Components/RolesEdit/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RolesEdit_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
  
    
    Layout = null;

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
 if (ViewData["message"] != null)
{

#line default
#line hidden
            BeginContext(66, 37, true);
            WriteLiteral("    <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(104, 19, false);
#line 8 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
                                Write(ViewData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 9 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
}

#line default
#line hidden
            BeginContext(132, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(133, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0d8774e128495eaf24c73984a1155a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(188, 8, true);
            WriteLiteral("\n\n\n<hr>\n");
            EndContext();
#line 15 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
 if (ViewBag.Roles != null && ViewBag.Roles.Count > 0)
{

#line default
#line hidden
            BeginContext(253, 409, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-4"">
            <table class=""table table-bordered table-condensed table-hover brd"">
                <thead>
                <tr>

                    <th><span style=""font-weight: bold"">Role name</span></th>
                    <th><span style=""font-weight: bold"">Description</span></th>
                </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 28 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
                 foreach (var role in ViewBag.Roles)
                {

#line default
#line hidden
            BeginContext(733, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(787, 9, false);
#line 31 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
                       Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(796, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(831, 19, false);
#line 32 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
                       Write(role.NormalizedName);

#line default
#line hidden
            EndContext();
            BeginContext(850, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 34 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
                }

#line default
#line hidden
            BeginContext(900, 73, true);
            WriteLiteral("                </tbody>\n\n            </table>\n        </div>\n    </div>\n");
            EndContext();
#line 40 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(982, 49, true);
            WriteLiteral("    <div class=\"alert alert-info\">No Users</div>\n");
            EndContext();
#line 44 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/Components/RolesEdit/Default.cshtml"
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
