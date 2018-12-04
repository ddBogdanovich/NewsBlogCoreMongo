#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f42d1d00f348b1f535bb51d15805810482f7f81"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f42d1d00f348b1f535bb51d15805810482f7f81", @"/Views/NewsItems/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsItems_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsBlogCoreMongo.Models.NewsItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 219, true);
            WriteLiteral("\r\n<div class=\"wrap\">\r\n    <div class=\"main\">\r\n        <div class=\"section group\">\r\n\r\n            <div class=\"col span_2_of_3\">\r\n                <div class=\"contact-form\">\r\n                    <h3>Create News item</h3>\r\n");
            EndContext();
#line 10 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                     using (Html.BeginForm("Create", "NewsItems", null, FormMethod.Post, true, new { enctype = "multipart/form-data" }))
                    {
                        

#line default
#line hidden
            BeginContext(456, 23, false);
#line 12 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(481, 32, true);
            WriteLiteral("                        <hr />\r\n");
            EndContext();
            BeginContext(538, 64, false);
#line 14 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(610, 117, true);
            WriteLiteral("                        <div class=\"row\">\r\n                           \r\n                                <span><label>");
            EndContext();
            BeginContext(728, 47, false);
#line 20 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                        Write(Html.LabelFor(model => model.newsItem.Headline));

#line default
#line hidden
            EndContext();
            BeginContext(775, 55, true);
            WriteLiteral("</label></span>\r\n                                <span>");
            EndContext();
            BeginContext(831, 48, false);
#line 21 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                 Write(Html.EditorFor(model => model.newsItem.Headline));

#line default
#line hidden
            EndContext();
            BeginContext(879, 41, true);
            WriteLiteral("</span>\r\n                                ");
            EndContext();
            BeginContext(921, 95, false);
#line 22 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.newsItem.Headline, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 67, true);
            WriteLiteral("\r\n                           \r\n                            </div>\r\n");
            EndContext();
            BeginContext(1087, 85, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <span>");
            EndContext();
            BeginContext(1173, 43, false);
#line 28 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                 Write(Html.LabelFor(model => model.newsItem.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 47, true);
            WriteLiteral("</span>\r\n                                <span>");
            EndContext();
            BeginContext(1264, 44, false);
#line 29 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                 Write(Html.EditorFor(model => model.newsItem.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 41, true);
            WriteLiteral("</span>\r\n                                ");
            EndContext();
            BeginContext(1350, 91, false);
#line 30 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.newsItem.Body, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
            BeginContext(1483, 183, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <hr>\r\n                                <div class=\"col-md-4\">\r\n                                    <span>");
            EndContext();
            BeginContext(1667, 51, false);
#line 37 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                     Write(Html.LabelFor(model => model.newsItem.CreatedAtUtc));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 38 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                       ViewContext.ClientValidationEnabled = false; 

#line default
#line hidden
            BeginContext(1814, 63, true);
            WriteLiteral("                                    <span class=\"my-date-time\">");
            EndContext();
            BeginContext(1878, 52, false);
#line 39 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                                          Write(Html.EditorFor(model => model.newsItem.CreatedAtUtc));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 40 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                       ViewContext.ClientValidationEnabled = true; 

#line default
#line hidden
            BeginContext(2025, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2062, 99, false);
#line 41 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.newsItem.CreatedAtUtc, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 80, true);
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n");
            EndContext();
            BeginContext(2852, 501, true);
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
            BeginContext(3359, 152, true);
            WriteLiteral("                            <div>\r\n                                <span><input type=\"submit\" value=\"Save\"></span>\r\n                            </div>\r\n");
            EndContext();
#line 75 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                    }

#line default
#line hidden
            BeginContext(3534, 98, true);
            WriteLiteral("                    <div class=\"clear\"></div>\r\n                    <span style=\"font-size: 13px;\">");
            EndContext();
            BeginContext(3633, 83, false);
#line 77 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                                              Write(Html.ActionLink("<<< Back to List", "List", null, new { style = "color: #EB7F1A" }));

#line default
#line hidden
            EndContext();
            BeginContext(3716, 113, true);
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3852, 1667, true);
                WriteLiteral(@"
    <script src=""/lib/Scripts/daterangeHelper.js""></script>
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
                    '    <div class=""file-footer");
                WriteLiteral(@"-buttons"">\n' +
                    '        {delete} {zoom}' +
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
                BeginContext(5520, 24, false);
#line 127 "/home/dd/NewsBlogASPCoreMongo/Views/NewsItems/Create.cshtml"
                         Write(Url.Action("DeleteFile"));

#line default
#line hidden
                EndContext();
                BeginContext(5544, 753, true);
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

    <script src=""/bundles/jqval.js""></script>
");
                EndContext();
            }
            );
            BeginContext(6300, 8, true);
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
