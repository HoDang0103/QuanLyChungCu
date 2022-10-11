#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454b009807062e5e5062423fbabbfc5367d387a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TenantChange__ChangeModal), @"mvc.1.0.view", @"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using Framework.Web.Areas.App.Models.Common.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using Framework.Web.Views.Shared.Components.TenantChange;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454b009807062e5e5062423fbabbfc5367d387a4", @"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TenantChange__ChangeModal : Framework.Web.Views.FrameworkRazorPage<ChangeModalViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TenantChangeForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
Write(await Html.PartialAsync("~/Areas/App/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("ChangeTenant"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454b009807062e5e5062423fbabbfc5367d387a45617", async() => {
                WriteLiteral("\r\n\r\n        <div class=\"form-group row text-left mb-0\">\r\n            <label class=\"col-4 col-form-label\">");
#nullable restore
#line 15 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                                           Write(L("SwitchToTenant"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            <div class=""col"">
                <span class=""switch switch-icon"">
                    <label>
                        <input id=""SwitchToTenant""
                               name=""SwitchToTenant""
                               type=""checkbox""
                               ");
#nullable restore
#line 22 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                           Write(string.IsNullOrEmpty(Model.TenancyName) ? "" : "checked='checked'");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                               value=\"");
#nullable restore
#line 23 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                                  Write(string.IsNullOrEmpty(Model.TenancyName) ? "false" : "true");

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                        <span></span>\r\n                    </label>\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group row mb-0\">\r\n            <label class=\"col-4 col-form-label\">\r\n                <label>");
#nullable restore
#line 32 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                  Write(L("TenancyName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </label>
            <label class=""col"">
                <input class=""form-control""
                       type=""text""
                       id=""TenancyName""
                       name=""TenancyName""
                       required
                       ");
#nullable restore
#line 40 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                   Write(string.IsNullOrEmpty(Model.TenancyName) ? "disabled" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                       maxlength=\"");
#nullable restore
#line 41 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                             Write(AbpTenantBase.MaxTenancyNameLength);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                       value=\"");
#nullable restore
#line 42 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                         Write(Model.TenancyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                <span id=\"TenancyNameRequired\" class=\"form-text text-danger text-left d-none\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
               Write(L("TenancyNameRequired"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </span>\r\n            </label>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"modal-footer\">\r\n    <button type=\"button\" class=\"btn btn-light-primary font-weight-bold close-button\" data-dismiss=\"modal\">");
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                                                                                                      Write(L("Cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button type=\"button\" class=\"btn btn-primary font-weight-bold save-button\"><i class=\"fa fa-arrow-circle-right\"></i> <span>");
#nullable restore
#line 53 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                                                                                                                          Write(string.IsNullOrEmpty(Model.TenancyName) ? L("SwitchToTheHost") : L("SwitchToTheTenant"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangeModalViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
