#pragma checksum "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc69ad8d9ba4a726cd22b484c29de52785bf8f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Popular_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Popular/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc69ad8d9ba4a726cd22b484c29de52785bf8f1", @"/Views/Shared/Components/Popular/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89088341abe991ad788efe6efdb8fe0d79d01fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Popular_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Document>>
    {
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
#line 2 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
 if (Model != null)
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"widget rounded\">\r\n        <div class=\"widget-content\">\r\n");
#nullable restore
#line 6 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
             if (Model != null && Model.Count > 0)
            {
                int i = 0;
                foreach (var item in Model)
                {
                    i++;
                    string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"post post-list-sm circle\" >\r\n                        <div class=\"thumb-circle\" >\r\n                            <span class=\"number\" >");
#nullable restore
#line 15 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 580, 1);
#nullable restore
#line 16 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
WriteAttributeValue("", 576, url, 576, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"inner\" >\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fc69ad8d9ba4a726cd22b484c29de52785bf8f14839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 684, "~/images/news/", 684, 14, true);
#nullable restore
#line 18 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
AddHtmlAttributeValue("", 698, item.Thumb, 698, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
AddHtmlAttributeValue("", 716, item.Title, 716, 11, false);

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
            WriteLiteral("\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"details clearfix\" >\r\n                            <h6 class=\"post-title my-0\" ><a");
            BeginWriteAttribute("href", " href=\"", 955, "\"", 966, 1);
#nullable restore
#line 23 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
WriteAttributeValue("", 962, url, 962, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                            <ul class=\"meta list-inline mt-1 mb-0\" >\r\n                                <li class=\"list-inline-item\">");
#nullable restore
#line 25 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
                                                        Write(item.DateCreate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 29 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "D:\TaiLieu\BlogWebMVC\NewsWeb\NewsWeb\NewsWeb\Views\Shared\Components\Popular\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Document>> Html { get; private set; }
    }
}
#pragma warning restore 1591