#pragma checksum "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81baf960727cd50845a479a94cdb34a03f77f108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MultiShopAdmin_Views_Slider_Detail), @"mvc.1.0.view", @"/Areas/MultiShopAdmin/Views/Slider/Detail.cshtml")]
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
#line 3 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\_ViewImports.cshtml"
using MultiShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81baf960727cd50845a479a94cdb34a03f77f108", @"/Areas/MultiShopAdmin/Views/Slider/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a98d4d3cdc38a254d86f4beb7d0f7c66d6e1f7", @"/Areas/MultiShopAdmin/Views/_ViewImports.cshtml")]
    public class Areas_MultiShopAdmin_Views_Slider_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Slider>
    {
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
#line 2 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class = \"main-panel\">\r\n    <div class = \"d-flex\">\r\n        <h4 class = \"text-warning\">Image:</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81baf960727cd50845a479a94cdb34a03f77f1083404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 183, "~/assets/img/slider/", 183, 20, true);
#nullable restore
#line 9 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml"
AddHtmlAttributeValue("", 203, Model.Image, 203, 12, false);

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
            WriteLiteral("\r\n    </div>\r\n    <div class = \"mt-3 d-flex\">\r\n        <h4 class = \"text-warning\">Title:</h4>\r\n        <h3>");
#nullable restore
#line 13 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class = \"mt-3 d-flex\">\r\n        <h4 class = \"text-warning\">SubTitle:</h4>\r\n        <h3>");
#nullable restore
#line 17 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml"
       Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class = \"mt-3 d-flex\">\r\n        <h4 class = \"text-warning\">Button Url:</h4>\r\n        <a");
            BeginWriteAttribute("href", " href = \"", 583, "\"", 608, 1);
#nullable restore
#line 21 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml"
WriteAttributeValue("", 592, Model.ButtonUrl, 592, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Button</a>\r\n    </div>\r\n    <div class = \"mt-3 d-flex\">\r\n        <h4 class = \"text-warning\">Order:</h4>\r\n        <h3>");
#nullable restore
#line 25 "C:\Users\isasa\Desktop\BackEnd\MultiShop\MultiShop\Areas\MultiShopAdmin\Views\Slider\Detail.cshtml"
       Write(Model.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Slider> Html { get; private set; }
    }
}
#pragma warning restore 1591
