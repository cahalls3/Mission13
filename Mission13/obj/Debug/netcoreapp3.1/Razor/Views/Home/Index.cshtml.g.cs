#pragma checksum "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0e005f6fc727970f0e8b9bd9f06653cd8d90cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/_ViewImports.cshtml"
using Mission13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/_ViewImports.cshtml"
using Mission13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0e005f6fc727970f0e8b9bd9f06653cd8d90cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5062c50508e723399f66e5ee22e2d7108c74e729", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bowler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Bowlers</h1>\n\n<ul>\n");
#nullable restore
#line 10 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml"
     foreach (var b in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml"
       Write(b.BowlerID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml"
                     Write(b.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml"
                                        Write(b.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 13 "/Users/carsonhalls/Documents/GitHub/Mission13/Mission13/Views/Home/Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bowler>> Html { get; private set; }
    }
}
#pragma warning restore 1591