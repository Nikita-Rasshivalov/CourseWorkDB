#pragma checksum "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d015aea0288acb8ef7bc1f8cd00b344622c5f5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d015aea0288acb8ef7bc1f8cd00b344622c5f5", @"/Views/Broadcast/Broadcasts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6b10ce4b366ee789903c29f95deb0eea431c31", @"/Views/_ViewImports.cshtml")]
    public class Views_Broadcast_Broadcasts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageItemsModel<BroadcastViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("crudLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageRecords", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Record", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Records", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::RadiostationWeb.TagHelpers.PageLinkTagHelper __RadiostationWeb_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
  
    ViewData["Title"] = "Records";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"main-container\">\r\n    <div class=\"container-item\">\r\n");
#nullable restore
#line 11 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
         if (User.IsInRole(RoleType.Admin) || User.IsInRole(RoleType.Employeе))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"crudBtn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d015aea0288acb8ef7bc1f8cd00b344622c5f55276", async() => {
                WriteLiteral("Manage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
         if (@Model?.Items?.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th>Employee Name</th>
                        <th>Employee Surname</th>
                        <th>Date and time</th>
                        <th>Record name</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 28 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                     foreach (var broadcast in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.EmployeeSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.DateAndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                           Write(broadcast.RecordName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"pages-container\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d015aea0288acb8ef7bc1f8cd00b344622c5f59608", async() => {
            }
            );
            __RadiostationWeb_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 40 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
__RadiostationWeb_TagHelpers_PageLinkTagHelper.PageModel = Model.PageModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __RadiostationWeb_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __RadiostationWeb_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 41 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>There are no record</h3>\r\n");
#nullable restore
#line 46 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Broadcast\Broadcasts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RadiostationWeb.Data.RadiostationWebDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageItemsModel<BroadcastViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
