#pragma checksum "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42482a580f3c10d058bc0a9f70e8314c02600f8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42482a580f3c10d058bc0a9f70e8314c02600f8a", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd488d45478e2cb930100d126b1602d0832f7310", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml"
  
    ViewBag.Title = "Register";

#line default
#line hidden
            BeginContext(38, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(44, 13, false);
#line 6 "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(57, 8, true);
            WriteLiteral(".</h2>\n\n");
            EndContext();
            BeginContext(66, 28, false);
#line 8 "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(94, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 10 "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(129, 21, false);
#line 12 "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
            EndContext();
            BeginContext(156, 97, true);
            WriteLiteral("    <p>\n        <button type=\"submit\" class=\"btn btn-default\">Register &raquo;</button>\n    </p>\n");
            EndContext();
#line 17 "/home/dd/NewsBlogCoreMongoDb/Views/Account/Register.cshtml"
}

#line default
#line hidden
            BeginContext(255, 1, true);
            WriteLiteral("\n");
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
