#pragma checksum "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\DojoDachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518ebd268f031bf104f36805fc391569a699b4ae"
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
#line 1 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\DojoDachi\Views\_ViewImports.cshtml"
using DojoDachi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\DojoDachi\Views\_ViewImports.cshtml"
using DojoDachi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518ebd268f031bf104f36805fc391569a699b4ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bce70f5dafba3f05b5d94a87a662fc8c5511826", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoDachi.Models.Dachi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\DojoDachi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"top_info\">\r\n        <span>Fullness: ");
#nullable restore
#line 6 "C:\Users\Motus Test Workbench\Desktop\projects\cSharp_projects\DojoDachi\Views\Home\Index.cshtml"
                   Write(Model.fullness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span>Happiness: </span>\r\n        <span>Meals: </span>\r\n        <span>Energy: </span>\r\n</div>\r\n<div  id=\"center_box\">\r\n    <p>You played with DojoDachi Happiness  , Energy  </p>\r\n    <a href=\"/feed\">Feed</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoDachi.Models.Dachi> Html { get; private set; }
    }
}
#pragma warning restore 1591
