#pragma checksum "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\Shared\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0efd3e4c561e8aed7a759fa7a1ab625ffe7458b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Confirm), @"mvc.1.0.view", @"/Views/Shared/Confirm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Confirm.cshtml", typeof(AspNetCore.Views_Shared_Confirm))]
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
#line 1 "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\_ViewImports.cshtml"
using QuaverCodeChallenge;

#line default
#line hidden
#line 2 "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\_ViewImports.cshtml"
using QuaverCodeChallenge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0efd3e4c561e8aed7a759fa7a1ab625ffe7458b0", @"/Views/Shared/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa5592e9adf825911545cbbe57a491429c260d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\Shared\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 120, true);
            WriteLiteral("\r\n<h1>Finshed!</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <label>API Call one contains duplicates = ");
            EndContext();
            BeginContext(211, 13, false);
#line 10 "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\Shared\Confirm.cshtml"
                                             Write(ViewBag.list0);

#line default
#line hidden
            EndContext();
            BeginContext(224, 107, true);
            WriteLiteral("</label> <br />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label>API Call two contains duplicates = ");
            EndContext();
            BeginContext(332, 13, false);
#line 13 "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\Shared\Confirm.cshtml"
                                             Write(ViewBag.list1);

#line default
#line hidden
            EndContext();
            BeginContext(345, 109, true);
            WriteLiteral("</label> <br />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label>API Call three contains duplicates = ");
            EndContext();
            BeginContext(455, 13, false);
#line 16 "C:\Users\user\workspace\Code-Test\QuaverCodeChallenge\QuaverCodeChallenge\Views\Shared\Confirm.cshtml"
                                               Write(ViewBag.list2);

#line default
#line hidden
            EndContext();
            BeginContext(468, 35, true);
            WriteLiteral("</label> <br />\r\n    </div>\r\n</div>");
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
