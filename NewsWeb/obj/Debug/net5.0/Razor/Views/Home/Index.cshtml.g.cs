#pragma checksum "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aebeccccfc2b917af6e777890ef8923c75c7f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\_ViewImports.cshtml"
using NewsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\_ViewImports.cshtml"
using NewsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aebeccccfc2b917af6e777890ef8923c75c7f78", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89088341abe991ad788efe6efdb8fe0d79d01fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWeb.ModelViews.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/posts/tabs-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/posts/tabs-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- hero section -->\r\n<section id=\"hero\">\r\n    <div class=\"container-xl\">  \r\n        <div class=\"row gy-4\">\r\n");
#nullable restore
#line 11 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
             if (Model.Featured != null)
            {
                string url = $"/{Model.Featured.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-8\">\r\n\r\n                    <!-- featured post large -->\r\n                    <div class=\"post featured-post-lg\">\r\n                        <div class=\"details clearfix\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 600, "\"", 634, 2);
            WriteAttributeValue("", 607, "/", 607, 1, true);
#nullable restore
#line 19 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 608, Model.Featured.File.Alias, 608, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-badge\">");
#nullable restore
#line 19 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                                                    Write(Model.Featured.File.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <h2 class=\"post-title\"><a");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 758, 1);
#nullable restore
#line 20 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 754, url, 754, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                             Write(Model.Featured.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <ul class=\"meta list-inline mb-0\">\r\n                                <li class=\"list-inline-item\"><a href=\"#\">");
#nullable restore
#line 22 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                                    Write(Model.Featured.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"list-inline-item\">");
#nullable restore
#line 23 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                        Write(Model.Featured.DateCreate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1191, 1);
#nullable restore
#line 26 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 1187, url, 1187, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""thumb rounded"">
                                <div class=""inner data-bg-image"" data-bg-image=""~/images/posts/featured-lg.jpg""></div>
                            </div>
                        </a>
                    </div>
                </div>
");
#nullable restore
#line 33 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-4"">

                <!-- post tabs -->
                <div class=""post-tabs rounded bordered"">
                    <!-- tab navs -->
                    <ul class=""nav nav-tabs nav-pills nav-fill"" id=""postsTab"" role=""tablist"">
                        <li class=""nav-item"" role=""presentation""><button aria-controls=""popular"" aria-selected=""true"" class=""nav-link active"" data-bs-target=""#popular"" data-bs-toggle=""tab"" id=""popular-tab"" role=""tab"" type=""button"">Popular</button></li>
                        <li class=""nav-item"" role=""presentation""><button aria-controls=""recent"" aria-selected=""false"" class=""nav-link"" data-bs-target=""#recent"" data-bs-toggle=""tab"" id=""recent-tab"" role=""tab"" type=""button"">Recent</button></li>
                    </ul>
                    <!-- tab contents -->
                    <div class=""tab-content"" id=""postsTabContent"">
                        <!-- loader -->
                        <div class=""lds-dual-ring""></div>
                      ");
            WriteLiteral("  <!-- popular posts -->\r\n                        <div aria-labelledby=\"popular-tab\" class=\"tab-pane fade show active\" id=\"popular\" role=\"tabpanel\">\r\n");
#nullable restore
#line 49 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                             if (Model.Populars != null)
                            {
                                foreach (var item in Model.Populars)
                                {
                                    string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- post -->\r\n                                    <div class=\"post post-list-sm circle\">\r\n                                        <div class=\"thumb circle\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3187, "\"", 3198, 1);
#nullable restore
#line 57 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 3194, url, 3194, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"inner\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4aebeccccfc2b917af6e777890ef8923c75c7f7810375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3365, item.Title, 3365, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details clearfix"">
                                            <h6 class=""post-title my-0""><a");
            BeginWriteAttribute("href", " href=\"", 3682, "\"", 3693, 1);
#nullable restore
#line 64 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 3689, url, 3689, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                            <ul class=\"meta list-inline mt-1 mb-0\">\r\n                                                <li class=\"list-inline-item\">");
#nullable restore
#line 66 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                                        Write(item.DateCreate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 70 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- recent posts -->\r\n                        <div aria-labelledby=\"recent-tab\" class=\"tab-pane fade\" id=\"recent\" role=\"tabpanel\">\r\n");
#nullable restore
#line 74 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                             if (Model.Recents != null)
                            {
                                foreach (var item in Model.Recents)
                                {
                                    string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- post -->\r\n                                    <div class=\"post post-list-sm circle\">\r\n                                        <div class=\"thumb circle\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4805, "\"", 4816, 1);
#nullable restore
#line 82 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 4812, url, 4812, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"inner\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4aebeccccfc2b917af6e777890ef8923c75c7f7815024", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 84 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4983, item.Title, 4983, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details clearfix"">
                                            <h6 class=""post-title my-0""><a");
            BeginWriteAttribute("href", " href=\"", 5300, "\"", 5311, 1);
#nullable restore
#line 89 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 5307, url, 5307, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                            <ul class=\"meta list-inline mt-1 mb-0\">\r\n                                                <li class=\"list-inline-item\">");
#nullable restore
#line 91 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                                                        Write(item.DateCreate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 95 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                                }
                            } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</section>
<!-- section main content -->
<section class=""main-content"">
    <div class=""container-xl"">
        <div class=""row gy-4"">
            <div class=""col-lg-8"">
                
            </div>
            <div class=""col-lg-4"">
                <!-- sidebar -->
                <div class=""sidebar"">
                    <!-- widget popular posts -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Tài liệu nổi bật</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        ");
#nullable restore
#line 121 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Popular"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <!-- widget categories -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Danh sách thư mục</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        ");
#nullable restore
#line 129 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Files"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <!-- widget tags -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Từ khóa chủ đề</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"" class=""tag"">#Trending</a>
                            <a href=""#"" class=""tag"">#Video</a>
                            <a href=""#"" class=""tag"">#Featured</a>
                            <a href=""#"" class=""tag"">#Gallery</a>
                            <a href=""#"" class=""tag"">#Celebrities</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWeb.ModelViews.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591