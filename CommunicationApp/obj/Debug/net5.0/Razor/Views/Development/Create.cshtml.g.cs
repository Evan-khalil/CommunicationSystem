#pragma checksum "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a157f61882edae595c14839a5a2a166464e0450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Development_Create), @"mvc.1.0.view", @"/Views/Development/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a157f61882edae595c14839a5a2a166464e0450", @"/Views/Development/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9df4e1dfff959a3148eb206ca2a14fc0da9bb30", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Development_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevCreateViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Research", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Education", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DevelopmentCreate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
  
    ViewBag.Title = Model.Title == "" ? "Skapa nytt projekt-inlägg" : "Ändra projekt-inlägg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container mt-5\">\n    <h2>");
#nullable restore
#line 7 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
    Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 9 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
     using (Html.BeginForm("Create", "Development", FormMethod.Post, new { @class = "form-horizontal mt-3", role = "form", enctype = "multipart/form-data" }))
     {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
                                  ;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-row mt-2\">\n            <div class=\"form-group col-md-6\">\n                ");
#nullable restore
#line 15 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.LabelFor(x => x.Title, new { @for = "inputBlogTitle" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 16 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control", id = "inputBlogTitle", Value = @Model.Title }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 17 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.ValidationMessageFor(x => x.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n            <div class=\"form-group col-md-6\">\n                ");
#nullable restore
#line 21 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.LabelFor(x => x.BlogTypes, new { @for = "inputBlogType" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <select id=\"inputBlogType\" class=\"custom-select\" name=\"SelectedBlogType\">\n");
#nullable restore
#line 23 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
                     if (Model.SelectedBlogType is null || Model.SelectedBlogType.Equals("Education"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a157f61882edae595c14839a5a2a166464e04509410", async() => {
                WriteLiteral("Forskning");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a157f61882edae595c14839a5a2a166464e045010594", async() => {
                WriteLiteral("Utbildning");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a157f61882edae595c14839a5a2a166464e045012415", async() => {
                WriteLiteral("Forskning");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a157f61882edae595c14839a5a2a166464e045013911", async() => {
                WriteLiteral("Utbildning");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 32 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\n            </div>\n        </div>\n        <div class=\"form-row mt-2\">\n            <div class=\"form-group col-md-6\">\n                ");
#nullable restore
#line 38 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.LabelFor(x => x.Text, new { @for = "inputBlogText" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 39 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.TextAreaFor(x => x.Text, 10, 50, new { @class = "form-control", id = "inputBlogText", Value = @Model.Text }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 40 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
           Write(Html.ValidationMessageFor(x => x.Text, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group col-md-6\">\n                <div>\n                    ");
#nullable restore
#line 44 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
               Write(Html.LabelFor(x => x.Categories, new { @for = "blogCategories" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 45 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
               Write(Html.DropDownListFor(x => x.Categories, new MultiSelectList(Model.Categories, "Name"), new { @class = "custom-select multiselect-dropdown", id = "blogCategories", multiple = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n                <div>\n                    ");
#nullable restore
#line 48 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
               Write(Html.LabelFor(x => x.NewCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"input-group\">\n                        ");
#nullable restore
#line 50 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.NewCategory, new { @class = "form-control", id = "newCategory", Value = @Model.NewCategory }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 51 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
                   Write(Html.ValidationMessageFor(x => x.NewCategory, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <a id=\"btnAddCategory\" class=\"btn btn-primary ml-2\">Nytt projekt <i class=\"far fa-folder\"></i></a>\n                    </div>\n                </div>\n                <div class=\"input-group mt-4\">\n                    ");
#nullable restore
#line 56 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
               Write(Html.TextBoxFor(x => x.FileUploads, new { type = "file", @class = "form-control-file", multiple = "multiple", accept = ".jpg,.png,.jpeg,.gif,.pdf,.doc,.docx,.ppt,.xlsx,.zip,.rar" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 57 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.FileUploads, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <input id=\"btnSubmit\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 3355, "\"", 3425, 1);
#nullable restore
#line 61 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
WriteAttributeValue("", 3363, Html.Raw(Model.Title == "" ? "Skapa Inlägg" : "Ändra Inlägg"), 3363, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" />\n");
#nullable restore
#line 62 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Development\Create.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a157f61882edae595c14839a5a2a166464e045020902", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a157f61882edae595c14839a5a2a166464e045022081", async() => {
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
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevCreateViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
