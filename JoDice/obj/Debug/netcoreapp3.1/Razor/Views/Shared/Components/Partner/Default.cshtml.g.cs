#pragma checksum "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Partner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "effdf4f8d65317f8a8be37ad1a0894b64df4e15c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Partner_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Partner/Default.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\_ViewImports.cshtml"
using JoDice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\_ViewImports.cshtml"
using Repository.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\_ViewImports.cshtml"
using Repository.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"effdf4f8d65317f8a8be37ad1a0894b64df4e15c", @"/Views/Shared/Components/Partner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0c68681ba3a4972b1b796630cfc5db9f102ecb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Partner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JoDice.Models.PartnerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n  \r\n       \r\n            <ul class=\"partner_carousel owl-carousel owl-theme\">\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Partner\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a href=\"#\"><img");
            BeginWriteAttribute("alt", " alt=\"", 266, "\"", 282, 1);
#nullable restore
#line 10 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Partner\Default.cshtml"
WriteAttributeValue("", 272, item.Name, 272, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 283, "\"", 313, 2);
            WriteAttributeValue("", 289, "assets/images/", 289, 14, true);
#nullable restore
#line 10 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Partner\Default.cshtml"
WriteAttributeValue("", 303, item.Logo, 303, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    </li>\r\n");
#nullable restore
#line 12 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Partner\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n      \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JoDice.Models.PartnerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
