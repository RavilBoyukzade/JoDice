#pragma checksum "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a724e19fb07fdc2326484e832f28abaae8e8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Job_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Job/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a724e19fb07fdc2326484e832f28abaae8e8e6", @"/Views/Shared/Components/Job/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084c6bc61752c43d83003a8ce086d13bf88c1c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Job_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JoDice.Models.Job.JobViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-sm-6"">
        <div class=""featured_box "">
            <div class=""fb_image"">
                <a href=""compnay-profile-single.html"">
                    <img alt=""brand logo"" src=""assets/images/c-logo-01.webp"">
                </a>
            </div>
            <div class='fb_content'>
                <h4>
                    <a href=""job-single.html"">");
#nullable restore
#line 16 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                                         Write(item.JobName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </h4>
                <ul>
                    <li>
                        <a href=""#"">
                            <i class=""fas fa-landmark""></i>
                            Magna Aliqua
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fas fa-map-marker-alt""></i>
                            ");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                       Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n");
#nullable restore
#line 32 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                          
                            System.DateTime DateNow = DateTime.Now;
                            System.DateTime AddedDate = item.AddedDate;

                            System.TimeSpan diff2 = AddedDate.Subtract(DateNow) * (-1);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                         if (item.AddedDate == DateTime.Now.Date)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\">\r\n                                <i class=\"far fa-clock\"></i>\r\n                                Bu gün\r\n                            </a>\r\n");
#nullable restore
#line 45 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\">\r\n                                <i class=\"far fa-clock\"></i>\r\n                                ");
#nullable restore
#line 50 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                           Write(diff2.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" gün əvvəl\r\n                            </a>\r\n");
#nullable restore
#line 52 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </li>
                </ul>
            </div>
            <div class=""fb_action"">
                <a title=""add to favourite"" href=""#""><i class=""far fa-heart""></i></a>
                <a class=""btn btn-third"" href=""job-single.html"">Ətraflı</a>
                <ul class=""tags"">
                    <li>copywriting</li>
                    <li>translating</li>
                    <li>editing</li>
                </ul>
            </div>
        </div>
    </div>
");
#nullable restore
#line 68 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Shared\Components\Job\Default.cshtml"
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