#pragma checksum "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1799e8d538fbfb82c1d57a843fdc6e7dc609ab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1799e8d538fbfb82c1d57a843fdc6e7dc609ab4", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0230cc877bdf8a207d646cb4580aa7fbc07db9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Bill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"h3\">Alışveriş Sepeti</h1>\r\n<hr>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
 if (Model.CartItems.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"alert alert-warning\">\r\n                Sepetinizde ürün yok\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""text-left"">
                <h4>Sepetteki Ürünler</h4>
            </div>
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th></th>
                        <th>Ürün Adı</th>
                        <th>Fiyat</th>
                        <th>Miktar</th>
                        <th>Toplam</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 38 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                     foreach (var item in Model.CartItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1799e8d538fbfb82c1d57a843fdc6e7dc609ab48652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1147, "~/img/", 1147, 6, true);
#nullable restore
#line 42 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1153, item.ImageUrl, 1153, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                            Write(item.Quantity * item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1799e8d538fbfb82c1d57a843fdc6e7dc609ab411630", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 1661, "\"", 1684, 1);
#nullable restore
#line 50 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1669, item.ProductId, 1669, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                   \r\n                                    <button class=\"btn btn-danger btn-sm\"><i class=\"fa fa-times fa-fw\"></i></button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-md-4"">
            <div class=""text-left"">
                <h4>Alışveriş Özeti</h4>
            </div>
            <table class=""table"">
                <tbody>
                    <tr>
                        <th>Sepet Toplamı</th>
                        <td>");
#nullable restore
#line 68 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                       Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th>Kargo</th>
                        <th>Ücretsiz</th>
                    </tr>
                    <tr>
                        <th>Sipariş Toplamı</th>
                        <th>");
#nullable restore
#line 76 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
                       Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                    </tr>
                </tbody>
            </table>
            <div class=""text-center"">
                <a href=""/"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-left fa-fw""></i>Alışverişe Devam
                </a>               
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1799e8d538fbfb82c1d57a843fdc6e7dc609ab415951", async() => {
                WriteLiteral("\r\n                    <i class=\"fa fa-arrow-circle-right fa-fw\"></i>Tamamla\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 90 "C:\Users\vedat\OneDrive\Masaüstü\ECommerceProject\ECommerceProject.WebUI\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
