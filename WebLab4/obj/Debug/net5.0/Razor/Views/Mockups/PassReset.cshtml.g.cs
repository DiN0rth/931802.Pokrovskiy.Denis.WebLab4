#pragma checksum "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\Mockups\PassReset.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619068b91beb3ce9a24bc6edc9fd38283510ea81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_PassReset), @"mvc.1.0.view", @"/Views/Mockups/PassReset.cshtml")]
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
#line 1 "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\_ViewImports.cshtml"
using WebLab4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\_ViewImports.cshtml"
using WebLab4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619068b91beb3ce9a24bc6edc9fd38283510ea81", @"/Views/Mockups/PassReset.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17993205effa45825b655c864e9bba4b803f3f45", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_PassReset : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignUp>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\Mockups\PassReset.cshtml"
  ViewData["Title"] = "Reset Your Password";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Reset your password</h1>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619068b91beb3ce9a24bc6edc9fd38283510ea813738", async() => {
                WriteLiteral("\r\n        <b>Email</b><br>\r\n        ");
#nullable restore
#line 9 "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\Mockups\PassReset.cshtml"
   Write(Html.TextBox("Email", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\Mockups\PassReset.cshtml"
                              Write(Html.ValidationMessageFor(p => p.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br>
        <input type=""submit"" value=""Send me a code"" name=""action"" class=""btn btn-primary mt-3 pr-3 pl-3"">
        <input type=""submit"" value=""I have a code"" name=""action"" class=""btn btn-light mt-3 pr-3 pl-3"" style=""border-color:lightgrey"">

        <h3>");
#nullable restore
#line 13 "C:\Users\1\Source\Repos\WebLab4\WebLab4\Views\Mockups\PassReset.cshtml"
       Write(ViewBag.ResetCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignUp> Html { get; private set; }
    }
}
#pragma warning restore 1591
