#pragma checksum "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5af15bc2949d3c19dbd867de5d9f3d9ac70f5288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ModulGuest_Views_Guest_PretraziPoNazivu), @"mvc.1.0.view", @"/Areas/ModulGuest/Views/Guest/PretraziPoNazivu.cshtml")]
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
#line 1 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
using Event_Attender.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af15bc2949d3c19dbd867de5d9f3d9ac70f5288", @"/Areas/ModulGuest/Views/Guest/PretraziPoNazivu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9097ad0c2f81adf715fe93e53aeb465025b54b6", @"/Areas/ModulGuest/Views/_ViewImports.cshtml")]
    public class Areas_ModulGuest_Views_Guest_PretraziPoNazivu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event_Attender.Web.Areas.ModulGuest.Models.PretragaEventaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/items/events.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
  
    ViewData["Title"] = "PretraziPoNazivu";
    DateTime date = DateTime.Now;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    form {
        margin-top: 2%;
    }

    a.btn {
        color: grey;
        margin-top: 1%;
    }

    #pretraga {
        color: grey;
    }

        #pretraga:hover {
            color: black;
        }

    td {
        width: 50%;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af15bc2949d3c19dbd867de5d9f3d9ac70f52886507", async() => {
                WriteLiteral(@"
    <div class=""input-group"">
        <input type=""text"" class=""form-control"" placeholder=""Search"" name=""filter"" maxlength=""40"">
        <div class=""input-group-btn"">
            <button id=""pretraga"" class=""btn btn-light"" type=""submit"">
                Traži
            </button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
 if (Model.Eventi != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
             foreach (var e in Model.Eventi)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        <div>\r\n");
#nullable restore
#line 54 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                             if (e.Slika != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5af15bc2949d3c19dbd867de5d9f3d9ac70f52889121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1274, "~/images/items/", 1274, 15, true);
#nullable restore
#line 56 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
AddHtmlAttributeValue("", 1289, e.Slika, 1289, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5af15bc2949d3c19dbd867de5d9f3d9ac70f528811171", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </td>\r\n\r\n                    <td style=\"padding-top:8%\">\r\n                        <div>\r\n                            <strong>");
#nullable restore
#line 67 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                               Write(e.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <br />\r\n\r\n                            ");
#nullable restore
#line 69 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                       Write(e.ProstorOdrzavanjaNaziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br />\r\n                            ");
#nullable restore
#line 71 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                       Write(e.ProstorOdrzavanjaGrad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <br />\r\n\r\n                            ");
#nullable restore
#line 75 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                       Write(e.DatumOdrzavanja);

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 75 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
                                           Write(e.VrijemeOdrzavanja);

#line default
#line hidden
#nullable disable
            WriteLiteral(" h\r\n\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 83 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulGuest\Views\Guest\PretraziPoNazivu.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af15bc2949d3c19dbd867de5d9f3d9ac70f528815058", async() => {
                WriteLiteral("Nazad na početnu stranicu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event_Attender.Web.Areas.ModulGuest.Models.PretragaEventaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591