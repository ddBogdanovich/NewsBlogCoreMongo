#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bbe5413eb434534a93bbf68f1ee871dfe13074a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Edit), @"mvc.1.0.view", @"/Views/Category/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Edit.cshtml", typeof(AspNetCore.Views_Category_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bbe5413eb434534a93bbf68f1ee871dfe13074a", @"/Views/Category/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsBlogCoreMongo.Models.NewsCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 195, true);
            WriteLiteral("\n\n<div class=\"wrap\">\n    <div class=\"main\">\n        <div class=\"section group\">\n            <div class=\"col span_2_of_3\">\n\n                <div class=\"contact-form\">\n                    <h3>Edit ");
            EndContext();
            BeginContext(241, 10, false);
#line 10 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                        Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(251, 16, true);
            WriteLiteral(" category</h3>\n\n");
            EndContext();
#line 12 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                     using (Html.BeginForm("Edit", "Category", null, FormMethod.Post))
                    {
                        

#line default
#line hidden
            BeginContext(401, 23, false);
#line 14 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(450, 24, false);
#line 15 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(501, 33, false);
#line 17 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(535, 129, true);
            WriteLiteral("                        <div class=\"row\">\n                            <div class=\"col-md-4\">\n                                <h4>");
            EndContext();
            BeginContext(665, 34, false);
#line 20 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                               Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(699, 70, true);
            WriteLiteral("</h4>\n                                <span style=\"font-size: medium\">");
            EndContext();
            BeginContext(770, 35, false);
#line 21 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                                                           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(805, 46, true);
            WriteLiteral("</span>\n                                <span>");
            EndContext();
            BeginContext(852, 82, false);
#line 22 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                                 Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(934, 286, true);
            WriteLiteral(@"</span>


                                <div class=""form-group"">
                                    <span><input type=""submit"" style=""position: relative"" value=""Update""></span>
                                </div>

                            </div>
                        </div>
");
            EndContext();
#line 31 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"

                    }

#line default
#line hidden
            BeginContext(1243, 71, true);
            WriteLiteral("\n                </div>\n                <span style=\"font-size: 13px;\">");
            EndContext();
            BeginContext(1315, 96, false);
#line 35 "/home/dd/NewsBlogASPCoreMongo/Views/Category/Edit.cshtml"
                                          Write(Html.ActionLink("<<< Back to List", "List", "NewsItems", null, new { style = "color: #EB7F1A" }));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 64, true);
            WriteLiteral("</span>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsBlogCoreMongo.Models.NewsCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
