#pragma checksum "/home/dd/NewsBlogASPCoreMongo/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed757c50de79108acea9cd16870caee7872a1870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed757c50de79108acea9cd16870caee7872a1870", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("\n<!DOCTYPE HTML>\n<html>\n");
            EndContext();
            BeginContext(24, 531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b33f0ca0274f3c98849645d02e58f5", async() => {
                BeginContext(30, 518, true);
                WriteLiteral(@"      
    <link rel=""stylesheet"" href=""/bundles/content.css"" />      
    <script src=""/bundles/modernizr.js""></script>

    <title>Some news blog</title>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <link href=""https://fonts.googleapis.com/css?family=Monda"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Audiowide"" rel=""stylesheet"" type=""text/css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(555, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(557, 703, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf527ba7c83a4902a1f10db669030463", async() => {
                BeginContext(563, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 16 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/_Layout.cshtml"
  await Html.RenderPartialAsync("_HeaderLayout");

#line default
#line hidden
                BeginContext(615, 85, true);
                WriteLiteral("\n<div class=\"wrap\">\n    <div class=\"main\">\n        <div class=\"content\">\n            ");
                EndContext();
                BeginContext(701, 12, false);
#line 21 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(713, 25, true);
                WriteLiteral("\n        </div>\n\n        ");
                EndContext();
                BeginContext(739, 43, false);
#line 24 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/_Layout.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
                EndContext();
                BeginContext(782, 144, true);
                WriteLiteral("\n\n    </div>\n</div>\n\n<div class=\"clear\"></div>\n\n<div class=\"footer\">\n\n    <div class=\"copy_right\">\n        <p>News Blog © All Rights Reseverd | ");
                EndContext();
                BeginContext(927, 17, false);
#line 34 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/_Layout.cshtml"
                                        Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(944, 141, true);
                WriteLiteral(" </p>\n    </div>\n\n</div>\n<script src=\"/lib/Scripts/jquery-1.10.2.min.js\"></script>\n<script src=\"/bundles/bootstrapBundle.min.js\"></script>\n\n\n");
                EndContext();
                BeginContext(1086, 41, false);
#line 42 "/home/dd/NewsBlogASPCoreMongo/Views/Shared/_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 126, true);
                WriteLiteral("\n\n<script type=\"text/javascript\">\n    $(document).ready(function () {\n\n        $(\'.fancybox\').fancybox();\n\n    });\n</script>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1260, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
