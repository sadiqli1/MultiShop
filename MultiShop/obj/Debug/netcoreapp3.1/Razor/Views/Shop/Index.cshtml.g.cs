#pragma checksum "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094c06373d85a2168c9450eb0a2af21a3fcdb3f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094c06373d85a2168c9450eb0a2af21a3fcdb3f7", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d2b5f91c8f515476ba240d0a49a8389e4d41401", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dress>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h6 text-decoration-none text-truncate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Start -->
    <div class=""container-fluid"">
        <div class=""row px-xl-5"">
            <div class=""col-12"">
                <nav class=""breadcrumb bg-light mb-30"">
                    <a class=""breadcrumb-item text-dark"" href=""#"">Home</a>
                    <a class=""breadcrumb-item text-dark"" href=""#"">Shop</a>
                    <span class=""breadcrumb-item active"">Shop List</span>
                </nav>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->


    <!-- Shop Start -->
    <div class=""container-fluid"">
        <div class=""row px-xl-5"">
            <!-- Shop Sidebar Start -->
            <div class=""col-lg-3 col-md-4"">
                <!-- Price Start -->
                <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by price</span></h5>
                <div class=""bg-light p-4 mb-30"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f77864", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""price-all"">
                            <label class=""custom-control-label"" for=""price-all"">All Price</label>
                            <span class=""badge border font-weight-normal"">1000</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-1"">
                            <label class=""custom-control-label"" for=""price-1"">$0 - $100</label>
                            <span class=""badge border font-weight-normal"">150</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
              ");
                WriteLiteral(@"              <input type=""checkbox"" class=""custom-control-input"" id=""price-2"">
                            <label class=""custom-control-label"" for=""price-2"">$100 - $200</label>
                            <span class=""badge border font-weight-normal"">295</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-3"">
                            <label class=""custom-control-label"" for=""price-3"">$200 - $300</label>
                            <span class=""badge border font-weight-normal"">246</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-4"">
                            <label class=""custom-control-label"" for=""");
                WriteLiteral(@"price-4"">$300 - $400</label>
                            <span class=""badge border font-weight-normal"">145</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-5"">
                            <label class=""custom-control-label"" for=""price-5"">$400 - $500</label>
                            <span class=""badge border font-weight-normal"">168</span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Price End -->
                
                <!-- Color Start -->
                <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by color</span></h5>
                <div class=""bg-light p-4 mb-30"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f712228", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""color-all"">
                            <label class=""custom-control-label"" for=""price-all"">All Color</label>
                            <span class=""badge border font-weight-normal"">1000</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""color-1"">
                            <label class=""custom-control-label"" for=""color-1"">Black</label>
                            <span class=""badge border font-weight-normal"">150</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                  ");
                WriteLiteral(@"          <input type=""checkbox"" class=""custom-control-input"" id=""color-2"">
                            <label class=""custom-control-label"" for=""color-2"">White</label>
                            <span class=""badge border font-weight-normal"">295</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""color-3"">
                            <label class=""custom-control-label"" for=""color-3"">Red</label>
                            <span class=""badge border font-weight-normal"">246</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""color-4"">
                            <label class=""custom-control-label"" for=""color-4"">Blue</lab");
                WriteLiteral(@"el>
                            <span class=""badge border font-weight-normal"">145</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""color-5"">
                            <label class=""custom-control-label"" for=""color-5"">Green</label>
                            <span class=""badge border font-weight-normal"">168</span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Color End -->

                <!-- Size Start -->
                <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by size</span></h5>
                <div class=""bg-light p-4 mb-30"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f716544", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""size-all"">
                            <label class=""custom-control-label"" for=""size-all"">All Size</label>
                            <span class=""badge border font-weight-normal"">1000</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-1"">
                            <label class=""custom-control-label"" for=""size-1"">XS</label>
                            <span class=""badge border font-weight-normal"">150</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                          ");
                WriteLiteral(@"  <input type=""checkbox"" class=""custom-control-input"" id=""size-2"">
                            <label class=""custom-control-label"" for=""size-2"">S</label>
                            <span class=""badge border font-weight-normal"">295</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-3"">
                            <label class=""custom-control-label"" for=""size-3"">M</label>
                            <span class=""badge border font-weight-normal"">246</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-4"">
                            <label class=""custom-control-label"" for=""size-4"">L</label>
                  ");
                WriteLiteral(@"          <span class=""badge border font-weight-normal"">145</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-5"">
                            <label class=""custom-control-label"" for=""size-5"">XL</label>
                            <span class=""badge border font-weight-normal"">168</span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Size End -->
            </div>
            <!-- Shop Sidebar End -->


            <!-- Shop Product Start -->
            <div class=""col-lg-9 col-md-8"">
                <div class=""row pb-3"">
                    <div class=""col-12 pb-1"">
                        <div class=""d-flex align-items-center justify-content-between mb-4"">
                            <div>
                                <button class=""btn btn-sm btn-light""><i class=""fa fa-th-large""></i></button>
                                <button class=""btn btn-sm btn-light ml-2""><i class=""fa fa-bars""></i></button>
                            </div>
                            <div class=""ml-2"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">Sorting</button>
                                    <div class=""dropdown-menu dropdown-menu-right"">
       ");
            WriteLiteral("                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f721631", async() => {
                WriteLiteral("(A - Z)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f723627", async() => {
                WriteLiteral("(Z - A)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f725623", async() => {
                WriteLiteral("Price(min - max)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""btn-group ml-2"">
                                    <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">Showing</button>
                                    <div class=""dropdown-menu dropdown-menu-right"">
                                        <a class=""dropdown-item"" href=""#"">10</a>
                                        <a class=""dropdown-item"" href=""#"">20</a>
                                        <a class=""dropdown-item"" href=""#"">30</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 172 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
                     foreach (Dress dress in Model)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6 pb-1\">\r\n                        <div class=\"product-item bg-light mb-4\">\r\n                            <div class=\"product-img position-relative overflow-hidden\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "094c06373d85a2168c9450eb0a2af21a3fcdb3f728937", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 12160, "~/assets/img/", 12160, 13, true);
#nullable restore
#line 177 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 12173, dress.Images.FirstOrDefault(i => i.isMain == true)?.Name, 12173, 57, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 177 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 12237, dress.Images.FirstOrDefault(i => i.isMain == true)?.Alternative, 12237, 64, false);

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
            WriteLiteral("\r\n                                <div class=\"product-action\">\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 12445, "\"", 12452, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 12573, "\"", 12580, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 12694, "\"", 12701, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 12817, "\"", 12824, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text-center py-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094c06373d85a2168c9450eb0a2af21a3fcdb3f732356", async() => {
#nullable restore
#line 186 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
                                                                                                                                                      Write(dress.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
                                                                                                                                    WriteLiteral(dress.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"d-flex align-items-center justify-content-center mt-2\">\r\n                                    <h5>$");
#nullable restore
#line 188 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
                                    Write(dress.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><h6 class=\"text-muted ml-2\"><del>$");
#nullable restore
#line 188 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
                                                                                       Write(dress.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</del></h6>
                                </div>
                                <div class=""d-flex align-items-center justify-content-center mb-1"">
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small>(99)</small>
                                </div>
                            </div>
                        </div>
                    </div>   
");
#nullable restore
#line 201 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Views\Shop\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12"">
                        <nav>
                          <ul class=""pagination justify-content-center"">
                            <li class=""page-item disabled""><a class=""page-link"" href=""#"">Previous</span></a></li>
                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                          </ul>
                        </nav>
                    </div>
                </div>
            </div>
            <!-- Shop Product End -->
        </div>
    </div>
    <!-- Shop End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
