#pragma checksum "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8f0f12861434ce4e625b2a9e7fa0017f2c63e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8f0f12861434ce4e625b2a9e7fa0017f2c63e6", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d942b7d973c7624871be7071b92618f82163cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml"
 if (User.Identity.IsAuthenticated)
{
    using (Html.BeginForm("Logout", "Account", FormMethod.Post, new { id = "logoutForm", @class = "navbar-right" }))
    {


#line default
#line hidden
            BeginContext(162, 91, true);
            WriteLiteral("        <ul class=\"nav navbar-nav navbar-right\">\n            <li class=\"navbar-text\">Hello ");
            EndContext();
            BeginContext(254, 18, false);
#line 7 "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml"
                                     Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(272, 121, true);
            WriteLiteral("</li>\n            <li><a href=\"javascript:document.getElementById(\'logoutForm\').submit()\">Log off</a></li>\n        </ul>\n");
            EndContext();
#line 10 "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(408, 57, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\n        <li>");
            EndContext();
            BeginContext(466, 50, false);
#line 15 "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml"
       Write(Html.ActionLink("Register", "Register", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(516, 18, true);
            WriteLiteral("</li>\n        <li>");
            EndContext();
            BeginContext(535, 44, false);
#line 16 "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml"
       Write(Html.ActionLink("Login", "Login", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 16, true);
            WriteLiteral("</li>\n    </ul>\n");
            EndContext();
#line 18 "/home/dd/NewsBlogCoreMongoDb/Views/Shared/_LoginPartial.cshtml"
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
