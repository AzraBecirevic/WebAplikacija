#pragma checksum "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Views\Sponzor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7b64b3e24eb01954e722b41ee5dac0da416966a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sponzor_Index), @"mvc.1.0.view", @"/Views/Sponzor/Index.cshtml")]
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
#line 1 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Views\_ViewImports.cshtml"
using Event_Attender.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Views\_ViewImports.cshtml"
using Event_Attender.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7b64b3e24eb01954e722b41ee5dac0da416966a", @"/Views/Sponzor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd02d6cc48dd989017580c7483e039d1e30f55b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sponzor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    
    <table class=""table"">
        <tbody>
            <tr>
                <th scope=""row"">Linkovi</th>
                <td>
                    <a href=""Sponzor/SponzorGetAll"">Lista sponzora</a><br />
                </td>
                <td>
                    <a href=""Sponzor/SponzorAddForm"">Forma za dodavanje sponzora</a>
                </td>
            </tr>
        </tbody>
    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
