#pragma checksum "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb7cf32be095ae993a66af6122b999546fa46d17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\_ViewImports.cshtml"
using DotnetP5App;

#line default
#line hidden
#line 2 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\_ViewImports.cshtml"
using DotnetP5App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb7cf32be095ae993a66af6122b999546fa46d17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45316172bc775d901e5bb71a61cb2aeddadb9f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotnetP5App.Models.Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(90, 94, true);
            WriteLiteral("\r\n    <div class=\"jumbotron\">\r\n        <h1>ASP.Net</h1>\r\n        <div>\r\n            There are ");
            EndContext();
            BeginContext(185, 13, false);
#line 9 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Home\Index.cshtml"
                 Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(198, 62, true);
            WriteLiteral(" number of cars in Database.\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotnetP5App.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
