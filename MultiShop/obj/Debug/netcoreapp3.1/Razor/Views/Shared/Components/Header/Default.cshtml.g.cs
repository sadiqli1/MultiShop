#pragma checksum "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96a57bb59c802e7a9aeed19260694d5bef84f7c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 3 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\_ViewImports.cshtml"
using MultiShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\_ViewImports.cshtml"
using MultiShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a57bb59c802e7a9aeed19260694d5bef84f7c8", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d2b5f91c8f515476ba240d0a49a8389e4d41401", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LayoutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Topbar Start -->
    <div class=""container-fluid"">
        <div class=""row bg-secondary py-1 px-xl-5"">
            <div class=""col-lg-6 d-none d-lg-block"">
                <div class=""d-inline-flex align-items-center h-100"">
                    <a class=""text-body mr-3""");
            BeginWriteAttribute("href", " href=\"", 342, "\"", 349, 0);
            EndWriteAttribute();
            WriteLiteral(">About</a>\r\n                    <a class=\"text-body mr-3\"");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 414, 0);
            EndWriteAttribute();
            WriteLiteral(">Contact</a>\r\n                    <a class=\"text-body mr-3\"");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 481, 0);
            EndWriteAttribute();
            WriteLiteral(">Help</a>\r\n                    <a class=\"text-body mr-3\"");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 545, 0);
            EndWriteAttribute();
            WriteLiteral(@">FAQs</a>
                </div>
            </div>
            <div class=""col-lg-6 text-center text-lg-right"">
                <div class=""d-inline-flex align-items-center"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">My Account</button>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <button class=""dropdown-item"" type=""button"">Sign in</button>
                            <button class=""dropdown-item"" type=""button"">Sign up</button>
                        </div>
                    </div>
                    <div class=""btn-group mx-2"">
                        <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">USD</button>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <button class=""dropdown-item"" type=""button"">EUR</button>
             ");
            WriteLiteral(@"               <button class=""dropdown-item"" type=""button"">GBP</button>
                            <button class=""dropdown-item"" type=""button"">CAD</button>
                        </div>
                    </div>
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">EN</button>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <button class=""dropdown-item"" type=""button"">FR</button>
                            <button class=""dropdown-item"" type=""button"">AR</button>
                            <button class=""dropdown-item"" type=""button"">RU</button>
                        </div>
                    </div>
                </div>
                <div class=""d-inline-flex align-items-center d-block d-lg-none"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2477, "\"", 2484, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn px-0 ml-2"">
                        <i class=""fas fa-heart text-dark""></i>
                        <span class=""badge text-dark border border-dark rounded-circle"" style=""padding-bottom: 2px;"">0</span>
                    </a>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2749, "\"", 2756, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn px-0 ml-2"">
                        <i class=""fas fa-shopping-cart text-dark""></i>
                        <span class=""badge text-dark border border-dark rounded-circle"" style=""padding-bottom: 2px;"">0</span>
                    </a>
                </div>
            </div>
        </div>
        <div class=""row align-items-center bg-light py-3 px-xl-5 d-none d-lg-flex"">
            <div class=""col-lg-4"">
                <a");
            BeginWriteAttribute("href", " href=\"", 3206, "\"", 3213, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none\">\r\n                    <span class=\"h1 text-uppercase text-primary bg-dark px-2\">");
#nullable restore
#line 58 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml"
                                                                         Write(Model.Settings.FirstOrDefault(s => s.Key.Trim().ToLower() == "headerlogo")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"h1 text-uppercase text-dark bg-primary px-2 ml-n1\">Shop</span>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-lg-4 col-6 text-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96a57bb59c802e7a9aeed19260694d5bef84f7c88811", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search for products"">
                        <div class=""input-group-append"">
                            <span class=""input-group-text bg-transparent text-primary"">
                                <i class=""fa fa-search""></i>
                            </span>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-4 col-6 text-right\">\r\n                <p class=\"m-0\">Customer Service</p>\r\n                <h5 class=\"m-0\">");
#nullable restore
#line 76 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml"
                           Write(Model.Settings.FirstOrDefault(s => s.Key.Trim().ToLower() == "phonenumber")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
        </div>
    </div>
    <!-- Topbar End -->


    <!-- Navbar Start -->
    <div class=""container-fluid bg-dark mb-30"">
        <div class=""row px-xl-5"">
            <div class=""col-lg-3 d-none d-lg-block"">
                <a class=""btn d-flex align-items-center justify-content-between bg-primary w-100"" data-toggle=""collapse"" href=""#navbar-vertical"" style=""height: 65px; padding: 0 30px;"">
                    <h6 class=""text-dark m-0""><i class=""fa fa-bars mr-2""></i>Categories</h6>
                    <i class=""fa fa-angle-down text-dark""></i>
                </a>
                <nav class=""collapse position-absolute navbar navbar-vertical navbar-light align-items-start p-0 bg-light"" id=""navbar-vertical"" style=""width: calc(100% - 30px); z-index: 999;"">
                    <div class=""navbar-nav w-100"">
                        <div class=""nav-item dropdown dropright"">
                            <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">");
            WriteLiteral("Dresses <i class=\"fa fa-angle-right float-right mt-1\"></i></a>\r\n                            <div class=\"dropdown-menu position-absolute rounded-0 border-0 m-0\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5579, "\"", 5586, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">Men\'s Dresses</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5663, "\"", 5670, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">Women\'s Dresses</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5749, "\"", 5756, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">Baby\'s Dresses</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml"
                         foreach (var item in Model.Categories)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 5983, "\"", 5990, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">");
#nullable restore
#line 103 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 104 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shared\Components\Header\Default.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </nav>\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n                <nav class=\"navbar navbar-expand-lg bg-dark navbar-dark py-3 py-lg-0 px-0\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 6282, "\"", 6289, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-decoration-none d-block d-lg-none"">
                        <span class=""h1 text-uppercase text-dark bg-light px-2"">Multi</span>
                        <span class=""h1 text-uppercase text-light bg-primary px-2 ml-n1"">Shop</span>
                    </a>
                    <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                        <div class=""navbar-nav mr-auto py-0"">
                            <a href=""index.html"" class=""nav-item nav-link active"">Home</a>
                            <a href=""shop.html"" class=""nav-item nav-link"">Shop</a>
                            <a href=""detail.html"" class=""nav-item nav-link"">Shop Detail</a>
                            <div class=""nav-item dropdown"">
                                <a hr");
            WriteLiteral(@"ef=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">Pages <i class=""fa fa-angle-down mt-1""></i></a>
                                <div class=""dropdown-menu bg-primary rounded-0 border-0 m-0"">
                                    <a href=""cart.html"" class=""dropdown-item"">Shopping Cart</a>
                                    <a href=""checkout.html"" class=""dropdown-item"">Checkout</a>
                                </div>
                            </div>
                            <a href=""contact.html"" class=""nav-item nav-link"">Contact</a>
                        </div>
                        <div class=""navbar-nav ml-auto py-0 d-none d-lg-block"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 8023, "\"", 8030, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn px-0"">
                                <i class=""fas fa-heart text-primary""></i>
                                <span class=""badge text-secondary border border-secondary rounded-circle"" style=""padding-bottom: 2px;"">0</span>
                            </a>
                            <a");
            BeginWriteAttribute("href", " href=\"", 8335, "\"", 8342, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn px-0 ml-3"">
                                <i class=""fas fa-shopping-cart text-primary""></i>
                                <span class=""badge text-secondary border border-secondary rounded-circle"" style=""padding-bottom: 2px;"">0</span>
                            </a>
                        </div>
                    </div>
                </nav>
            </div>
        </div>
    </div>
    <!-- Navbar End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LayoutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
