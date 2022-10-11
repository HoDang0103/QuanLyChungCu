#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ae51ac7a8fffdc043a236ba15e942e46d0dfc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Roles_Index), @"mvc.1.0.view", @"/Areas/App/Views/Roles/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
using Abp.Application.Services.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
using Framework.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
using Framework.Web.Areas.App.Models.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
using Framework.Web.Areas.App.Startup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ae51ac7a8fffdc043a236ba15e942e46d0dfc6", @"/Areas/App/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Roles_Index : Framework.Web.Views.FrameworkRazorPage<RoleListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/_Bundles/role-list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkPageSubheaderTagHelper __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
  
    ViewBag.CurrentPageName = AppPageNames.Common.Roles;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ae51ac7a8fffdc043a236ba15e942e46d0dfc64860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"content d-flex flex-column flex-column-fluid\" id=\"kt_content\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("abp-page-subheader", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ae51ac7a8fffdc043a236ba15e942e46d0dfc66819", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
         if (IsGranted(AppPermissions.Pages_Administration_Roles_Create))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button id=\"CreateNewRoleButton\" class=\"btn btn-primary\">\r\n                <i class=\"la la-plus\"></i> ");
#nullable restore
#line 20 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                                      Write(L("CreateNewRole"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </button>\r\n");
#nullable restore
#line 22 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkPageSubheaderTagHelper>();
            __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                   WriteLiteral(L("Roles"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Title = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("title", __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                                             WriteLiteral(L("RolesHeaderInfo"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Description = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("description", __Framework_Web_TagHelpers_FrameworkPageSubheaderTagHelper.Description, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 836, "\"", 872, 1);
#nullable restore
#line 25 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
WriteAttributeValue("", 844, await GetContainerClass(), 844, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""card card-custom gutter-b"">
            <div class=""card-body"">
                <div class=""form"">
                    <div class=""row mb-4"">
                        <div class=""col-xl-6"">
                            <div class=""form-group"">
                                <button class=""btn btn-default btn-block"" id=""FilterByPermissionsButton"">");
#nullable restore
#line 32 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                                                                                                    Write(L("SelectPermissions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" (<span id=""NumberOfFilteredPermission"">0</span>)</button>
                            </div>
                        </div>
                        <div class=""col-xl-6 text-right"">
                            <button id=""RefreshRolesButton"" class=""btn btn-primary"">
                                <i class=""la la-refresh""></i> ");
#nullable restore
#line 37 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                                                         Write(L("Refresh"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </button>
                        </div>
                    </div>
                </div>
                <div class=""align-items-center"">
                    <table id=""RolesTable"" class=""display table table-separate table-head-custom no-footer dtr-inline dt-responsive nowrap"">
                        <thead>
                        <tr>
                            <th></th>
                            <th>");
#nullable restore
#line 47 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                           Write(L("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 48 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                           Write(L("RoleName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 49 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Roles\Index.cshtml"
                           Write(L("CreationTime"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                        </thead>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
