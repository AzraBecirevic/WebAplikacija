#pragma checksum "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba3b763a218d26375078ba80a01321b0319b40c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ModulRadnik_Views_Radnik_Index), @"mvc.1.0.view", @"/Areas/ModulRadnik/Views/Radnik/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3b763a218d26375078ba80a01321b0319b40c5", @"/Areas/ModulRadnik/Views/Radnik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9097ad0c2f81adf715fe93e53aeb465025b54b6", @"/Areas/ModulRadnik/Views/_ViewImports.cshtml")]
    public class Areas_ModulRadnik_Views_Radnik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\ModulRadnik\Views\Radnik\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<a href=""/ModulRadnik/Radnik/ExportToExcel"" class=""btn btn-success"">Exportuj u excel</a>
<br />
<br />
<table id=""tabela"" class=""table table-bordered"">
    <thead>
        <tr>
            <th>Naziv eventa</th>
            <th>Datum održavanja</th>
            <th>Vrijeme</th>
            <th>Grad</th>
            <th>Prostor održavanja - Adresa</th>
            <th>Ukupno zarada od eventa</th>
            <th></th>
        </tr>
    </thead>
    <tbody>

    </tbody>
</table>

<script>
    function EventVM(event) {
        this.RadnikId = event.RadnikId;
        this.EventId = event.EventId;
        this.RadnikEventId = event.RadnikEventId;
        this.NazivEventa = event.NazivEventa;
        this.DatumOdrzavanja = event.DatumOdrzavanja;
        this.Vrijeme = event.Vrijeme;
        this.Grad = event.Grad;
        this.ProstorOdrzavanjaIAdresa = event.ProstorOdrzavanjaIAdresa;
        this.UkupnoZaradaOdEventa = event.UkupnoZaradaOdEventa;
    }
    function DodajEventeUTab");
            WriteLiteral(@"elu(eventi) {
        document.querySelector(""#tabela tbody"").innerHTML = """";
        for (var i = 0; i < eventi.length; i++) {
            var ev = new EventVM(eventi[i]);

            var tr = document.createElement('tr');
            tr.setAttribute(""id"", ev.EventId);
            document.querySelector(""#tabela tbody"").appendChild(tr);

            var td1 = document.createElement('td');
            var td2 = document.createElement('td');
            var td3 = document.createElement('td');
            var td4 = document.createElement('td');
            var td5 = document.createElement('td');
            var td6 = document.createElement('td');
            var td7  = document.createElement('td');
            tr.appendChild(td1);
            tr.appendChild(td2);
            tr.appendChild(td3);
            tr.appendChild(td4);
            tr.appendChild(td5);
            tr.appendChild(td6);
            tr.appendChild(td7);

            td1.innerText = ev.NazivEventa;
            td2.");
            WriteLiteral(@"innerText = ev.DatumOdrzavanja;
            td3.innerText = ev.Vrijeme;
            td4.innerText = ev.Grad;
            td5.innerText = ev.ProstorOdrzavanjaIAdresa;
            td6.innerText = ev.UkupnoZaradaOdEventa;

            var a = document.createElement('a');
            a.setAttribute(""href"", ""/ModulRadnik/Radnik/Detalji?id="" + ev.EventId);
            a.setAttribute(""class"", ""btn btn-success"");
            a.innerText = ""Detalji"";
            td7.appendChild(a);

        }
    }

    function GetAllEventi() {
         //var adresaServera = 'http://localhost:59867';
        //var mojUrl = adresaServera + '/ModulRadnik/Radnik/GetProizvodi';
         var mojUrl = '/ModulRadnik/Radnik/GetProizvodi';

        var zahtjev = new XMLHttpRequest();

        zahtjev.onload = function () {
            if (zahtjev.status === 200) {
                var eventi = JSON.parse(zahtjev.responseText);
                DodajEventeUTabelu(eventi);
                alert(""Podaci se učitavaju"");
 ");
            WriteLiteral(@"           }
            else {
                alert(""Server javlja grešku "" + zahtjev.statusText);
            }
        };
        zahtjev.open(""GET"", mojUrl, true);
        zahtjev.setRequestHeader(""Content-Type"", ""application/json"");
        zahtjev.send();
    }

    $(document).ready(function () {
        GetAllEventi();
    });
</script>");
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
