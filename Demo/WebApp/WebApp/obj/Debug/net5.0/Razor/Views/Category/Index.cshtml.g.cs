#pragma checksum "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc5cb32c6373baddd5790971cdd094bafac99fd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc5cb32c6373baddd5790971cdd094bafac99fd1", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <a class=\"btn btn-primary\" href=\"/category/create\">Create</a>\r\n");
#nullable restore
#line 3 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Manage Category</h2>
<table class=""table table-bordered table-hover"">
    <thead class=""table-dark"">
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Edit</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
         foreach (WebApp.Models.Category item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 574, "\"", 604, 2);
            WriteAttributeValue("", 581, "/category/edit/", 581, 15, true);
#nullable restore
#line 20 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 596, item.Id, 596, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-pen\"></i></a></td>\r\n                <td><a class=\"d\"");
            BeginWriteAttribute("href", " href=\"", 675, "\"", 707, 2);
            WriteAttributeValue("", 682, "/category/delete/", 682, 17, true);
#nullable restore
#line 21 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 699, item.Id, 699, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></a></td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "E:\08-2021-C#\Buoi12\WebApp\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(\'.d\').click(()=> {\r\n        return confirm(\'Are you sure to delete?\')\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
