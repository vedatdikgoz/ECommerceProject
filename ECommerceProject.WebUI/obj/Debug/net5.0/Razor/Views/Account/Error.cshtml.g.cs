#pragma checksum "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Account\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbadebbbf9ab988ef8671e4a10cffdae8e54194e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Error), @"mvc.1.0.view", @"/Views/Account/Error.cshtml")]
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
#nullable restore
#line 1 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\_ViewImports.cshtml"
using ECommerceProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\_ViewImports.cshtml"
using ECommerceProject.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\_ViewImports.cshtml"
using ECommerceProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\_ViewImports.cshtml"
using ECommerceProject.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\_ViewImports.cshtml"
using ECommerceProject.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbadebbbf9ab988ef8671e4a10cffdae8e54194e", @"/Views/Account/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0230cc877bdf8a207d646cb4580aa7fbc07db9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Account\Error.cshtml"
  
    ViewData["Title"] = "Error";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Hata meydana geldi</h3>\r\n<hr/>\r\n\r\n<div class=\"alert alert-danger\">\r\n    <ul>\r\n");
#nullable restore
#line 12 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Account\Error.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 14 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Account\Error.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Account\Error.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
