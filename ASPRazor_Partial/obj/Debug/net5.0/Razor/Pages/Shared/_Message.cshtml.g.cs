#pragma checksum "D:\VKU\HK2-N3\LẬP TRÌNH WEB NC\Project\ASP.NET\ASPRazor_Partial\Pages\Shared\_Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3a5c15fddba89d56cd510f973930b7ab365aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASPRazor_Partial.Pages.Shared.Pages_Shared__Message), @"mvc.1.0.view", @"/Pages/Shared/_Message.cshtml")]
namespace ASPRazor_Partial.Pages.Shared
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
#line 1 "D:\VKU\HK2-N3\LẬP TRÌNH WEB NC\Project\ASP.NET\ASPRazor_Partial\Pages\_ViewImports.cshtml"
using ASPRazor_Partial;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3a5c15fddba89d56cd510f973930b7ab365aaf", @"/Pages/Shared/_Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdbe3c7b20bb4d5867d93cca25fe0089c2080943", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared__Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VKU\HK2-N3\LẬP TRÌNH WEB NC\Project\ASP.NET\ASPRazor_Partial\Pages\Shared\_Message.cshtml"
  
    var title = ViewData["titlename"] ?? "Thong bao";
    var content = ViewData["content"] ?? "Noi dung thong bao";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\">\r\n    <strong>");
#nullable restore
#line 7 "D:\VKU\HK2-N3\LẬP TRÌNH WEB NC\Project\ASP.NET\ASPRazor_Partial\Pages\Shared\_Message.cshtml"
       Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n    ");
#nullable restore
#line 8 "D:\VKU\HK2-N3\LẬP TRÌNH WEB NC\Project\ASP.NET\ASPRazor_Partial\Pages\Shared\_Message.cshtml"
Write(content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
