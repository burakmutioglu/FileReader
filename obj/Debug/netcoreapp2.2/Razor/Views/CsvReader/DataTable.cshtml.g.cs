#pragma checksum "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee7a5c122b90fd08b475a347035fbadd17db4b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CsvReader_DataTable), @"mvc.1.0.view", @"/Views/CsvReader/DataTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CsvReader/DataTable.cshtml", typeof(AspNetCore.Views_CsvReader_DataTable))]
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
#line 1 "F:\Poject\CsvReader\CsvReader\Views\_ViewImports.cshtml"
using CsvReader;

#line default
#line hidden
#line 2 "F:\Poject\CsvReader\CsvReader\Views\_ViewImports.cshtml"
using CsvReader.Models;

#line default
#line hidden
#line 3 "F:\Poject\CsvReader\CsvReader\Views\_ViewImports.cshtml"
using CsvReader.Common.Dto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee7a5c122b90fd08b475a347035fbadd17db4b7b", @"/Views/CsvReader/DataTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de71ba826e0023610e4fa8a794367633e8200dc3", @"/Views/_ViewImports.cshtml")]
    public class Views_CsvReader_DataTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
  
    ViewData["Title"] = "DataTable";

#line default
#line hidden
            BeginContext(77, 946, true);
            WriteLiteral(@"
<h2>DataTable</h2>
<br />

<div class=""dropdown"">
    <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown""> Export Type </button>
    <div class=""dropdown-menu"">
        <h5 class=""dropdown-header""> Çıktı Türleri </h5>
        <a class=""dropdown-item"" onclick=""jsonExport('Json_')""> JSON </a>
        <a class=""dropdown-item"" onclick=""xmlExport('Xml_')""> XML </a>
        <a class=""dropdown-item"" onclick=""pdfExport('Pdf_')""> PDF </a>
        <a class=""dropdown-item"" onclick=""csvExport('Csv_')""> CSV </a>
        <a class=""dropdown-item"" onclick=""sqlExport('Sql_')""> SQL </a>
    </div>
</div>

<br />
<table class=""table table-responsive"" id=""csvTable"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Starts</th>
            <th>Contact</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Uri</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 35 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
         foreach (var hotel in Model)
        {

#line default
#line hidden
            BeginContext(1073, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1134, 10, false);
#line 39 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
               Write(hotel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1212, 11, false);
#line 42 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
               Write(hotel.Stars);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1291, 13, false);
#line 45 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
               Write(hotel.Contact);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1372, 11, false);
#line 48 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
               Write(hotel.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1383, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1451, 13, false);
#line 51 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
               Write(hotel.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1532, 9, false);
#line 54 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
               Write(hotel.Uri);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "F:\Poject\CsvReader\CsvReader\Views\CsvReader\DataTable.cshtml"
        }

#line default
#line hidden
            BeginContext(1596, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1639, 2095, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#csvTable').DataTable({
                ""scrollY"": ""500px"",
                ""scrollCollapse"": true,
                ""paging"": false,
                fixedColumns: {
                    heightMatch: 'none'
                }
            });
        });


        function jsonExport(exportType) {
            var fileName = createName(exportType);
            $('#csvTable').tableExport({ fileName: fileName, type: 'json' });
        };


        function xmlExport(exportType) {
            var fileName = createName(exportType);
            $('#csvTable').tableExport({ fileName: fileName, type: 'xml' });
        };

        function pdfExport(exportType) {
            var fileName = createName(exportType);
            $('#csvTable').tableExport({
                fileName: fileName,
                type: 'pdf',
                jspdf: {
                    orientation: 'l',
                   ");
                WriteLiteral(@" format: 'a3',
                    margins: { left: 10, right: 10, top: 20, bottom: 20 },
                    autotable: {
                        styles: {
                            fillColor: 'inherit',
                            textColor: 'inherit'
                        },
                        tableWidth: 'auto'
                    }
                }
            });

        };

        function csvExport(exportType) {
            var fileName = createName(exportType);
            $('#csvTable').tableExport({ fileName: fileName, type: 'csv' });
        };

        function sqlExport(exportType) {
            fileName: fileName,
                $('#csvTable').tableExport({ fileName: fileName, type: 'sql' });
        };

        function createName(exportType) {
            var dt = Date.now();
            return fileName = exportType + dt.toString();
        };

        function DoCellData(cell, row, col, data) { };
        function DoBeforeAutotable(table, headers, r");
                WriteLiteral("ows, AutotableSettings) { };\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591