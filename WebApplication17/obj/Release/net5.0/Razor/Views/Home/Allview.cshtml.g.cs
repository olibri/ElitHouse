#pragma checksum "C:\Users\linec\source\repos\WebApplication17\WebApplication17\Views\Home\Allview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e8fdd7f3d7f83384b7de0aae2247970fa43138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Allview), @"mvc.1.0.view", @"/Views/Home/Allview.cshtml")]
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
#line 1 "C:\Users\linec\source\repos\WebApplication17\WebApplication17\Views\_ViewImports.cshtml"
using WebApplication17.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e8fdd7f3d7f83384b7de0aae2247970fa43138", @"/Views/Home/Allview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd9eae1509d021b8cde25c69d13fe3b5d3bd636", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Allview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<center>\r\n    <div >\r\n     \r\n");
#nullable restore
#line 6 "C:\Users\linec\source\repos\WebApplication17\WebApplication17\Views\Home\Allview.cshtml"
             foreach (House hs in ViewBag.Houses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <img");
            BeginWriteAttribute("src", " src=", 146, "", 158, 1);
#nullable restore
#line 9 "C:\Users\linec\source\repos\WebApplication17\WebApplication17\Views\Home\Allview.cshtml"
WriteAttributeValue("", 151, hs.Img, 151, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p> ");
#nullable restore
#line 10 "C:\Users\linec\source\repos\WebApplication17\WebApplication17\Views\Home\Allview.cshtml"
                   Write(hs.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                </div>\r\n");
#nullable restore
#line 12 "C:\Users\linec\source\repos\WebApplication17\WebApplication17\Views\Home\Allview.cshtml"
            }  

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n\r\n    </div>\r\n</center>\r\n");
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