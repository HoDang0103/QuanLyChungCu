#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme11\Components\AppTheme11Brand\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abcd4979a5b4c8e2db240f307956349e6f7e2b45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Shared_Themes_Theme11_Components_AppTheme11Brand_Default), @"mvc.1.0.view", @"/Areas/App/Views/Shared/Themes/Theme11/Components/AppTheme11Brand/Default.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme11\Components\AppTheme11Brand\Default.cshtml"
using Framework.Web.Areas.App.Models.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme11\Components\AppTheme11Brand\Default.cshtml"
using Framework.Web.Areas.App.Views.Shared.Components.AppLogo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abcd4979a5b4c8e2db240f307956349e6f7e2b45", @"/Areas/App/Views/Shared/Themes/Theme11/Components/AppTheme11Brand/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Shared_Themes_Theme11_Components_AppTheme11Brand_Default : Framework.Web.Views.FrameworkRazorPage<HeaderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme11\Components\AppTheme11Brand\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\"", 165, "\"", 227, 1);
#nullable restore
#line 8 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme11\Components\AppTheme11Brand\Default.cshtml"
WriteAttributeValue("", 172, Url.Action("Index", "Home", new {area = string.Empty}), 172, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"brand-logo\">\r\n    ");
#nullable restore
#line 9 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme11\Components\AppTheme11Brand\Default.cshtml"
Write(await Component.InvokeAsync(typeof(AppLogoViewComponent), new {LogoSkin = "light"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
