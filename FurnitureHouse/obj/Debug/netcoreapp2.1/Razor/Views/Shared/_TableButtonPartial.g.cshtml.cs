#pragma checksum "C:\Users\mahbub\Desktop\dot net pro\FoodExpress\FurnitureHouse\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4b3aa53d5aadf8f7e8feb89a057987d39e4530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "C:\Users\mahbub\Desktop\dot net pro\FoodExpress\FurnitureHouse\Views\_ViewImports.cshtml"
using FurnitureHouse;

#line default
#line hidden
#line 2 "C:\Users\mahbub\Desktop\dot net pro\FoodExpress\FurnitureHouse\Views\_ViewImports.cshtml"
using FurnitureHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4b3aa53d5aadf8f7e8feb89a057987d39e4530", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70be11d2bbd9ecd7e48f1ef258e8234eb2fa7c7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(129, 111, true);
            WriteLiteral("\r\n\r\n<td style=\"width:150px\">\r\n\t<div class=\"btn-group\" role=\"group\">\r\n\t\t<a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 240, "\"", 273, 1);
#line 8 "C:\Users\mahbub\Desktop\dot net pro\FoodExpress\FurnitureHouse\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 247, Url.Action("Edit/"+Model), 247, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(274, 62, true);
            WriteLiteral(">\r\n\t\t\tEdit\r\n\t\t</a>\r\n\t\t<a type=\"button\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 336, "\"", 372, 1);
#line 11 "C:\Users\mahbub\Desktop\dot net pro\FoodExpress\FurnitureHouse\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 343, Url.Action("Details/"+Model), 343, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(373, 64, true);
            WriteLiteral(">\r\n\t\t\tDetails\r\n\t\t</a>\r\n\t\t<a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 437, "\"", 472, 1);
#line 14 "C:\Users\mahbub\Desktop\dot net pro\FoodExpress\FurnitureHouse\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 444, Url.Action("Delete/"+Model), 444, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(473, 36, true);
            WriteLiteral(">\r\n\t\t\tDelete\r\n\t\t</a>\r\n\t</div>\r\n</td>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
