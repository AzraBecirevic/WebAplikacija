#pragma checksum "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "349ae159cc4e1f6038f52ad538dcf04da3696f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Home_OrganizatorList), @"mvc.1.0.view", @"/Areas/Administrator/Views/Home/OrganizatorList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"349ae159cc4e1f6038f52ad538dcf04da3696f0b", @"/Areas/Administrator/Views/Home/OrganizatorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0016b6767730c936e45b5440b0aea7bd14cb65d3", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Home_OrganizatorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Event_Attender.Web.Areas.Administrator.Models.OrganizatorVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <p>
        <button class=""btn btn-primary"" for=""Dodaj"">Dodaj</button>
    </p>

<table id=""myTable"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th class=""th"">
                ");
#nullable restore
#line 16 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th\"></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td id=\"Action-Buttons\">\r\n                <button class=\"btn btn-primary\"");
            BeginWriteAttribute("id", " id=\"", 1581, "\"", 1594, 1);
#nullable restore
#line 53 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
WriteAttributeValue("", 1586, item.Id, 1586, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" for=\"Uredi\">Uredi</button>\r\n                <button class=\"btn btn-info\"");
            BeginWriteAttribute("id", " id=\"", 1668, "\"", 1681, 1);
#nullable restore
#line 54 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
WriteAttributeValue("", 1673, item.Id, 1673, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" for=\"Info\">Detalji</button>\r\n                <button class=\"btn btn-danger\"");
            BeginWriteAttribute("id", " id=\"", 1758, "\"", 1771, 1);
#nullable restore
#line 55 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
WriteAttributeValue("", 1763, item.Id, 1763, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" for=\"Ukloni\">Ukloni</button>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Azra\source\repos\webapp\Event_Attender\Event_Attender.Web\Areas\Administrator\Views\Home\OrganizatorList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#myTable\').DataTable();\r\n        $(\'.dataTables_length\').addClass(\'bs-select\');\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Event_Attender.Web.Areas.Administrator.Models.OrganizatorVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
