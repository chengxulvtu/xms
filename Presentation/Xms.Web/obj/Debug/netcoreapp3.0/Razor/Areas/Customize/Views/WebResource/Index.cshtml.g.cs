#pragma checksum "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9623270c570d891ef9dff6da74f1b3ff906987d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customize_Views_WebResource_Index), @"mvc.1.0.view", @"/Areas/Customize/Views/WebResource/Index.cshtml")]
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
#line 1 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\_ViewImports.cshtml"
using Xms.Web.Customize.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9623270c570d891ef9dff6da74f1b3ff906987d2", @"/Areas/Customize/Views/WebResource/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0e0822572318de59551e4c02160fd04d8a0b74", @"/Areas/Customize/Views/_ViewImports.cshtml")]
    public class Areas_Customize_Views_WebResource_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xms.Web.Customize.Models.WebResourceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("themeLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">\r\n            <a data-toggle=\"collapse\"\r\n               href=\"#collapseTwo\">\r\n                <strong>");
#nullable restore
#line 8 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                   Write(app.PrivilegeTree?.LastOrDefault().DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div id=\"collapseTwo\" class=\"panel-collapse collapse in\">\r\n        <div class=\"panel-body\">\r\n            <div id=\"gridview\">\r\n                <div class=\"mb-2 toolbar\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9623270c570d891ef9dff6da74f1b3ff906987d27259", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 17 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                   Write(Html.HiddenFor(x => x.SolutionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-6\">\r\n                                <div class=\"btn-group btn-group-sm\">\r\n                                    <a class=\"btn btn-info\"");
                BeginWriteAttribute("href", " href=\"", 992, "\"", 1101, 3);
#nullable restore
#line 21 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 999, "/"+app.OrganizationUniqueName, 999, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1032, "/customize/webresource/createwebresource?solutionid=", 1032, 52, true);
#nullable restore
#line 21 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 1084, Model.SolutionId, 1084, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><span class=""glyphicon glyphicon-plus-sign""></span> 新增</a>
                                    <button type=""button"" class=""btn btn-warning"" data-action=""/customize/webresource/deletewebresource"" data-role=""delete"" data-tooltip=""删除后相关数据也将一并删除，请提前备份数据""><span class=""glyphicon glyphicon-trash""></span> 批量删除</button>
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""input-group input-group-sm"">
                                    <span class=""input-group-btn webresourcetype-select"">
                                        ");
#nullable restore
#line 28 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                                   Write(Html.TextBoxFor(x => x.WebResourceType, new { @class = "form-control", @data_value = Model.WebResourceType }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </span>\r\n                                    ");
#nullable restore
#line 30 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                               Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control", @placeholder = @app.T["entity_name"] }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <span class=\"input-group-btn\">\r\n                                        <button type=\"submit\" class=\"btn btn-info btn-block grid-searcher\"><span class=\"glyphicon glyphicon-search\"></span> ");
#nullable restore
#line 32 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                                                                                                                                                       Write(app.T["search"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 565, "/", 565, 1, true);
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 566, app.OrganizationUniqueName, 566, 27, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 593, "/customize/", 593, 11, true);
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 604, app.ControllerName, 604, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 623, "/", 623, 1, true);
#nullable restore
#line 16 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 624, app.ActionName, 624, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"table-datagrid-view\">\r\n                    <div class=\"datagrid-view\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9623270c570d891ef9dff6da74f1b3ff906987d213978", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2727, "~/content/customize/css/common.css?v=", 2727, 37, true);
#nullable restore
#line 48 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 2764, app.PlatformSettings.VersionNumber, 2764, 35, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9623270c570d891ef9dff6da74f1b3ff906987d215676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2836, "~/content/js/jquery-ui-1.10.3/themes/base/jquery.ui.all.css?v=", 2836, 62, true);
#nullable restore
#line 49 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 2898, app.PlatformSettings.VersionNumber, 2898, 35, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9623270c570d891ef9dff6da74f1b3ff906987d217399", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2970, "~/content/js/grid/pqgrid.dev.css?v=", 2970, 35, true);
#nullable restore
#line 50 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 3005, app.PlatformSettings.VersionNumber, 3005, 35, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9623270c570d891ef9dff6da74f1b3ff906987d219095", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3092, "~/content/css/theme/", 3092, 20, true);
#nullable restore
#line 51 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 3112, app.Theme, 3112, 12, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3124, ".css", 3124, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3185, "\"", 3280, 2);
                WriteAttributeValue("", 3191, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.button.js?v=", 3191, 54, true);
#nullable restore
#line 54 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 3245, app.PlatformSettings.VersionNumber, 3245, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3304, "\"", 3398, 2);
                WriteAttributeValue("", 3310, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.mouse.js?v=", 3310, 53, true);
#nullable restore
#line 55 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 3363, app.PlatformSettings.VersionNumber, 3363, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3422, "\"", 3523, 2);
                WriteAttributeValue("", 3428, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.autocomplete.js?v=", 3428, 60, true);
#nullable restore
#line 56 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 3488, app.PlatformSettings.VersionNumber, 3488, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3547, "\"", 3645, 2);
                WriteAttributeValue("", 3553, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.draggable.js?v=", 3553, 57, true);
#nullable restore
#line 57 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 3610, app.PlatformSettings.VersionNumber, 3610, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3669, "\"", 3767, 2);
                WriteAttributeValue("", 3675, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.resizable.js?v=", 3675, 57, true);
#nullable restore
#line 58 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 3732, app.PlatformSettings.VersionNumber, 3732, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 3791, "\"", 3887, 2);
                WriteAttributeValue("", 3797, "/content/js/jquery-ui-1.10.3/ui/jquery.ui.tooltip.js?v=", 3797, 55, true);
#nullable restore
#line 59 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 3852, app.PlatformSettings.VersionNumber, 3852, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9623270c570d891ef9dff6da74f1b3ff906987d224343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3917, "~/content/js/fetch.js?v=", 3917, 24, true);
#nullable restore
#line 60 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 3941, app.PlatformSettings.VersionNumber, 3941, 35, false);

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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9623270c570d891ef9dff6da74f1b3ff906987d225947", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4006, "~/content/js/common/filters.js?v=", 4006, 33, true);
#nullable restore
#line 61 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 4039, app.PlatformSettings.VersionNumber, 4039, 35, false);

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
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4098, "\"", 4172, 2);
                WriteAttributeValue("", 4104, "/content/js/grid/pqgrid.dev.js?v=", 4104, 33, true);
#nullable restore
#line 62 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 4137, app.PlatformSettings.VersionNumber, 4137, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4196, "\"", 4283, 2);
                WriteAttributeValue("", 4202, "/content/js/grid/localize/pq-localize-zh.js?v=", 4202, 46, true);
#nullable restore
#line 63 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 4248, app.PlatformSettings.VersionNumber, 4248, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4307, "\"", 4375, 2);
                WriteAttributeValue("", 4313, "/content/js/cdatagrid.js?v=", 4313, 27, true);
#nullable restore
#line 64 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 4340, app.PlatformSettings.VersionNumber, 4340, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4399, "\"", 4476, 2);
                WriteAttributeValue("", 4405, "/content/js/jquery.bootpag.min.js?v=", 4405, 36, true);
#nullable restore
#line 65 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 4441, app.PlatformSettings.VersionNumber, 4441, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4500, "\"", 4570, 2);
                WriteAttributeValue("", 4506, "/content/js/jquery.form.js?v=", 4506, 29, true);
#nullable restore
#line 66 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
WriteAttributeValue("", 4535, app.PlatformSettings.VersionNumber, 4535, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9623270c570d891ef9dff6da74f1b3ff906987d230211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4600, "~/content/js/jquery-validate/jquery.validate.min.js?v=", 4600, 54, true);
#nullable restore
#line 67 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
AddHtmlAttributeValue("", 4654, app.PlatformSettings.VersionNumber, 4654, 35, false);

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
                WriteLiteral("\r\n    <script>\r\n        var pageUrl = \'\';\r\n        var solutionid = \'");
#nullable restore
#line 70 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                     Write(Model.SolutionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n        var websourcetypes = [{ label: \'脚本\', value: \'Script\' }, { label: \'样式\', value: \'Css\' }, { label: \'网页\', value: \'Html\' }, { label: \'图片\', value: \'Picture\' }]\r\n\r\n        $(function () {\r\n\r\n            var theaders = {\r\n                \'typename\':\'");
#nullable restore
#line 76 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                       Write(app.T["typename"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                \'name\': \'");
#nullable restore
#line 77 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                    Write(app.T["name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                \'description\': \'");
#nullable restore
#line 78 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                           Write(app.T["description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                \'createdon\': \'创建时间\',\r\n                \'operation\':\'");
#nullable restore
#line 80 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                        Write(app.T["operation"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            }
            //列数据配置数据
            var columnConfigs = [
            //从新配置复选框列的渲染方式，
                {
                    title: """", dataIndx: ""recordid"", maxWidth: 48, minWidth: 48, align: ""center"", resizable: false,
                    type: 'checkBoxSelection', cls: 'ui-state-default', sortable: false, editable: false,
                    render: function (ui) {
                      //  console.log(ui)
                        return '<input type=""checkbox"" value=""' + ui.rowData.webresourceid + '"" name=""recordid"" class="""">'
                    },
                    cb: { all: true, header: true }
                },
                {
                    title: """", dataIndx: ""hidden"", maxWidth: 30, minWidth: 30, align: ""center"", resizable: false,
                     cls: 'ui-state-default', sortable: false, editable: false,
                    hidden:true,
                    render: function (ui) {
                        //  console.log(ui)
                        ret");
                WriteLiteral(@"urn '<input type=""hidden"" value=""' + ui.rowData.webresourceid + '"" name=""componenttypename"" class="""">'
                    },
                    cb: { all: true, header: true }
                },
                 { ""dataIndx"": ""webresourcetype"", ""title"": theaders.typename, editable: false, ""dataType"": ""string"", ""width"": 150, ""isprimaryfield"": false, ""attributetypename"": ""string"" , render: function (ui) {
                        var datas = ui.rowData;
                        var dataIndx = ui.dataIndx;
                        var column = ui.column;
                        var recordid = datas[dataIndx];
                     var html = ''
                     html += websourcetypes[recordid].label;
                        return html
                    }},
                { ""dataIndx"": ""name"", ""title"": theaders.name, editable: false, sortable: true, ""dataType"": ""string"", ""width"": 150, ""isprimaryfield"": false, ""attributetypename"": ""string"" },
                { ""dataIndx"": ""description"", ""title""");
                WriteLiteral(@": theaders.description, ""dataType"": ""string"", sortable: true, editable: false, ""width"": 150, ""isprimaryfield"": false, ""attributetypename"": ""string"" },

                 { ""dataIndx"": ""createdon"", ""title"": theaders.createdon, editable: false, sortable: true, ""dataType"": ""string"", ""width"": 150, ""isprimaryfield"": false, ""attributetypename"": ""string"" },
                {
                    title: ""操作"", editable: false, minWidth: 120,width:120, notHeaderFilter: true, editable: false, sortable: false, render: function (ui) {
                        var datas = ui.rowData;
                        var dataIndx = ui.dataIndx;
                        var column = ui.column;
                        var recordid = datas[dataIndx];
                        var html = ''
                        html=  ' <a class=""btn btn-default btn-xs"" href=""");
#nullable restore
#line 124 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                                                                     Write("/"+app.OrganizationUniqueName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/customize/webresource/editwebresource?id='+datas.webresourceid+'&solutionid=' + solutionid + '"" ><span class=""glyphicon glyphicon-edit""></span> 编辑</a>'+
                             ' <a class=""btn btn-warning btn-xs"" href=""javascript:Xms.Web.Del(\''+datas.webresourceid+'\',\'/customize/webresource/deletewebresource\',false,rebind,null,\'确定删除？请提前备份数据\',true)""><span class=""glyphicon glyphicon-trash""></span> 删除</a>'
                        return html
                    }
                }
            ];
           var url = ORG_SERVERURL + '/customize/");
#nullable restore
#line 130 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                                            Write(app.ControllerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 130 "G:\projects\xms_v2\Presentation\Xms.Web\Areas\Customize\Views\WebResource\Index.cshtml"
                                                                Write(app.ActionName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?LoadData=true&';
            var $form = $('#searchForm');
            var roles_filters = new XmsFilter();
            var datagridconfig = {
                scrollModel: { autoFit: true },
                baseUrl: url,
                columnConfigs: columnConfigs,//字段配置信息
                context: $('#gridview'),//底部操作按钮方法触发
                filters: roles_filters,//post提交时过滤条件
                searchForm: $form//GET提交时查询的数据
            };
            $('.datagrid-view').xmsDataTable(datagridconfig);
            $('#WebResourceType').picklist({
                items: websourcetypes,
                placeholder:'全部类型'
            });
            Xms.Web.Event.localStorageEvent.on('list_webresource_rebind', function () {
                setTimeout(function () {
                    location.reload();
                },100)
            });

        });

         function rebind() {
             $('.datagrid-view').cDatagrid('refreshDataAndView')
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Xms.Web.Framework.Context.IWebAppContext app { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xms.Web.Customize.Models.WebResourceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591