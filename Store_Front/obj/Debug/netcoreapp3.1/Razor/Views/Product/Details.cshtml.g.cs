#pragma checksum "E:\GC\Store_Front\Store_Front\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6144c0ebcbc39851d9d206d7f5ec1bf98edcf078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6144c0ebcbc39851d9d206d7f5ec1bf98edcf078", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7384bda5484b4967c804bb2a8841688cccbde3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <h2> ");
#nullable restore
#line 7 "E:\GC\Store_Front\Store_Front\Views\Product\Details.cshtml"
    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <b>Id: </b> ");
#nullable restore
#line 8 "E:\GC\Store_Front\Store_Front\Views\Product\Details.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    <b>Price: </b> ");
#nullable restore
#line 9 "E:\GC\Store_Front\Store_Front\Views\Product\Details.cshtml"
              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    <b>Quantity: </b> ");
#nullable restore
#line 10 "E:\GC\Store_Front\Store_Front\Views\Product\Details.cshtml"
                 Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    <b>Description: </b> ");
#nullable restore
#line 11 "E:\GC\Store_Front\Store_Front\Views\Product\Details.cshtml"
                    Write(Model.Description);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
