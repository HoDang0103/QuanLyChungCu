#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d07a99ab78e1a9599f0e014015046f8c5b1eeda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using Abp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using Framework.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using Framework.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using Framework.Web.Security.Recaptcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
using Owl.reCAPTCHA;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d07a99ab78e1a9599f0e014015046f8c5b1eeda", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Login : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Models.Account.LoginFormViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Account/Login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Owl.reCAPTCHA.v3.TagHelpers.reCAPTCHAV3ScriptTagHelper __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptTagHelper;
        private global::Owl.reCAPTCHA.v3.TagHelpers.reCAPTCHAV3ScriptJsTagHelper __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
     if (ViewBag.UseCaptcha)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script-v3", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d07a99ab78e1a9599f0e014015046f8c5b1eeda7303", async() => {
                }
                );
                __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptTagHelper = CreateTagHelper<global::Owl.reCAPTCHA.v3.TagHelpers.reCAPTCHAV3ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script-v3-js", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d07a99ab78e1a9599f0e014015046f8c5b1eeda8296", async() => {
                }
                );
                __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper = CreateTagHelper<global::Owl.reCAPTCHA.v3.TagHelpers.reCAPTCHAV3ScriptJsTagHelper>();
                __tagHelperExecutionContext.Add(__Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper);
                __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
__Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper.Execute = false;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("execute", __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper.Execute, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d07a99ab78e1a9599f0e014015046f8c5b1eeda10191", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
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
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 619, "\"", 694, 3);
                WriteAttributeValue("", 626, "/metronic/common/css/login-1", 626, 28, true);
#nullable restore
#line 23 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 654, CultureHelper.IsRtl ? ".rtl" : "", 654, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 690, ".css", 690, 4, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\"/>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
 if (!Model.SuccessMessage.IsNullOrEmpty())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
   Write(Model.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--begin::Signin-->\r\n<div class=\"login-form\">\r\n    <div class=\"pb-13 pt-lg-0 pt-5\">\r\n        <h3 class=\"font-weight-bolder text-dark font-size-h4 font-size-h1-lg\">");
#nullable restore
#line 39 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                                         Write(L("LogIn"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <!--begin::Form-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d07a99ab78e1a9599f0e014015046f8c5b1eeda14291", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1387, "\"", 1413, 1);
#nullable restore
#line 43 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1395, ViewBag.ReturnUrl, 1395, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"hidden\" name=\"returnUrlHash\"/>\r\n        <input type=\"hidden\" name=\"ss\"");
                BeginWriteAttribute("value", " value=\"", 1509, "\"", 1538, 1);
#nullable restore
#line 45 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1517, ViewBag.SingleSignIn, 1517, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 46 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
         if (ViewBag.UseCaptcha)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1620, "\"", 1667, 1);
#nullable restore
#line 48 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1627, RecaptchaValidator.RecaptchaResponseKey, 1627, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"recaptchaResponse\"/>\r\n");
#nullable restore
#line 49 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1853, "\"", 1888, 1);
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1867, L("UserNameOrEmail"), 1867, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"usernameOrEmailAddress\" autocomplete=\"new-password\"");
                BeginWriteAttribute("value", " value=\"", 1947, "\"", 1992, 1);
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1955, Model.UserNameOrEmailAddress ?? "", 1955, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2172, "\"", 2200, 1);
#nullable restore
#line 56 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 2186, L("Password"), 2186, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""password"" autocomplete=""new-password"">
        </div>

        <div class=""form-group d-flex justify-content-between mt-4"">
            <label class=""checkbox checkbox-outline"">
                <input type=""checkbox"" name=""rememberMe"" value=""true"">
                <span>
                </span>
                ");
#nullable restore
#line 64 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
           Write(L("RememberMe"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </label>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 2582, "\"", 2629, 1);
#nullable restore
#line 66 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 2589, Url.Action("ForgotPassword", "Account"), 2589, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"forget-password\" class=\"text-primary font-size-h6 font-weight-bolder text-hover-primary\">");
#nullable restore
#line 66 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                                                       Write(L("ForgotPassword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n        </div>\r\n\r\n        <!--begin::Action-->\r\n        <div class=\"pb-lg-0 pb-5\">\r\n            <button type=\"button\" id=\"kt_login_signin_submit\" class=\"btn btn-block btn-primary font-weight-bolder font-size-h6 px-8 py-4 my-3 mr-3\">");
#nullable restore
#line 71 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                                               Write(L("LogIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n        </div>\r\n\r\n        <!--end::Action-->\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <!--end::Form-->\r\n\r\n    <!--begin::Options-->\r\n");
#nullable restore
#line 80 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
      
        var loginProviders = (await SignInManager.GetExternalAuthenticationSchemesAsync())
            .Where(s => !s.DisplayName.IsNullOrWhiteSpace())
            .ToList();

        Func<string, string> getSocialIconClass = (provider) =>
        {
            provider = provider.ToLower(CultureInfo.InvariantCulture);
            return provider;
        };
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
     if ((AbpSession.MultiTenancySide != MultiTenancySides.Host || !ViewBag.IsMultiTenancyEnabled) && loginProviders.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--begin::Divider-->\r\n        <div class=\"divider mt-10 mb-2\">\r\n            <div class=\"divider\">\r\n                <span>");
#nullable restore
#line 97 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                 Write(L("LoginWith"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <!--end::Divider-->\r\n        <div class=\"pb-lg-0 pb-5 external-logins\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d07a99ab78e1a9599f0e014015046f8c5b1eeda23229", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 4026, "\"", 4052, 1);
#nullable restore
#line 104 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 4034, ViewBag.ReturnUrl, 4034, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                <input type=\"hidden\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 4109, "\"", 4117, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n                <input type=\"hidden\" name=\"ss\"");
                BeginWriteAttribute("value", " value=\"", 4168, "\"", 4197, 1);
#nullable restore
#line 106 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 4176, ViewBag.SingleSignIn, 4176, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n\r\n");
#nullable restore
#line 108 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                 foreach (var p in loginProviders)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a href=\"javascript:;\" data-provider=\"");
#nullable restore
#line 110 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                     Write(p.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"btn btn-sm btn-light-primary font-weight-bolder py-2 social-login-icon mb-2\">\r\n                        <i");
                BeginWriteAttribute("class", " class=\"", 4461, "\"", 4510, 3);
                WriteAttributeValue("", 4469, "fab", 4469, 3, true);
                WriteAttributeValue(" ", 4472, "fa-", 4473, 4, true);
#nullable restore
#line 111 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 4476, getSocialIconClass(p.DisplayName), 4476, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                        ");
#nullable restore
#line 112 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                   Write(p.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 114 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 117 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--end::Options-->\r\n</div>\r\n\r\n<div class=\"mt-5\">\r\n    <div>\r\n        <span>");
#nullable restore
#line 123 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
         Write(L("NotAMemberYet"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 125 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
     if (Model.IsSelfRegistrationEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 4827, "\"", 4932, 1);
#nullable restore
#line 127 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 4834, Url.Action("Register", "Account", new {ss = ViewBag.SingleSignIn, returnUrl = ViewBag.ReturnUrl}), 4834, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"register-btn\">");
#nullable restore
#line 127 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                                  Write(L("CreateAnAccount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <span class=\"pipe-divider\"> | </span>\r\n");
#nullable restore
#line 129 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
     if (Model.IsTenantSelfRegistrationEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 5099, "\"", 5156, 1);
#nullable restore
#line 132 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 5106, Url.Action("SelectEdition", "TenantRegistration"), 5106, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"register-btn\">");
#nullable restore
#line 132 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                                                  Write(L("NewTenant"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <span class=\"pipe-divider\"> | </span>\r\n");
#nullable restore
#line 134 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 5257, "\"", 5305, 1);
#nullable restore
#line 135 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 5264, Url.Action("EmailActivation", "Account"), 5264, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"email-activation-btn\">");
#nullable restore
#line 135 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Login.cshtml"
                                                                             Write(L("EmailActivation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Models.Account.LoginFormViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
