#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7eff440803426c421c563803ec4fe16d8770bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Shared_Themes_Theme10_Components_AppTheme10Footer_Default), @"mvc.1.0.view", @"/Areas/App/Views/Shared/Themes/Theme10/Components/AppTheme10Footer/Default.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
using Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
using Framework.Web.Areas.App.Models.Layout;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7eff440803426c421c563803ec4fe16d8770bc", @"/Areas/App/Views/Shared/Themes/Theme10/Components/AppTheme10Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Shared_Themes_Theme10_Components_AppTheme10Footer_Default : Framework.Web.Views.FrameworkRazorPage<FooterViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"footer py-2 py-lg-0 my-5 d-flex flex-lg-column \" id=\"kt_footer\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 201, "\"", 311, 6);
#nullable restore
#line 8 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
WriteAttributeValue("", 209, await GetContainerClass(), 209, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 237, "d-flex", 238, 7, true);
            WriteAttributeValue(" ", 244, "flex-column", 245, 12, true);
            WriteAttributeValue(" ", 256, "flex-md-row", 257, 12, true);
            WriteAttributeValue(" ", 268, "align-items-center", 269, 19, true);
            WriteAttributeValue(" ", 287, "justify-content-between", 288, 24, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"text-dark order-2 order-md-1\">\r\n            <span class=\"text-muted font-weight-bold mr-2\">\r\n                ");
#nullable restore
#line 11 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
           Write(Model.GetProductNameWithEdition());

#line default
#line hidden
#nullable disable
            WriteLiteral(" | v");
#nullable restore
#line 11 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
                                                  Write(AppVersionHelper.Version);

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 11 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Themes\Theme10\Components\AppTheme10Footer\Default.cshtml"
                                                                              Write(AppVersionHelper.ReleaseDate.ToString("yyyyMMdd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\r\n            </span>\r\n            <div class=\"nav nav-dark order-1 order-md-2\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
