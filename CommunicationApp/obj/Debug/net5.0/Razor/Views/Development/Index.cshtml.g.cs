#pragma checksum "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7090cf315eeba69a380be18ac747508e4e0b48a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Development_Index), @"mvc.1.0.view", @"/Views/Development/Index.cshtml")]
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
#line 1 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\_ViewImports.cshtml"
using CommunicationApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\_ViewImports.cshtml"
using CommunicationApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\_ViewImports.cshtml"
using CommunicationApp.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\_ViewImports.cshtml"
using CommunicationApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7090cf315eeba69a380be18ac747508e4e0b48a2", @"/Views/Development/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9df4e1dfff959a3148eb206ca2a14fc0da9bb30", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Development_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevelopmentViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PostsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Comments.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ekko-lightbox/ekko-lightbox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/readmore/readmore.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"mt-5 mb-5 d-flex justify-content-between\">\n    <h1>Utveckling - ");
#nullable restore
#line 4 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <div>\n");
#nullable restore
#line 6 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
           
            string utvecklingsTyp = ViewData["Title"].Equals("Utbildning") ? "Education" : "Research";
            string utvecklingsEmoji = ViewData["Title"].Equals("Utbildning") ? "fas fa-graduation-cap" : "fas fa-flask";
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 395, "\"", 442, 2);
            WriteAttributeValue("", 402, "/Development/Create?type=", 402, 25, true);
#nullable restore
#line 10 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 427, utvecklingsTyp, 427, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary float-right\">Skapa inlägg <i");
            BeginWriteAttribute("class", " class=\"", 495, "\"", 520, 1);
#nullable restore
#line 10 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 503, utvecklingsEmoji, 503, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\n    </div>\n</div>\n<ul class=\"nav nav-pills mb-3\" id=\"pills-tab\" role=\"tablist\">\n");
#nullable restore
#line 14 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
     for (int i = 0; i < Model.Categories.Count; i++)
    {
        var category = Model.Categories[i];
        string isActive = i==0 ? "active" : ""; //Lägger till active på i==0 (index0) , kanske inte behövs sen?
        string isSelected = i == 0 ? "true" : "false";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\" role=\"presentation\">\n            <a");
            BeginWriteAttribute("class", " class=\"", 946, "\"", 972, 2);
            WriteAttributeValue("", 954, "nav-link", 954, 8, true);
#nullable restore
#line 20 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue(" ", 962, isActive, 963, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 973, "\"", 1000, 3);
            WriteAttributeValue("", 978, "pills-", 978, 6, true);
#nullable restore
#line 20 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 984, category.Id, 984, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 996, "-tab", 996, 4, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"pill\"");
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1046, 2);
            WriteAttributeValue("", 1027, "#pills-", 1027, 7, true);
#nullable restore
#line 20 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 1034, category.Id, 1034, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1058, "\"", 1092, 2);
            WriteAttributeValue("", 1074, "pills-", 1074, 6, true);
#nullable restore
#line 20 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 1080, category.Id, 1080, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-selected", " aria-selected=\"", 1093, "\"", 1120, 1);
#nullable restore
#line 20 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 1109, isSelected, 1109, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
                                                                                                                                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </li>\n");
#nullable restore
#line 22 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n<div class=\"tab-content\" id=\"pills-tabContent\">\n");
#nullable restore
#line 25 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
     for (int i = 0; i < Model.Categories.Count; i++)
    {
        var category = Model.Categories[i];
        string isActive = i == 0 ? "show active" : ""; //Lägger till active på i==0 (index0) , kanske inte behövs sen?
        var viewModel = new DevelopmentViewModel
        {
            BlogPosts = Model.BlogPosts.Where(b => b.Categories.All(c => c.Id == category.Id)).ToList(),
            CurrentPage = Model.CurrentPage,
            CurrentUrl = Model.CurrentUrl,
            IsSearchResult = Model.IsSearchResult,
            NoBlogPostsMessage = Model.NoBlogPostsMessage,
            TotalPages = Model.TotalPages,
            TotalPosts = Model.TotalPosts
        };


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1909, "\"", 1940, 3);
            WriteAttributeValue("", 1917, "tab-pane", 1917, 8, true);
            WriteAttributeValue(" ", 1925, "fade", 1926, 5, true);
#nullable restore
#line 40 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue(" ", 1930, isActive, 1931, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1941, "\"", 1964, 2);
            WriteAttributeValue("", 1946, "pills-", 1946, 6, true);
#nullable restore
#line 40 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 1952, category.Id, 1952, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1981, "\"", 2021, 3);
            WriteAttributeValue("", 1999, "pills-", 1999, 6, true);
#nullable restore
#line 40 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
WriteAttributeValue("", 2005, category.Id, 2005, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2017, "-tab", 2017, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7090cf315eeba69a380be18ac747508e4e0b48a214098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 41 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = viewModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 43 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7090cf315eeba69a380be18ac747508e4e0b48a216112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7090cf315eeba69a380be18ac747508e4e0b48a217210", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7090cf315eeba69a380be18ac747508e4e0b48a218308", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).on('click', '[data-toggle=""lightbox""]', function (event) {
            event.preventDefault();
            $(this).ekkoLightbox();
        });

        $('article').readmore({
            collapsedHeight: 180,
            moreLink: '<a href=""#"">Läs mer</a>',
            lessLink: '<a href=""#"">Läs mindre</a>'
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevelopmentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
