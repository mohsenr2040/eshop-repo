#pragma checksum "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24741dd7f20d1c3bcb030071d71de70ac175f247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_GetSellers), @"mvc.1.0.view", @"/Views/Sellers/GetSellers.cshtml")]
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
#line 1 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
using eshop.Application.Services.Sellers.Seller;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24741dd7f20d1c3bcb030071d71de70ac175f247", @"/Views/Sellers/GetSellers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_GetSellers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SellersAndCategoriesDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("adplacement-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/SellersImages/None.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
  
    ViewData["Title"] = "GetSellers";
    Layout = "~/Views/Shared/_Layout.cshtml";
    Random r = new Random();
    int star = r.Next(1, 5);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""col-lg-12 col-md-12 col-xs-12 pr order-1 d-block"" style="" background-color: #e44e4e;"">
    <div style="" text-align: center; font-size: smaller; color: white;"">
        <span>انتخاب دسته بندی</span>
    </div>
    <div class=""slider-widget-products"">
        <div class=""widget widget-product card mb-0"">
            <div class=""product-carousel-brand owl-carousel owl-theme owl-rtl owl-loaded owl-drag"">
                <div class=""owl-stage-outer"">
                    <div class=""owl-stage"" style=""transform: translate3d(0px, 0px, 0px); transition: all 0s ease 0s; width: 2234px;"">

");
#nullable restore
#line 41 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                         foreach (var item in Model.Categories.ToList())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                             if (Model.Categories.IndexOf(@item) == 5)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"owl-item active\" style=\"width: 190.75px; margin-left: 10px;\">\r\n                                    <div class=\"item\" href=\"javascript:void()\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24741dd7f20d1c3bcb030071d71de70ac175f2475932", async() => {
                WriteLiteral("\r\n                                            <div class=\"adplacement-sponsored_box\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24741dd7f20d1c3bcb030071d71de70ac175f2476324", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2427, "~/", 2427, 2, true);
#nullable restore
#line 49 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
AddHtmlAttributeValue("", 2429, item.ImageSrc, 2429, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2218, "~/sellers?categoryId=", 2218, 21, true);
#nullable restore
#line 47 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
AddHtmlAttributeValue("", 2239, item.CategoryId, 2239, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 54 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"owl-item\" style=\"width: 190.75px; margin-left: 10px;\">\r\n                                    <div class=\"item\" href=\"javascript:void()\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24741dd7f20d1c3bcb030071d71de70ac175f2479966", async() => {
                WriteLiteral("\r\n                                            <div class=\"adplacement-sponsored_box\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24741dd7f20d1c3bcb030071d71de70ac175f24710358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3164, "~/", 3164, 2, true);
#nullable restore
#line 61 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
AddHtmlAttributeValue("", 3166, item.ImageSrc, 3166, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2955, "~/sellers?categoryId=", 2955, 21, true);
#nullable restore
#line 59 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
AddHtmlAttributeValue("", 2976, item.CategoryId, 2976, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 66 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""owl-nav"">
                    <button type=""button"" role=""presentation"" class=""owl-prev disabled"">
                        <i class=""fa fa-angle-right""></i>
                    </button>
                    <button type=""button"" role=""presentation"" class=""owl-next"">
                        <i class=""fa fa-angle-left""></i>
                    </button>
                </div>
                <div class=""owl-dots disabled""></div>
            </div>
        </div>
    </div>
</div>

<div class=""container-main"">
    <div class=""d-block"">
        <div class=""adplacement-container-row"">
            <div style="" text-align: center; font-size: smaller; color:black; padding-bottom:7px"">
");
#nullable restore
#line 89 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                 if (Model.Sellers.Select(s => s.CatName).Distinct().Count() > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>فروشندگان</span>\r\n");
#nullable restore
#line 92 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                }
                else if (Model.Sellers.Select(s => s.CatName).Distinct().Count() == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>فروشندگان/");
#nullable restore
#line 95 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                               Write(Model.Sellers.Select(s => s.CatName).FirstOrDefault().ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 96 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n");
#nullable restore
#line 100 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
             foreach (var item in Model.Sellers.ToList())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-6 col-lg-3 pr\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24741dd7f20d1c3bcb030071d71de70ac175f24716380", async() => {
                WriteLiteral("\r\n                        <div class=\"adplacement-sponsored_box\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24741dd7f20d1c3bcb030071d71de70ac175f24716733", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div style=\" text-align: center; font-size: smaller;color:black;\">\r\n                            <span>فروشگاه ");
#nullable restore
#line 108 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
                                     Write(item.ShopName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4787, "~/", 4787, 2, true);
#nullable restore
#line 103 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
AddHtmlAttributeValue("", 4789, item.UserName, 4789, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n");
#nullable restore
#line 114 "D:\asp core\e-shop core\backups\1012\e-shop\EndPoint.Site\Views\Sellers\GetSellers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SellersAndCategoriesDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
