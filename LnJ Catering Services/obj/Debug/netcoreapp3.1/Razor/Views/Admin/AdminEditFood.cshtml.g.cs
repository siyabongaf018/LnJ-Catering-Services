#pragma checksum "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d28ac938b9bd7cb6e4fa0c1e5bea45ea54dc0ea72489bdd5eec721dda59562d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminEditFood), @"mvc.1.0.view", @"/Views/Admin/AdminEditFood.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d28ac938b9bd7cb6e4fa0c1e5bea45ea54dc0ea72489bdd5eec721dda59562d3", @"/Views/Admin/AdminEditFood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"da3972013afa694a56d0bd08b739a9dd2cdc9902c8e3e9cf980020fe87c964d8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_AdminEditFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
  
    Layout = "~/Views/Shared/Admin/_Edit_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
 foreach (var item in ViewBag.PassedFoodId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section class=""vh-100 "">
            <div class=""container py-5 h-100"">
                <div class=""row d-flex justify-content-center align-items-center h-100"">
                    <div class=""col col-xl-10"">
                        <div class=""card"" style=""border-radius: 1rem;"">
                            <div class=""row g-0"">
                                <div class=""col-md-6 col-lg-7 d-flex align-items-center"">
                                    <div class=""card-body p-4 p-lg-5 text-black"">

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28ac938b9bd7cb6e4fa0c1e5bea45ea54dc0ea72489bdd5eec721dda59562d35526", async() => {
                WriteLiteral("\r\n                                            <div class=\"d-flex align-items-center mb-3 pb-1\">\r\n                                                <span class=\"h1 fw-bold mb-0\">");
#nullable restore
#line 18 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
                                                                         Write(item.MenuName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            </div>

                                            <h5 class=""fw-normal mb-3 pb-3"" style=""letter-spacing: 1px;"">Edit Food Details</h5>

                                            <div class=""form-outline mb-4"">
                                                <input");
                BeginWriteAttribute("value", " value=\"", 1258, "\"", 1280, 1);
#nullable restore
#line 24 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
WriteAttributeValue("", 1266, item.MenuName, 1266, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""UpdatedMenuName"" type=""text"" id=""form2Example17"" class=""form-control form-control-lg"" />
                                                <label class=""form-label"" for=""form2Example17"">Edit Name</label>
                                            </div>

                                            <div class=""form-outline mb-4"">
                                                <input");
                BeginWriteAttribute("value", " value=\"", 1677, "\"", 1701, 1);
#nullable restore
#line 29 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
WriteAttributeValue("", 1685, item.MenuRating, 1685, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""UpdatedMenuRating"" type=""number"" id=""form2Example27"" class=""form-control form-control-lg"" />
                                                <label class=""form-label"" for=""form2Example27"">Edit Rating</label>
                                            </div>
                                            <div class=""form-group"">
                                                <textarea class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2119, "\"", 2148, 1);
#nullable restore
#line 33 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
WriteAttributeValue("", 2127, item.MenuDescription, 2127, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""UpdatedMenuDescription"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                                                <label for=""exampleFormControlTextarea1"">Edit Description</label>
                                            </div>

                                            <div class=""form-outline mb-4"">
                                                <div class=""input-group-prepend"">
                                                    <span class=""input-group-text"">R</span>
                                                </div>
                                                <input");
                BeginWriteAttribute("value", " value=\"", 2767, "\"", 2790, 1);
#nullable restore
#line 41 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
WriteAttributeValue("", 2775, item.MenuPrice, 2775, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""UpdatedMenuPrice"" type=""number"" id=""form2Example17"" class=""form-control form-control-lg"" />
                                                <label class=""form-label"" for=""form2Example17"">Edit Price</label>
                                            </div>

                                            <input type=""hidden"" name=""MenuId""");
                BeginWriteAttribute("value", " value=\"", 3138, "\"", 3158, 1);
#nullable restore
#line 45 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
WriteAttributeValue("", 3146, item.MenuID, 3146, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                                            <div class=""pt-1 mb-4"">
                                                <button class=""btn btn-dark btn-lg btn-block"" type=""submit"">Update</button>
                                            </div>

                                            <a href=""#!"" class=""small text-muted"">Terms of use.</a>
                                            <a href=""#!"" class=""small text-muted"">Privacy policy</a>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <style>
        body {
            background: url(""../");
#nullable restore
#line 65 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
                           Write(item.MenuImagePath);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""") no-repeat center;
            background-size: 100%;
            width: 100%;
            height: 120%;
            min-width: 700px;
            max-width: 1920px;
            margin-left:0;
        }
            textarea {
                resize: none;
            }
        </style>
");
#nullable restore
#line 77 "C:\Users\User\Documents\LnJ Catering Services v2.05.5\LnJ Catering Services\Views\Admin\AdminEditFood.cshtml"
}

#line default
#line hidden
#nullable disable
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