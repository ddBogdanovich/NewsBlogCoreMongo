#pragma checksum "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff73de9eba673ed53b43ce06d7b6de4d8e50448f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsItems_Create), @"mvc.1.0.view", @"/Views/NewsItems/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsItems/Create.cshtml", typeof(AspNetCore.Views_NewsItems_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff73de9eba673ed53b43ce06d7b6de4d8e50448f", @"/Views/NewsItems/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsItems_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsBlogCoreMongo.Models.NewsItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/daterangeHelper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(110, 219, true);
            WriteLiteral("\r\n<div class=\"wrap\">\r\n    <div class=\"main\">\r\n        <div class=\"section group\">\r\n\r\n            <div class=\"col span_2_of_3\">\r\n                <div class=\"contact-form\">\r\n                    <h3>Create News item</h3>\r\n");
            EndContext();
#line 13 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                     using (Html.BeginForm("Create", "NewsItems", null, FormMethod.Post, true, new { enctype = "multipart/form-data" }))
                    {
                        

#line default
#line hidden
            BeginContext(515, 23, false);
#line 15 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(540, 32, true);
            WriteLiteral("                        <hr />\r\n");
            EndContext();
            BeginContext(597, 64, false);
#line 17 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(669, 117, true);
            WriteLiteral("                        <div class=\"row\">\r\n                           \r\n                                <span><label>");
            EndContext();
            BeginContext(787, 47, false);
#line 23 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                        Write(Html.LabelFor(model => model.newsItem.Headline));

#line default
#line hidden
            EndContext();
            BeginContext(834, 55, true);
            WriteLiteral("</label></span>\r\n                                <span>");
            EndContext();
            BeginContext(890, 48, false);
#line 24 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                 Write(Html.EditorFor(model => model.newsItem.Headline));

#line default
#line hidden
            EndContext();
            BeginContext(938, 41, true);
            WriteLiteral("</span>\r\n                                ");
            EndContext();
            BeginContext(980, 95, false);
#line 25 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.newsItem.Headline, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 67, true);
            WriteLiteral("\r\n                           \r\n                            </div>\r\n");
            EndContext();
            BeginContext(1146, 85, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <span>");
            EndContext();
            BeginContext(1232, 43, false);
#line 31 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                 Write(Html.LabelFor(model => model.newsItem.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 47, true);
            WriteLiteral("</span>\r\n                                <span>");
            EndContext();
            BeginContext(1323, 44, false);
#line 32 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                 Write(Html.EditorFor(model => model.newsItem.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 41, true);
            WriteLiteral("</span>\r\n                                ");
            EndContext();
            BeginContext(1409, 91, false);
#line 33 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.newsItem.Body, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
            BeginContext(1542, 183, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <hr>\r\n                                <div class=\"col-md-4\">\r\n                                    <span>");
            EndContext();
            BeginContext(1726, 51, false);
#line 40 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                     Write(Html.LabelFor(model => model.newsItem.CreatedAtUtc));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 41 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                       ViewContext.ClientValidationEnabled = false; 

#line default
#line hidden
            BeginContext(1873, 63, true);
            WriteLiteral("                                    <span class=\"my-date-time\">");
            EndContext();
            BeginContext(1937, 52, false);
#line 42 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                                          Write(Html.EditorFor(model => model.newsItem.CreatedAtUtc));

#line default
#line hidden
            EndContext();
            BeginContext(1989, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 43 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                       ViewContext.ClientValidationEnabled = true; 

#line default
#line hidden
            BeginContext(2084, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2121, 99, false);
#line 44 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.newsItem.CreatedAtUtc, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 80, true);
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n");
            EndContext();
            BeginContext(2911, 501, true);
            WriteLiteral(@"                            <div class=""row"">
                                <hr>

                                <label class=""control-label"">Select File</label>
                                <div class=""col-md-12"">
                                    <input id=""input-44"" name=""upload"" type=""file"" multiple class=""file-loading"">
                                    <div id=""errorBlock"" class=""help-block""></div>
                                </div>
                            </div>
");
            EndContext();
            BeginContext(3418, 152, true);
            WriteLiteral("                            <div>\r\n                                <span><input type=\"submit\" value=\"Save\"></span>\r\n                            </div>\r\n");
            EndContext();
#line 78 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                    }

#line default
#line hidden
            BeginContext(3593, 98, true);
            WriteLiteral("                    <div class=\"clear\"></div>\r\n                    <span style=\"font-size: 13px;\">");
            EndContext();
            BeginContext(3692, 83, false);
#line 80 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                                              Write(Html.ActionLink("<<< Back to List", "List", null, new { style = "color: #EB7F1A" }));

#line default
#line hidden
            EndContext();
            BeginContext(3775, 113, true);
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3911, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3917, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b06426a54e2a420b88b90586560abadc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3969, 1606, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#input-44"").fileinput({
                uploadUrl: 'asdf/adf',
                showCaption: true,
                maxFilePreviewSize: 10240,
                maxFileCount: 5,
                allowedFileExtensions: [""jpg"", ""gif"", ""png""],
                elErrorContainer: ""#errorBlock"",
                showUpload: false,
                layoutTemplates: {
                    main1: ""{preview}\n"" +
                    ""<div class=\'input-group {class}\' style=\""position: inherit\"">\n"" +
                    ""   <div class=\'input-group-btn\'>\n"" +
                    ""       {browse}\n"" +
                    ""       {remove}\n"" +
                    ""   </div>\n"" +
                    ""   {caption}\n"" +
                    ""</div>"",
                    actions: '<div class=""file-actions"">\n' +
                    '    <div class=""file-footer-buttons"">\n' +
                    '        {delete} {zoom}");
                WriteLiteral(@"' +
                    '    </div>\n' +
                    '    {drag}\n' +
                    '    <div class=""file-upload-indicator"" title=""{indicatorTitle}"">{indicator}</div>\n' +
                    '    <div class=""clearfix""></div>\n' +
                    '</div>',

                }
            });

            $('.deleteItem').click(function (e) {
                e.preventDefault();
                var $ctrl = $(this);
                if (confirm('Do you really want to delete this file?')) {
                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(5576, 24, false);
#line 130 "/home/dd/NewsBlogCoreMongoDb/Views/NewsItems/Create.cshtml"
                         Write(Url.Action("DeleteFile"));

#line default
#line hidden
                EndContext();
                BeginContext(5600, 706, true);
                WriteLiteral(@"',
                        type: 'POST',
                        data: { id: $(this).data('id') }
                    }).done(function (data) {
                        if (data.Result == ""OK"") {
                            $ctrl.closest('li').remove();
                            $ctrl.closest('div').remove();
                        }
                        else if (data.Result.Message) {
                            alert(data.Result.Message);
                        }
                    }).fail(function () {
                        alert(""There is something wrong. Please try again."");
                    })

                }
            });
        }
    )
    </script>

");
                EndContext();
            }
            );
            BeginContext(6357, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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