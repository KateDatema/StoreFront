#pragma checksum "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "733c3c0c666eabe137328720584cb2754741f489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Storefront_Buy), @"mvc.1.0.view", @"/Views/Storefront/Buy.cshtml")]
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
#line 1 "E:\GC\Store_Front\Store_Front\Views\_ViewImports.cshtml"
using Store_Front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GC\Store_Front\Store_Front\Views\_ViewImports.cshtml"
using Store_Front.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733c3c0c666eabe137328720584cb2754741f489", @"/Views/Storefront/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7384bda5484b4967c804bb2a8841688cccbde3", @"/Views/_ViewImports.cshtml")]
    public class Views_Storefront_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Result", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n    <b>");
#nullable restore
#line 4 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></b>\r\n    Id: ");
#nullable restore
#line 5 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Price: ");
#nullable restore
#line 7 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Quantity: ");
#nullable restore
#line 9 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
         Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Description: ");
#nullable restore
#line 11 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733c3c0c666eabe137328720584cb2754741f4894911", async() => {
                WriteLiteral("\r\n    <br />\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 303, "\"", 322, 1);
#nullable restore
#line 17 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
WriteAttributeValue("", 311, Model.Name, 311, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\"/>\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 363, "\"", 380, 1);
#nullable restore
#line 18 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
WriteAttributeValue("", 371, Model.Id, 371, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\"/>\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 419, "\"", 442, 1);
#nullable restore
#line 19 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
WriteAttributeValue("", 427, Model.Quantity, 427, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Quantity\" />\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 488, "\"", 514, 1);
#nullable restore
#line 20 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
WriteAttributeValue("", 496, Model.Description, 496, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Description\" />\r\n    \r\n    <button type=\"submit\"> Purchase ");
#nullable restore
#line 22 "E:\GC\Store_Front\Store_Front\Views\Storefront\Buy.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
