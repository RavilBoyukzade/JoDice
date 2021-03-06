#pragma checksum "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\EmploeePanel\PostedJob.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b5217ef3c19701fdf565b6011583c356b83b88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmploeePanel_PostedJob), @"mvc.1.0.view", @"/Views/EmploeePanel/PostedJob.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b5217ef3c19701fdf565b6011583c356b83b88", @"/Views/EmploeePanel/PostedJob.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084c6bc61752c43d83003a8ce086d13bf88c1c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_EmploeePanel_PostedJob : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/_EmploeeMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Inner", async() => {
                WriteLiteral("\r\n    header_inner\r\n");
            }
            );
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <div class=\"header_btm\">\r\n        <h2>İş siyahılarım</h2>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<!-- Main\r\n================================================== -->\r\n<main>\r\n    <div class=\"job_container\">\r\n        <div class=\"container\">\r\n            <div class=\"row job_main\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23b5217ef3c19701fdf565b6011583c356b83b884102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class="" job_main_right"">
                    <div class=""row job_section"">
                        <div class=""col-sm-12"">
                            <div class=""jm_headings"">
                                <h6>Your listings are shown in the table below.</h6>
                            </div>
                            <div class=""table-cont"">

                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>Title</th>
                                            <th>Status</th>
                                            <th>Vacancies</th>
                                            <th>Posted</th>
                                            <th>Expires</th>
                                            <th>Interest</th>
                                            <th>Contacted</th>
                                        </tr>
              ");
            WriteLiteral(@"                      </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <h6><a href=""post-a-job.html"">Manager</a></h6>
                                                <ul class=""job-dashboard-actions"">
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-edit"">
                                                            Edit
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-mark_filled"">
                                                            Deactivate
                                                        </a>
                   ");
            WriteLiteral(@"                                 </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-delete"">
                                                            Delete
                                                        </a>
                                                    </li>
                                                </ul>
                                            </td>
                                            <td>
                                                Active
                                            </td>
                                            <td>
                                                2
                                            </td>
                                            <td>
                                                2020/10/17
                                            </td>
                                            <td>
     ");
            WriteLiteral(@"                                           2020/10/01
                                            </td>
                                            <td>
                                                1
                                            </td>
                                            <td>
                                                1
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h6><a href=""post-a-job.html"">Manager</a></h6>
                                                <ul class=""job-dashboard-actions"">
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-edit"">
                                                            Edit
                                                        </a>
 ");
            WriteLiteral(@"                                                   </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-mark_filled"">
                                                            Deactivate
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-delete"">
                                                            Delete
                                                        </a>
                                                    </li>
                                                </ul>
                                            </td>
                                            <td>
                                                Active
                                       ");
            WriteLiteral(@"     </td>
                                            <td>
                                                2
                                            </td>
                                            <td>
                                                2020/10/17
                                            </td>
                                            <td>
                                                2020/10/01
                                            </td>
                                            <td>
                                                1
                                            </td>
                                            <td>
                                                1
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h6><a href=""post-a-job.html"">Manager</a></");
            WriteLiteral(@"h6>
                                                <ul class=""job-dashboard-actions"">
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-edit"">
                                                            Edit
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-mark_filled"">
                                                            Deactivate
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-delete"">
                                                            ");
            WriteLiteral(@"Delete
                                                        </a>
                                                    </li>
                                                </ul>
                                            </td>
                                            <td>
                                                Active
                                            </td>
                                            <td>
                                                2
                                            </td>
                                            <td>
                                                2020/10/17
                                            </td>
                                            <td>
                                                2020/10/01
                                            </td>
                                            <td>
                                                1
                                            </td>
      ");
            WriteLiteral(@"                                      <td>
                                                1
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h6><a href=""post-a-job.html"">Manager</a></h6>
                                                <ul class=""job-dashboard-actions"">
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-edit"">
                                                            Edit
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-mark_filled"">
                                     ");
            WriteLiteral(@"                       Deactivate
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-delete"">
                                                            Delete
                                                        </a>
                                                    </li>
                                                </ul>
                                            </td>
                                            <td>
                                                Active
                                            </td>
                                            <td>
                                                2
                                            </td>
                                            <td>
                                                20");
            WriteLiteral(@"20/10/17
                                            </td>
                                            <td>
                                                2020/10/01
                                            </td>
                                            <td>
                                                1
                                            </td>
                                            <td>
                                                1
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h6><a href=""post-a-job.html"">Manager</a></h6>
                                                <ul class=""job-dashboard-actions"">
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-edit"">
             ");
            WriteLiteral(@"                                               Edit
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-mark_filled"">
                                                            Deactivate
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-delete"">
                                                            Delete
                                                        </a>
                                                    </li>
                                                </ul>
                                            </td>
                             ");
            WriteLiteral(@"               <td>
                                                Active
                                            </td>
                                            <td>
                                                2
                                            </td>
                                            <td>
                                                2020/10/17
                                            </td>
                                            <td>
                                                2020/10/01
                                            </td>
                                            <td>
                                                1
                                            </td>
                                            <td>
                                                1
                                            </td>
                                        </tr>
                                        <tr>
                         ");
            WriteLiteral(@"                   <td>
                                                <h6><a href=""post-a-job.html"">Manager</a></h6>
                                                <ul class=""job-dashboard-actions"">
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-edit"">
                                                            Edit
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" class=""job-dashboard-action-mark_filled"">
                                                            Deactivate
                                                        </a>
                                                    </li>
                                                    <li>
                                                  ");
            WriteLiteral(@"      <a href=""#"" class=""job-dashboard-action-delete"">
                                                            Delete
                                                        </a>
                                                    </li>
                                                </ul>
                                            </td>
                                            <td>
                                                Active
                                            </td>
                                            <td>
                                                2
                                            </td>
                                            <td>
                                                2020/10/17
                                            </td>
                                            <td>
                                                2020/10/01
                                            </td>
                                          ");
            WriteLiteral(@"  <td>
                                                1
                                            </td>
                                            <td>
                                                1
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
