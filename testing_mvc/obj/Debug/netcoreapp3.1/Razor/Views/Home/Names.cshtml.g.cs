#pragma checksum "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\testing_mvc\Views\Home\Names.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4409be72ee0650a79d3c7d8e566753ac4bfefab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Names), @"mvc.1.0.view", @"/Views/Home/Names.cshtml")]
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
#line 1 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\testing_mvc\Views\_ViewImports.cshtml"
using testing_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\testing_mvc\Views\_ViewImports.cshtml"
using testing_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4409be72ee0650a79d3c7d8e566753ac4bfefab6", @"/Views/Home/Names.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28daa87553bc46d74871105633fdd20b08b0fb4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Names : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Here are some names</h2>\r\n");
#nullable restore
#line 3 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\testing_mvc\Views\Home\Names.cshtml"
 foreach(var name in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 4 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\testing_mvc\Views\Home\Names.cshtml"
  Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\testing_mvc\Views\Home\Names.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
