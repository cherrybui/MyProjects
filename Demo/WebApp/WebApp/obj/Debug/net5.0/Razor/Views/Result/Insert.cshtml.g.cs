#pragma checksum "E:\08-2021-C#\Buoi12\WebApp\Views\Result\Insert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3609bfac6035f46aea50283844a6b422a7cfa49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result_Insert), @"mvc.1.0.view", @"/Views/Result/Insert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3609bfac6035f46aea50283844a6b422a7cfa49", @"/Views/Result/Insert.cshtml")]
    public class Views_Result_Insert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<form method=\"post\">\r\n    <div>\r\n        <label>Date</label>\r\n        <input type=\"date\" name=\"date\" />\r\n    </div>\r\n    <div>\r\n        <label>Province</label>\r\n        <select name=\"provinceId\">\r\n");
#nullable restore
#line 9 "E:\08-2021-C#\Buoi12\WebApp\Views\Result\Insert.cshtml"
             foreach (WebApp.Models.Province item in ViewBag.provinces)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option");
            BeginWriteAttribute("value", " value=\"", 308, "\"", 324, 1);
#nullable restore
#line 11 "E:\08-2021-C#\Buoi12\WebApp\Views\Result\Insert.cshtml"
WriteAttributeValue("", 316, item.Id, 316, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("v", " v=\"", 325, "\"", 344, 1);
#nullable restore
#line 11 "E:\08-2021-C#\Buoi12\WebApp\Views\Result\Insert.cshtml"
WriteAttributeValue("", 329, item.PatternId, 329, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "E:\08-2021-C#\Buoi12\WebApp\Views\Result\Insert.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 12 "E:\08-2021-C#\Buoi12\WebApp\Views\Result\Insert.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>
    <div id=""sheet"">
        <!--Ajax-->
    </div>
    <div>
        <button>Save Changes</button>
    </div>
</form>
<script>
    var json = {};
    function loadData(id) {
        if (json[id] == undefined) {
            $.get(`/result/GetAddByPattern/${id}`, (d) => {
                json[id] = d;
                $(sheet).html(null); //xoa data cu
                $(sheet).append(d);
            })
        } else {
            $(sheet).html(null); //xoa data cu
            $(sheet).append(json[id]);
        }
    }
    console.log($('select[name=""provinceId""] option:selected').attr('v'));
    //new:
    loadData($('select[name=""provinceId""] option:selected').attr('v'));
    $('select[name=""provinceId""]').change(function () {
        loadData($(this).find('option:selected').attr('v'));
    //old:
    //loadData($('select[name=""provinceId""]').val());
    //$('select[name=""provinceId""]').change(function () {
    //    loadData($(this).val());
       ");
            WriteLiteral(" //$.get(`/result/getadd/${(this).val()}`, (d) => {\r\n        //    $(sheet).append(d);\r\n        //})\r\n    });\r\n</script>\r\n");
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