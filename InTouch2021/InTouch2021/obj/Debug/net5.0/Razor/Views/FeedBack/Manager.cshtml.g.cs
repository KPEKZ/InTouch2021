#pragma checksum "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de488aa684388a96a48cdcaabba8077cfe7a3cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeedBack_Manager), @"mvc.1.0.view", @"/Views/FeedBack/Manager.cshtml")]
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
#line 1 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\_ViewImports.cshtml"
using InTouch2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\_ViewImports.cshtml"
using InTouch2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de488aa684388a96a48cdcaabba8077cfe7a3cae", @"/Views/FeedBack/Manager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedbc5d9591a2f9063b6b710dc5589d95277b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_FeedBack_Manager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InTouch2021.Models.FeedBackModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FeedBack", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-button mdl-js-button mdl-button--raised mdl-button--colored"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-button mdl-js-button mdl-button--raised mdl-button--accent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-cell mdl-cell--4-col"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
  
    ViewData["Title"] = "Менеджер";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"mdl-grid\">\r\n");
#nullable restore
#line 9 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
     if (Model.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
         foreach (var data in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de488aa684388a96a48cdcaabba8077cfe7a3cae6365", async() => {
                WriteLiteral(@"
                <div class=""demo-card-square mdl-card mdl-shadow--2dp animate__animated animate__fadeInUp animate__delay-1s container d-flex flex-column justify-content-around align-items-center"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h2 class=""mdl-card__title-text mdl-typography--text-center"">Имя : ");
#nullable restore
#line 17 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                                                                          Write(data.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <h2 class=\"mdl-card__title-text mdl-typography--text-center\">Студ. № ");
#nullable restore
#line 23 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                                                                            Write(data.studNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <h2 class=\"mdl-card__title-text mdl-typography--text-center\">тел. : ");
#nullable restore
#line 29 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                                                                           Write(data.phoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n\r\n                            <h2 class=\"mdl-card__title-text mdl-typography--text-center\">");
#nullable restore
#line 36 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                                                                    Write(data.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <h2 class=\"mdl-card__title-text mdl-typography--text-center\">тема: ");
#nullable restore
#line 41 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                                                                          Write(data.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            ");
#nullable restore
#line 47 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                       Write(data.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de488aa684388a96a48cdcaabba8077cfe7a3cae10362", async() => {
                    WriteLiteral("\r\n                                Удалить\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                       WriteLiteral(data.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        \r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de488aa684388a96a48cdcaabba8077cfe7a3cae13095", async() => {
                    WriteLiteral("\r\n                                Изменить\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
                                      WriteLiteral(data.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              \r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
         

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"mdl-card__supporting-text text-center\">Пусто</p>\r\n");
#nullable restore
#line 74 "D:\study\GIT_PROJECTS\InTouch2021\InTouch2021\InTouch2021\InTouch2021\Views\FeedBack\Manager.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InTouch2021.Models.FeedBackModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591