#pragma checksum "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Home\Order.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9dd471d653499f39c4960ace1873df425f63b3f1d26d4a4deabb10c52e2af1ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\_ViewImports.cshtml"
using LnJ_Catering_Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\_ViewImports.cshtml"
using LnJ_Catering_Services.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9dd471d653499f39c4960ace1873df425f63b3f1d26d4a4deabb10c52e2af1ea", @"/Views/Home/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"da3972013afa694a56d0bd08b739a9dd2cdc9902c8e3e9cf980020fe87c964d8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Home\Order.cshtml"
  
    Layout = "~/Views/Shared/_Order_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- order section starts  -->\r\n<section class=\"order\" id=\"order\">\r\n    <br /><br /><br /><br />\r\n    <h3 class=\"sub-heading\"> order now </h3>\r\n    <h1 class=\"heading\"> free and fast </h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd471d653499f39c4960ace1873df425f63b3f1d26d4a4deabb10c52e2af1ea4779", async() => {
                WriteLiteral(@"

        <div class=""inputBox"">
            <div class=""input"">
                <span>your name</span>
                <input type=""text"" placeholder=""enter your name"">
            </div>
            <div class=""input"">
                <span>your number</span>
                <input type=""number"" placeholder=""enter your number"">
            </div>
        </div>
        <div class=""inputBox"">
            <div class=""input"">
                <span>your order</span>
                <input type=""text"" placeholder=""enter food name"">
            </div>
            <div class=""input"">
                <span>additional food</span>
                <input type=""text"" placeholder=""extra with food"">
            </div>
        </div>
        <div class=""inputBox"">
            <div class=""input"">
                <span>how musch</span>
                <input type=""number"" placeholder=""how many orders"">
            </div>
            <div class=""input"">
                <span>date and time</span>
");
                WriteLiteral("                <input type=\"datetime-local\">\r\n            </div>\r\n        </div>\r\n        <div class=\"inputBox\">\r\n            <div class=\"input\">\r\n                <span>your address</span>\r\n                <textarea");
                BeginWriteAttribute("name", " name=\"", 1514, "\"", 1521, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"enter your address\"");
                BeginWriteAttribute("id", " id=\"", 1555, "\"", 1560, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"10\"></textarea>\r\n            </div>\r\n            <div class=\"input\">\r\n                <span>your message</span>\r\n                <textarea");
                BeginWriteAttribute("name", " name=\"", 1716, "\"", 1723, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"enter your message\"");
                BeginWriteAttribute("id", " id=\"", 1757, "\"", 1762, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"10\"></textarea>\r\n            </div>\r\n        </div>\r\n\r\n        <input type=\"submit\" value=\"order now\" class=\"btn\">\r\n\r\n    ");
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
            WriteLiteral("\r\n\r\n</section>\r\n\r\n<!-- order section ends -->\r\n\r\n<script src=\"https://unpkg.com/swiper/swiper-bundle.min.js\"></script>\r\n\r\n<!-- custom js file link  -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd471d653499f39c4960ace1873df425f63b3f1d26d4a4deabb10c52e2af1ea8614", async() => {
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
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591