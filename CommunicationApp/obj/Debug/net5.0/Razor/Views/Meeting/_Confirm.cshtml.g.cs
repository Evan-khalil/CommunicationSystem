#pragma checksum "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb614fee67c9fd290d08cd0c571cc3007cf03eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meeting__Confirm), @"mvc.1.0.view", @"/Views/Meeting/_Confirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb614fee67c9fd290d08cd0c571cc3007cf03eb", @"/Views/Meeting/_Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9df4e1dfff959a3148eb206ca2a14fc0da9bb30", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Meeting__Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meeting>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
   
    int answerCount = _meeting.AnswerCounter(Model);
    bool haveOptions = false;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal-header"">
    <h4 class=""modal-title mt-0"" id=""myModalLabel"">Välj datum för mötet</h4>
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>
<div class=""modal-body"">
    <h5>Mötet: ");
#nullable restore
#line 14 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
          Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <p>med <b>");
#nullable restore
#line 15 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
          Write(Model.Recipients.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("st</b> inbjudna deltagare, har besvarats av <b>");
#nullable restore
#line 15 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                                                                                  Write(answerCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("st</b> enligt följande: </p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb614fee67c9fd290d08cd0c571cc3007cf03eb5887", async() => {
                WriteLiteral("\n        <div class=\"radio-meetingDates\">\n");
#nullable restore
#line 18 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
             for (int i = 0; i < Model.DateRequests.Count; i++)
            {
                if (Model.DateRequests[i].Attendees.Count > 0)
                {
                    haveOptions = true;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-check\">\n                        <input class=\"form-check-input\" type=\"radio\" name=\"confirmRadios\"");
                BeginWriteAttribute("id", " id=\"", 968, "\"", 998, 4);
                WriteAttributeValue("", 973, "confirmRadio-", 973, 13, true);
#nullable restore
#line 24 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
WriteAttributeValue("", 986, Model.Id, 986, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 995, "-", 995, 1, true);
#nullable restore
#line 24 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
WriteAttributeValue("", 996, i, 996, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 999, "\"", 1032, 1);
#nullable restore
#line 24 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
WriteAttributeValue("", 1007, Model.DateRequests[i].Id, 1007, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1090, "\"", 1121, 4);
                WriteAttributeValue("", 1096, "confirmRadio-", 1096, 13, true);
#nullable restore
#line 25 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
WriteAttributeValue("", 1109, Model.Id, 1109, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1118, "-", 1118, 1, true);
#nullable restore
#line 25 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
WriteAttributeValue("", 1119, i, 1119, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            ");
#nullable restore
#line 26 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                       Write(Model.DateRequests[i].Start.ToString("yyyy-MM-dd ddd HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 26 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                                                                                       Write(Model.DateRequests[i].End.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - <b>");
#nullable restore
#line 26 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                                                                                                                                          Write(Model.DateRequests[i].Attendees.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("st</b> kan denna dagen\n                        </label>\n                    </div>\n");
#nullable restore
#line 29 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <ul>\n                <li><b>");
#nullable restore
#line 32 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                   Write(Model.NonAttenders.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("st</b> kan inte delta</li>\n                <li><b>");
#nullable restore
#line 33 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
                   Write(Model.Recipients.Count - answerCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("st</b> har ännu inte svarat på inbjudan</li>\n            </ul>\n");
#nullable restore
#line 35 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
             if (Model.Recipients.Count == Model.NonAttenders.Count)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>\n                    <b>Ingen kan komma på ditt möte!</b><br />\n                    Vänligen skapa en ny möteskallelse.\n                </p>\n");
#nullable restore
#line 41 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<div class=\"modal-footer\">\n");
#nullable restore
#line 46 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
     if (haveOptions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button id=\"ConfirmMeetingDate\" class=\"ConfirmMeetingDate btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2068, "\"", 2121, 3);
            WriteAttributeValue("", 2078, "$(\'#modal-confirm-", 2078, 18, true);
#nullable restore
#line 48 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
WriteAttributeValue("", 2096, Model.Id, 2096, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2105, "\').modal(\'hide\')", 2105, 16, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\">Bekräfta mötesdatum</button>\n");
#nullable restore
#line 49 "C:\Users\Evank\source\repos\2021VT-IK207G-Team8-Scrum-main\2021VT-IK207G-Team8-Scrum-main\src\CommunicationApp\Views\Meeting\_Confirm.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" class=\"btn btn-secondary waves-effect\" data-dismiss=\"modal\">Stäng</button>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMeetingRepository _meeting { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meeting> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591