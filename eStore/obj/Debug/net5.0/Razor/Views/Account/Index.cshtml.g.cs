#pragma checksum "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d80330ae1833f1f487b49ec49c36ff930e9aafe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d80330ae1833f1f487b49ec49c36ff930e9aafe", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b2f6be9543d2bdbcd1beb432e2babaffb86e07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.Member>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Personal information</h1>\n<table class=\"table table-hover\">\n    <tr>\n        <td> ");
#nullable restore
#line 9 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayNameFor(model => model.MemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td> ");
#nullable restore
#line 10 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayFor(model => model.MemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td> ");
#nullable restore
#line 13 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td> ");
#nullable restore
#line 14 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td> ");
#nullable restore
#line 17 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td> ");
#nullable restore
#line 18 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n         <td> ");
#nullable restore
#line 21 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
         Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td> ");
#nullable restore
#line 22 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td> ");
#nullable restore
#line 25 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td> ");
#nullable restore
#line 26 "F:\FPTU\FALL2022\PRN211\assignmen1_LongTHDCE160177\Assignment\eStore\Views\Account\Index.cshtml"
        Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n</table>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d80330ae1833f1f487b49ec49c36ff930e9aafe7788", async() => {
                WriteLiteral("Edit Personal Info");
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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d80330ae1833f1f487b49ec49c36ff930e9aafe9040", async() => {
                WriteLiteral("Change Password");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObject.Member> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591