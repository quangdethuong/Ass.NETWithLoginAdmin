#pragma checksum "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09208a0e9ee56b32ce323b1bf98d84f6ed57b14d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09208a0e9ee56b32ce323b1bf98d84f6ed57b14d", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b2f6be9543d2bdbcd1beb432e2babaffb86e07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text text-danger\">Details</h1>\r\n<hr>\r\n    <h4>Product</h4>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 11 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 12 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 15 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 16 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <td> ");
#nullable restore
#line 19 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 20 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <td> ");
#nullable restore
#line 23 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 24 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <td> ");
#nullable restore
#line 27 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 28 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td> ");
#nullable restore
#line 31 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 32 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Products\Details.cshtml"
            Write(Html.DisplayFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09208a0e9ee56b32ce323b1bf98d84f6ed57b14d8044", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObject.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
