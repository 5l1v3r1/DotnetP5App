#pragma checksum "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873dcf2be64707189d01ced69738b49b3dc78700"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873dcf2be64707189d01ced69738b49b3dc78700", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45316172bc775d901e5bb71a61cb2aeddadb9f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotnetP5App.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(86, 28, true);
            WriteLiteral("\r\n<h2>View</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a29b1b6e905485a9d9fa8896a818168", async() => {
                BeginContext(137, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(244, 38, false);
#line 16 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(282, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(338, 41, false);
#line 19 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(379, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(435, 40, false);
#line 22 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Trim));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 40, false);
#line 25 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
            EndContext();
            BeginContext(571, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(627, 40, false);
#line 28 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(667, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(723, 39, false);
#line 31 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vin));

#line default
#line hidden
            EndContext();
            BeginContext(762, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(818, 49, false);
#line 34 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PurchasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(867, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(923, 48, false);
#line 37 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(971, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1027, 43, false);
#line 40 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LotDate));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1188, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1237, 37, false);
#line 49 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1330, 40, false);
#line 52 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1426, 39, false);
#line 55 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Trim));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1521, 39, false);
#line 58 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Make));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1616, 39, false);
#line 61 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1711, 38, false);
#line 64 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vin));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1805, 48, false);
#line 67 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1909, 47, false);
#line 70 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2012, 42, false);
#line 73 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LotDate));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2110, 52, false);
#line 76 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2183, 59, false);
#line 77 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2242, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2263, 57, false);
#line 78 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Cars\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2359, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
