#pragma checksum "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\Calculator\Subtract.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24366c897526e5a076e73da3b852a77f32ea6e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Subtract), @"mvc.1.0.view", @"/Views/Calculator/Subtract.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Subtract.cshtml", typeof(AspNetCore.Views_Calculator_Subtract))]
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
#line 1 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24366c897526e5a076e73da3b852a77f32ea6e2e", @"/Views/Calculator/Subtract.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Subtract : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\Calculator\Subtract.cshtml"
  
    ViewData["Title"] = "Subtract";

#line default
#line hidden
            BeginContext(41, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(47, 17, false);
#line 5 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\Calculator\Subtract.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 71, true);
            WriteLiteral("</h1>\n<h3>Subtract query string numbers</h3>\n<ul>\n    <li>Number 1: <b>");
            EndContext();
            BeginContext(136, 16, false);
#line 8 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\Calculator\Subtract.cshtml"
                Write(ViewData["num1"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 31, true);
            WriteLiteral("</b></li>\n    <li>Number 2: <b>");
            EndContext();
            BeginContext(184, 16, false);
#line 9 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\Calculator\Subtract.cshtml"
                Write(ViewData["num2"]);

#line default
#line hidden
            EndContext();
            BeginContext(200, 29, true);
            WriteLiteral("</b></li>\n    <li>Result: <b>");
            EndContext();
            BeginContext(230, 18, false);
#line 10 "C:\Users\Administrator\Desktop\source\CIDM3312-master\inClass\httpGet\MyWebCalculator\Views\Calculator\Subtract.cshtml"
              Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(248, 15, true);
            WriteLiteral("</b></li>\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
