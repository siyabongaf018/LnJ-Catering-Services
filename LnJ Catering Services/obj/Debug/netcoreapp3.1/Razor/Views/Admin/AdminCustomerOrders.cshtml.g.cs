#pragma checksum "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "344c8f84ab097b80cbd8b983e1eec35bee1f0cd20a9fd547a42faa5e90c34f20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminCustomerOrders), @"mvc.1.0.view", @"/Views/Admin/AdminCustomerOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"344c8f84ab097b80cbd8b983e1eec35bee1f0cd20a9fd547a42faa5e90c34f20", @"/Views/Admin/AdminCustomerOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"da3972013afa694a56d0bd08b739a9dd2cdc9902c8e3e9cf980020fe87c964d8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_AdminCustomerOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile2.jfif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
  
    Layout = "~/Views/Shared/Admin/_Orders_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- review section starts  -->

<section class=""review"" id=""review"">
    <br />
    <br />
    <br />
    <br />
    <h3 class=""sub-heading"">  Orders </h3>
    <h1 class=""heading""> Orders of registered customers </h1>

    <div class=""swiper-container review-slider"">

        <div");
            BeginWriteAttribute("class", " class=\"", 363, "\"", 371, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 18 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
             foreach (var i in ViewBag.Orders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide slide\">\r\n                    <i class=\"fas fa-quote-right\"></i>\r\n                    <div class=\"user\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "344c8f84ab097b80cbd8b983e1eec35bee1f0cd20a9fd547a42faa5e90c34f205305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"user-info\">\r\n                            <h3>User ID:  ");
#nullable restore
#line 25 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
                                     Write(i.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3><br />\r\n                            <h3>Order ID: ");
#nullable restore
#line 26 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
                                     Write(i.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"stars\">\r\n                                <p>\r\n                                    Menu Item Ordered Id: ");
#nullable restore
#line 29 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
                                                     Write(i.DishID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                    Address: ");
#nullable restore
#line 30 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
                                        Write(i.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 38 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminCustomerOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <style>
                section {
                    width: 100%;
                }

                .review-content {
                    width: 100%;
                    height: 50vh;
                    background-color: white;
                    border-radius: 10px;
                }

                .review-content2 {
                    width: 100%;
                    height: 10vh;
                    background-color: white;
                    border: dashed;
                    border-color: lightgray;
                    border-radius: 5px;
                    font-size: 12pt;
                    font-family: Arial;
                    padding: 5px;
                }
            </style>





            <!-- <div class=""swiper-slide slide"">
                <i class=""fas fa-quote-right""></i>
                <div class=""user"">
                    <img src=""~/images/pic-04.png"" alt="""">
                    <div class=""user-info"">
                      ");
            WriteLiteral(@"  <h3></h3>
                        <div class=""stars"">
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star""></i>
                            <i class=""fas fa-star-half-alt""></i>
                        </div>
                    </div>
                </div>
                <p></p>
            </div>-->

        </div>

    </div>

</section>


<!-- review section ends -->");
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
