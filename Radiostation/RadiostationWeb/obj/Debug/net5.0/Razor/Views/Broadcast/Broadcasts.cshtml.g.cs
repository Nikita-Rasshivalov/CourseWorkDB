#pragma checksum "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee3fd4be1134ff69acfb8c83911b19ee420e7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Broadcast_Broadcasts), @"mvc.1.0.view", @"/Views/Broadcast/Broadcasts.cshtml")]
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
#line 1 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\_ViewImports.cshtml"
using RadiostationWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\_ViewImports.cshtml"
using RadiostationWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee3fd4be1134ff69acfb8c83911b19ee420e7a3", @"/Views/Broadcast/Broadcasts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6b10ce4b366ee789903c29f95deb0eea431c31", @"/Views/_ViewImports.cshtml")]
    public class Views_Broadcast_Broadcasts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BroadcastsItemModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("crudLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Broadcast", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Broadcasts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageBroadcasts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", "Broadcasts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Broadcasts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::RadiostationWeb.TagHelpers.SortHeaderTagHelper __RadiostationWeb_TagHelpers_SortHeaderTagHelper;
        private global::RadiostationWeb.TagHelpers.PageLinkTagHelper __RadiostationWeb_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
  
    ViewData["Title"] = "Broadcasts";
    var start = (string)Context.Request.Query["broadcastsFrom"] ?? Context.Request.Cookies["broadcastsFrom"];
    var end = (string)Context.Request.Query["broadcastsTo"] ?? Context.Request.Cookies["broadcastsTo"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-container\">\r\n    <div class=\"formContainer\">\r\n        <h2 class=\"title\">Broadcasts</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a37135", async() => {
                WriteLiteral("\r\n            <div class=\"wrapper-items\">\r\n                <div class=\"items\">\r\n                    <div>Date from</div>\r\n                    <input class=\"inputStyle\" name=\"start\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 713, "\"", 727, 1);
#nullable restore
#line 15 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
WriteAttributeValue("", 721, start, 721, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"items\">\r\n                    <div>Date to</div>\r\n                    <input class=\"inputStyle\" name=\"end\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 902, "\"", 914, 1);
#nullable restore
#line 19 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
WriteAttributeValue("", 910, end, 910, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"formButtons\">\r\n                <input type=\"submit\" class=\"addRecordbtn\" value=\"Find\">\r\n                <div class=\"crudBtn reset\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a38813", async() => {
                    WriteLiteral(" Reset");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"container-item\">\r\n");
#nullable restore
#line 29 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
         if (User.IsInRole(RoleType.Admin) || User.IsInRole(RoleType.Employeе))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"crudBtn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a312435", async() => {
                WriteLiteral("Manage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 32 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
         if (@Model?.Items?.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n\r\n                        <th>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sort-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a314531", async() => {
                WriteLiteral("\r\n                                Employee Name\r\n                            ");
            }
            );
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.SortHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_SortHeaderTagHelper);
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 40 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up = Model.SortViewModel.Up;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("up", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current = Model.SortViewModel.Current;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property = Model.SortViewModel.NameSort;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("property", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sort-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a317335", async() => {
                WriteLiteral("\r\n                                Employee Surname\r\n                            ");
            }
            );
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.SortHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_SortHeaderTagHelper);
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 46 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up = Model.SortViewModel.Up;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("up", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current = Model.SortViewModel.Current;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property = Model.SortViewModel.SurnameSort;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("property", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sort-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a320145", async() => {
                WriteLiteral("\r\n                                Date and time\r\n                            ");
            }
            );
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.SortHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_SortHeaderTagHelper);
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 52 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up = Model.SortViewModel.Up;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("up", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current = Model.SortViewModel.Current;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property = Model.SortViewModel.DateSort;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("property", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sort-header", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a322949", async() => {
                WriteLiteral("\r\n                                Record name\r\n                            ");
            }
            );
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.SortHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_SortHeaderTagHelper);
            __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 58 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up = Model.SortViewModel.Up;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("up", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Up, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current = Model.SortViewModel.Current;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Current, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property = Model.SortViewModel.RecordSort;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("property", __RadiostationWeb_TagHelpers_SortHeaderTagHelper.Property, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n");
#nullable restore
#line 67 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                     foreach (var broadcast in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 70 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.DateAndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.RecordName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"pages-container\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee3fd4be1134ff69acfb8c83911b19ee420e7a327814", async() => {
            }
            );
            __RadiostationWeb_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 79 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_PageLinkTagHelper.PageModel = Model.PageModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __RadiostationWeb_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __RadiostationWeb_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 80 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>There are no broadcasts</h3>\r\n");
#nullable restore
#line 85 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BroadcastsItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
