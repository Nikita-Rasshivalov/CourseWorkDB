#pragma checksum "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd6e9d0e406b78f5c713e2951cb48bd64815a90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Employees), @"mvc.1.0.view", @"/Views/Employee/Employees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd6e9d0e406b78f5c713e2951cb48bd64815a90", @"/Views/Employee/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6b10ce4b366ee789903c29f95deb0eea431c31", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageItemsModel<EmployeeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Employees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::RadiostationWeb.TagHelpers.PageLinkTagHelper __RadiostationWeb_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-container\">\r\n    <div class=\"container-item\">\r\n");
#nullable restore
#line 8 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
         if (@Model?.Items.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Email</th>
                        <th>Name</th>
                        <th>Surname</th>
                        <th>Middle Name</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 23 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                     foreach (var empl in @Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                           Write(empl.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                           Write(empl.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                           Write(empl.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                           Write(empl.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                           Write(empl.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"pages-container\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd6e9d0e406b78f5c713e2951cb48bd64815a906789", async() => {
            }
            );
            __RadiostationWeb_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::RadiostationWeb.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__RadiostationWeb_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 35 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
__RadiostationWeb_TagHelpers_PageLinkTagHelper.PageModel = Model.PageModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __RadiostationWeb_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __RadiostationWeb_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 36 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>There are no employees </h3>\r\n");
#nullable restore
#line 40 "C:\Users\nikit\Desktop\БД\CousreWorkDb\CourseWorkDB\Radiostation\RadiostationWeb\Views\Employee\Employees.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageItemsModel<EmployeeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
