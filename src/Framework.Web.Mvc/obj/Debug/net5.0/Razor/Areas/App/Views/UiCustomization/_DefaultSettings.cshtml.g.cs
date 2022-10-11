#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3de3889600e373b2d7860c8ddb463f4a77a835a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_UiCustomization__DefaultSettings), @"mvc.1.0.view", @"/Areas/App/Views/UiCustomization/_DefaultSettings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3de3889600e373b2d7860c8ddb463f4a77a835a", @"/Areas/App/Views/UiCustomization/_DefaultSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_UiCustomization__DefaultSettings : Framework.Web.Views.FrameworkRazorPage<Framework.Configuration.Dto.ThemeSettingsDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("HeaderSettingsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("SubHeaderSettingsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("MenuSettingsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("FooterSettingsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<ul class=\"nav nav-tabs\" role=\"tablist\">\r\n    <li class=\"nav-item\">\r\n        <a href=\"#DefaultHeader\" class=\"nav-link active\" data-toggle=\"tab\" role=\"tab\">\r\n            ");
#nullable restore
#line 6 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
       Write(L("UiCustomization_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a href=\"#DefaultMenu\" class=\"nav-link\" data-toggle=\"tab\" role=\"tab\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
       Write(L("UiCustomization_Menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a href=\"#DefaultFooter\" class=\"nav-link\" data-toggle=\"tab\" role=\"tab\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
       Write(L("UiCustomization_Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </li>\r\n</ul>\r\n<div class=\"tab-content m-5\">\r\n    <div id=\"DefaultHeader\" class=\"tab-pane active\">\r\n        <input type=\"hidden\" name=\"Theme\" value=\"default\"/>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3de3889600e373b2d7860c8ddb463f4a77a835a6267", async() => {
                WriteLiteral("\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 24 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_HeaderSkin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
           Write(Html.DropDownList("HeaderSkin", new SelectList(new List<SelectListItem> {new SelectListItem {Text = L("UiCustomization_Light"), Value = "light"}, new SelectListItem {Text = L("UiCustomization_Dark"), Value = "dark"}}, "Value", "Text", Model.Header.HeaderSkin), new {@class = "form-control col-md-4 col-sm-12", id = "HeaderSkin"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 28 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_Desktop"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"DesktopFixedHeader\" value=\"true\" ");
#nullable restore
#line 31 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                              Write(Model.Header.DesktopFixedHeader ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_DesktopFixedHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 36 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_Mobile"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"MobileFixedHeader\" value=\"true\" ");
#nullable restore
#line 39 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                             Write(Model.Header.MobileFixedHeader ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_MobileFixedHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3de3889600e373b2d7860c8ddb463f4a77a835a11237", async() => {
                WriteLiteral("\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 46 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_SubHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"FixedSubHeader\" value=\"true\" ");
#nullable restore
#line 49 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                          Write(Model.SubHeader.FixedSubHeader ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_FixedSubHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div id=\"DefaultMenu\" class=\"tab-pane\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3de3889600e373b2d7860c8ddb463f4a77a835a13945", async() => {
                WriteLiteral("\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 58 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_MenuSkin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
           Write(Html.DropDownList("AsideSkin", new SelectList(new List<SelectListItem> {new SelectListItem {Text = L("UiCustomization_Light"), Value = "light"}, new SelectListItem {Text = L("UiCustomization_Dark"), Value = "dark"}}, "Value", "Text", Model.Menu.AsideSkin), new {@class = "form-control col-md-4 col-sm-12", id = "AsideSkin"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"FixedAside\" value=\"true\" ");
#nullable restore
#line 64 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                      Write(Model.Menu.FixedAside ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_FixedMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"AllowAsideMinimizing\" value=\"true\" ");
#nullable restore
#line 71 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                                Write(Model.Menu.AllowAsideMinimizing ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_AllowAsideMinimizing"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"DefaultMinimizedAside\" value=\"true\" ");
#nullable restore
#line 78 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                                 Write(Model.Menu.DefaultMinimizedAside ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 80 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_DefaultMinimizedAside"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"HoverableAside\" value=\"true\" ");
#nullable restore
#line 85 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                          Write(Model.Menu.HoverableAside ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 87 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_HoverableAside"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 90 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_SubmenuToggle"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 92 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
           Write(Html.DropDownList("SubmenuToggle", new SelectList(new List<SelectListItem> {new SelectListItem {Text = L("UiCustomization_SubmenuToggle_Accordion"), Value = "false"}, new SelectListItem {Text = L("UiCustomization_SubmenuToggle_Dropdown"), Value = "true"}}, "Value", "Text", Model.Menu.SubmenuToggle), new {@class = "form-control col-md-4 col-sm-12", id = "SubmenuToggle"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"SearchActive\" value=\"true\" ");
#nullable restore
#line 97 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                        Write(Model.Menu.SearchActive ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 99 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("ShowMenuSearchInput"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div id=\"DefaultFooter\" class=\"tab-pane\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3de3889600e373b2d7860c8ddb463f4a77a835a22267", async() => {
                WriteLiteral("\r\n            <h5 class=\"mb-2\">");
#nullable restore
#line 106 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                        Write(L("UiCustomization_Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"form-group\">\r\n                <label class=\"checkbox checkbox-outline col-lg-12\">\r\n                    <input type=\"checkbox\" name=\"FixedFooter\" value=\"true\" ");
#nullable restore
#line 109 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
                                                                       Write(Model.Footer.FixedFooter ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 111 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\UiCustomization\_DefaultSettings.cshtml"
               Write(L("UiCustomization_FixedFooter"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Configuration.Dto.ThemeSettingsDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
