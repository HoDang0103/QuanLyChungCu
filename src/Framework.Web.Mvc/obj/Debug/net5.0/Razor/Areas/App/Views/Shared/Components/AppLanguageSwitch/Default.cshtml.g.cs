#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7569f27e53b4236e9fe3c5ce3ef1ec477c33b81a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Shared_Components_AppLanguageSwitch_Default), @"mvc.1.0.view", @"/Areas/App/Views/Shared/Components/AppLanguageSwitch/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7569f27e53b4236e9fe3c5ce3ef1ec477c33b81a", @"/Areas/App/Views/Shared/Components/AppLanguageSwitch/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Shared_Components_AppLanguageSwitch_Default : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Areas.App.Models.Layout.LanguageSwitchViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
 if (Model.Languages.Count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown dropdown-language\" aria-haspopup=\"true\">\r\n        <div class=\"topbar-item\" data-toggle=\"dropdown\" data-offset=\"10px,0px\" aria-expanded=\"false\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 292, "\"", 315, 1);
#nullable restore
#line 6 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 300, Model.CssClass, 300, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 337, "\"", 372, 1);
#nullable restore
#line 7 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 345, Model.CurrentLanguage.Icon, 345, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-label", " aria-label=\"", 373, "\"", 413, 1);
#nullable restore
#line 7 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 386, Model.CurrentLanguage.Icon, 386, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </div>\r\n        </div>\r\n        <div class=\"dropdown-menu p-0 m-0 dropdown-menu-anim-up dropdown-menu-sm dropdown-menu-right\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 558, "\"", 586, 1);
#nullable restore
#line 10 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 571, L("Languages"), 571, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <ul class=\"navi navi-hover py-4\">\r\n");
#nullable restore
#line 12 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
                 foreach (var languageInfo in Model.Languages.Where(language => language.Name != Model.CurrentLanguage.Name))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"navi-item\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 1021, 1);
#nullable restore
#line 15 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 860, Url.Action("ChangeCulture", "AbpLocalization", new {area = "", cultureName = languageInfo.Name, returnUrl = Context.Request.Path + Context.Request.QueryString}), 860, 161, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"navi-link\">\r\n                            <span class=\"symbol symbol-20 mr-3\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 1143, "\"", 1169, 1);
#nullable restore
#line 17 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
WriteAttributeValue("", 1151, languageInfo.Icon, 1151, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </span>\r\n                            <span class=\"navi-text\">\r\n                                ");
#nullable restore
#line 20 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
                           Write(languageInfo.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 24 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\AppLanguageSwitch\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Areas.App.Models.Layout.LanguageSwitchViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
