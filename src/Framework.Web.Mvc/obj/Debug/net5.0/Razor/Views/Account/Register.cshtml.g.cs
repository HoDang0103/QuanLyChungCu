#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644a6552b4de75eadfdd2500b46825923e8f212a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
using Framework.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
using Framework.Web.Security.Recaptcha;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a6552b4de75eadfdd2500b46825923e8f212a", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Register : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Models.Account.RegisterViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/App/Views/_Bundles/account-register.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        window.passwordComplexitySetting = ");
#nullable restore
#line 10 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
                                      Write(Html.Raw(Model.PasswordComplexitySetting.ToJsonString(indented: true)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </script>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
     if (ViewBag.UseCaptcha)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script-v3", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "644a6552b4de75eadfdd2500b46825923e8f212a7126", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script-v3-js", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "644a6552b4de75eadfdd2500b46825923e8f212a8119", async() => {
                }
                );
                __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper = CreateTagHelper<global::Owl.reCAPTCHA.v3.TagHelpers.reCAPTCHAV3ScriptJsTagHelper>();
                __tagHelperExecutionContext.Add(__Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper);
                __Owl_reCAPTCHA_v3_TagHelpers_reCAPTCHAV3ScriptJsTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
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
#line 17 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644a6552b4de75eadfdd2500b46825923e8f212a10024", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
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
                BeginWriteAttribute("href", " href=\"", 650, "\"", 725, 3);
                WriteAttributeValue("", 657, "/metronic/common/css/login-1", 657, 28, true);
#nullable restore
#line 23 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 685, CultureHelper.IsRtl ? ".rtl" : "", 685, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 721, ".css", 721, 4, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\"/>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"login-form\">\r\n    <div class=\"pb-13 pt-lg-0 pt-5\">\r\n        <h3 class=\"font-weight-bolder text-dark font-size-h4 font-size-h1-lg\">");
#nullable restore
#line 28 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
                                                                         Write(L("SignUp"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644a6552b4de75eadfdd2500b46825923e8f212a13119", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
         if (@ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <div class=\"alert-icon\">\r\n                    <i class=\"fa fa-exclamation-triangle\"></i>\r\n                </div>\r\n                <div class=\"alert-text\">");
#nullable restore
#line 38 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
                                   Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 40 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"IsExternalLogin\"");
                BeginWriteAttribute("value", " value=\"", 1387, "\"", 1428, 1);
#nullable restore
#line 42 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1395, Model.IsExternalLogin.ToString(), 1395, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"hidden\" name=\"ExternalLoginAuthSchema\"");
                BeginWriteAttribute("value", " value=\"", 1492, "\"", 1530, 1);
#nullable restore
#line 43 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1500, Model.ExternalLoginAuthSchema, 1500, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"hidden\" name=\"SingleSignOn\"");
                BeginWriteAttribute("value", " value=\"", 1583, "\"", 1610, 1);
#nullable restore
#line 44 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1591, Model.SingleSignIn, 1591, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"hidden\" name=\"ReturnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1660, "\"", 1684, 1);
#nullable restore
#line 45 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1668, Model.ReturnUrl, 1668, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 46 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
         if (ViewBag.UseCaptcha)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1766, "\"", 1813, 1);
#nullable restore
#line 48 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1773, RecaptchaValidator.RecaptchaResponseKey, 1773, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"recaptchaResponse\"/>\r\n");
#nullable restore
#line 49 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1999, "\"", 2023, 1);
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2013, L("Name"), 2013, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" required");
                BeginWriteAttribute("value", " value=\"", 2045, "\"", 2064, 1);
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2053, Model.Name, 2053, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2065, "\"", 2126, 1);
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2077, Framework.Authorization.Users.User.MaxNameLength, 2077, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group \">\r\n            <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2293, "\"", 2320, 1);
#nullable restore
#line 55 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2307, L("Surname"), 2307, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Surname\" required");
                BeginWriteAttribute("value", " value=\"", 2345, "\"", 2367, 1);
#nullable restore
#line 55 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2353, Model.Surname, 2353, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2368, "\"", 2432, 1);
#nullable restore
#line 55 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2380, Framework.Authorization.Users.User.MaxSurnameLength, 2380, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group \">\r\n            <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"email\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2600, "\"", 2632, 1);
#nullable restore
#line 58 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2614, L("EmailAddress"), 2614, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"EmailAddress\" required");
                BeginWriteAttribute("value", " value=\"", 2662, "\"", 2689, 1);
#nullable restore
#line 58 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2670, Model.EmailAddress, 2670, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2690, "\"", 2759, 1);
#nullable restore
#line 58 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2702, Framework.Authorization.Users.User.MaxEmailAddressLength, 2702, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </div>\r\n\r\n");
#nullable restore
#line 61 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
         if (!Model.IsExternalLogin)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                <input class=\"form-control input-ltr form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"text\" autocomplete=\"new-password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3022, "\"", 3050, 1);
#nullable restore
#line 64 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3036, L("UserName"), 3036, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 3067, "\"", 3090, 1);
#nullable restore
#line 64 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3075, Model.UserName, 3075, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 3100, "\"", 3165, 1);
#nullable restore
#line 64 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3112, Framework.Authorization.Users.User.MaxUserNameLength, 3112, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            </div>\r\n            <div class=\"form-group pwstrength-div\">\r\n                <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"password\" autocomplete=\"new-password\" id=\"RegisterPassword\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3412, "\"", 3440, 1);
#nullable restore
#line 67 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3426, L("Password"), 3426, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Password\" required/>\r\n            </div>\r\n            <div class=\"form-group \">\r\n                <input class=\"form-control form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"password\" autocomplete=\"new-password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3676, "\"", 3710, 1);
#nullable restore
#line 70 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3690, L("PasswordRepeat"), 3690, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PasswordRepeat\" required/>\r\n            </div>\r\n");
#nullable restore
#line 72 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"pb-lg-0 pb-5\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644a6552b4de75eadfdd2500b46825923e8f212a24695", async() => {
                    WriteLiteral("\r\n                <button type=\"button\" id=\"register-back-btn\" class=\"btn btn-light-primary font-weight-bolder font-size-h6 px-8 py-4 my-3\">");
#nullable restore
#line 76 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
                                                                                                                                     Write(L("Back"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" id=\"register-submit-btn\" class=\"btn btn-primary font-weight-bolder font-size-h6 px-8 py-4 my-3 mr-3\">");
#nullable restore
#line 78 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Account\Register.cshtml"
                                                                                                                                  Write(L("Submit"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Models.Account.RegisterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
