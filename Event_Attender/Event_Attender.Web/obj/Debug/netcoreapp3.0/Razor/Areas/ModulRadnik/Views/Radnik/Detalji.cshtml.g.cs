#pragma checksum "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b646e9d92414207c78f2802aac09698c7a844c92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ModulRadnik_Views_Radnik_Detalji), @"mvc.1.0.view", @"/Areas/ModulRadnik/Views/Radnik/Detalji.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b646e9d92414207c78f2802aac09698c7a844c92", @"/Areas/ModulRadnik/Views/Radnik/Detalji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9097ad0c2f81adf715fe93e53aeb465025b54b6", @"/Areas/ModulRadnik/Views/_ViewImports.cshtml")]
    public class Areas_ModulRadnik_Views_Radnik_Detalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event_Attender.Web.Areas.ModulRadnik.Models.EventDetaljiVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
  
    ViewData["Title"] = "Detalji";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3><strong>");
#nullable restore
#line 8 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
       Write(Model.NazivEventa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 164, "\"", 229, 2);
            WriteAttributeValue("", 171, "/ModulRadnik/Radnik/ExportDetaljiToExcel?id=", 171, 44, true);
#nullable restore
#line 9 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
WriteAttributeValue("", 215, Model.EventId, 215, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Exportuj u excel</a>
<br />
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Tip karte </th>
            <th>Ukupno za prodaju</th>
            <th>Broj prodatih karata</th>
            <th> Broj preostalih karata</th>
            <th>Cijena </th>
            <th>Zarada od tipa (KM)</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
         foreach(var p in Model.TipoviProdaje)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
           Write(p.TipKarte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
           Write(p.UkupnoKarataTip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
           Write(p.BrojProdatihKarataTip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
           Write(p.BrojPreostalihKarata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
           Write(p.CijenaTip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
           Write(p.ZaradaOdTipa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Detalji.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event_Attender.Web.Areas.ModulRadnik.Models.EventDetaljiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
