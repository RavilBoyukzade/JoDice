#pragma checksum "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Blog\BlogSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f138e92425a91b0d9b9eb0ceffcf6552e5511e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogSingle), @"mvc.1.0.view", @"/Views/Blog/BlogSingle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f138e92425a91b0d9b9eb0ceffcf6552e5511e", @"/Views/Blog/BlogSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084c6bc61752c43d83003a8ce086d13bf88c1c2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JoDice.Models.BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://veepixel.com/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Inner", async() => {
                WriteLiteral("\r\n    header_inner\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <div class=\"header_btm\">\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Blog\BlogSingle.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    </div>\r\n");
            }
            );
            WriteLiteral(@"
<!-- Main
================================================== -->
<main>
    <div class=""blog-listing"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-9"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""post_box singlepb"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6f138e92425a91b0d9b9eb0ceffcf6552e5511e5963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 583, "~/assets/images/", 583, 16, true);
#nullable restore
#line 23 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Blog\BlogSingle.cshtml"
AddHtmlAttributeValue("", 599, Model.Photo, 599, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"post_content\">\r\n                                    <h6>\r\n                                        <a href=\"blog-single.html\">");
#nullable restore
#line 26 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Blog\BlogSingle.cshtml"
                                                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h6>\r\n");
            WriteLiteral("\r\n                                    <span>");
#nullable restore
#line 36 "C:\Users\Lenovo\Desktop\JoDice\JoDice\Views\Blog\BlogSingle.cshtml"
                                     Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                                </div>
                            </div>
                        </div>


                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""blog_sidebar"">
                        <div class=""single-job-sidebar"">
                            <div class=""sjs_box"">
                                <h3>Search blog</h3>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f138e92425a91b0d9b9eb0ceffcf6552e5511e8873", async() => {
                WriteLiteral(@"
                                    <input type=""text"" class=""form-control"" placeholder=""Search"" id=""search-blog"">

                                    <button type=""submit"" class=""btn btn-primary""><i class=""fas fa-search""></i></button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>
                            <div class=""sjs_box"">
                                <h3>Tags</h3>
                                <ul class=""tags"">
                                    <li><a href=""#"">business</a></li>
                                    <li><a href=""#"">company</a></li>
                                    <li><a href=""#"">earnings</a></li>
                                    <li><a href=""#"">employees</a></li>
                                    <li><a href=""#"">future</a></li>
                                    <li><a href=""#"">job</a></li>
                                    <li><a href=""#"">jobseek</a></li>
                                    <li><a href=""#"">market</a></li>
                                    <li><a href=""#"">resume</a></li>
                                    <li><a href=""#"">secrets</a></li>
                                    <li><a href=""#"">skills</a></li>
                                    <li><a href=""#"">strategy</a></li>");
            WriteLiteral(@"
                                    <li><a href=""#"">suggestions</a></li>
                                    <li><a href=""#"">training</a></li>
                                    <li><a href=""#"">unemployment</a></li>
                                    <li><a href=""#"">work</a></li>
                                </ul>
                            </div>
                            <div class=""sjs_box"">
                                <h3>Recent Posts</h3>
                                <ul class=""recentpost"">
                                    <li><a href=""blog-single.html"">4 Secrets To Be Strategic About Your Job Search</a></li>
                                    <li><a href=""blog-single.html"">Why Long-Term Unemployment Isn’t As Bad As You Think</a></li>
                                </ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JoDice.Models.BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591