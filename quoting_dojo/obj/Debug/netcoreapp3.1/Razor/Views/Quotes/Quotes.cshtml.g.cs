#pragma checksum "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\Quotes\Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85b8320ea371bdac9c0b1448b841139079013356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotes_Quotes), @"mvc.1.0.view", @"/Views/Quotes/Quotes.cshtml")]
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
#line 1 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\_ViewImports.cshtml"
using quoting_dojo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\_ViewImports.cshtml"
using quoting_dojo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b8320ea371bdac9c0b1448b841139079013356", @"/Views/Quotes/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8befaa81ee46489c12f9a4c1c5bac316dfc787f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Quotes_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>This is the quotes</h1>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\Quotes\Quotes.cshtml"
 foreach (var quote in ViewBag.quotes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 5 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\Quotes\Quotes.cshtml"
   Write(quote["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\Quotes\Quotes.cshtml"
                  Write(quote["saying"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 6 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\quoting_dojo\Views\Quotes\Quotes.cshtml"
}

#line default
#line hidden
#nullable disable
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
