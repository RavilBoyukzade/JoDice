#pragma checksum "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11cf0f34bc5db4ffdfc7a56105fd0bcdab7da339"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BrowsJob_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BrowsJob/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11cf0f34bc5db4ffdfc7a56105fd0bcdab7da339", @"/Views/Shared/Components/BrowsJob/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084c6bc61752c43d83003a8ce086d13bf88c1c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BrowsJob_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JoDice.Models.Job.JobViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-6\">\r\n    <div class=\"featured_box \">\r\n        <div class=\"fb_image\">\r\n            <img alt=\"brand logo\" src=\"assets/images/demo-restro.jpg\">\r\n        </div>\r\n        <div class=\"fb_content\">\r\n            <h4>");
#nullable restore
#line 11 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
           Write(item.JobName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <ul>\r\n                <li>\r\n");
#nullable restore
#line 14 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                     foreach (var country in item.Countries)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\">\r\n                            <i class=\"fas fa-landmark\"></i>\r\n                            ");
#nullable restore
#line 18 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                       Write(country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n");
#nullable restore
#line 20 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <i class=\"fas fa-map-marker-alt\"></i>\r\n                        ");
#nullable restore
#line 25 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                   Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </li>\r\n                \r\n                <li>\r\n");
#nullable restore
#line 30 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                      
                        System.DateTime DateNow = DateTime.Now;
                        System.DateTime AddedDate = item.AddedDate;

                        System.TimeSpan diff2 = AddedDate.Subtract(DateNow) * (-1);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                     if (item.AddedDate == DateTime.Now.Date)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\">\r\n                            <i class=\"far fa-clock\"></i>\r\n                            Bu gün\r\n                        </a>\r\n");
#nullable restore
#line 43 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\">\r\n                            <i class=\"far fa-clock\"></i>\r\n                            ");
#nullable restore
#line 48 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                       Write(diff2.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" gün əvvəl\r\n                        </a>\r\n");
#nullable restore
#line 50 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </li>
            </ul>
        </div>
        <div class=""fb_action"">
            <a title=""add to favourite"" href=""#""><i class=""far fa-heart""></i></a>
            <a class=""btn btn-primary"" href=""#"">Etrafli</a>
        </div>
    </div>
</div>
");
#nullable restore
#line 60 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\BrowsJob\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JoDice.Models.Job.JobViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
