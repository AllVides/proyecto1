#pragma checksum "C:\Users\Lenovo\source\repos\proyecto1\Views\Torneo\VistaTorneo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3462c234222da9a6810f10f53ee1a18759eabe27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Torneo_VistaTorneo), @"mvc.1.0.view", @"/Views/Torneo/VistaTorneo.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\proyecto1\Views\_ViewImports.cshtml"
using proyecto1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\proyecto1\Views\_ViewImports.cshtml"
using proyecto1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3462c234222da9a6810f10f53ee1a18759eabe27", @"/Views/Torneo/VistaTorneo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a68c50a50576327ec2b8dc926df438b371d73617", @"/Views/_ViewImports.cshtml")]
    public class Views_Torneo_VistaTorneo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<proyecto1.Models.GameLogic.LogicaTorneo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\proyecto1\Views\Torneo\VistaTorneo.cshtml"
  
    ViewData["Title"] = @Model.nombreTorneo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\proyecto1\Views\Torneo\VistaTorneo.cshtml"
Write(Model.nombreTorneo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\proyecto1\Views\Torneo\VistaTorneo.cshtml"
Write(await Component.InvokeAsync("FiguraTorneo", new { torneo = Model, tamaño = Model.tamaño }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<proyecto1.Models.GameLogic.LogicaTorneo> Html { get; private set; }
    }
}
#pragma warning restore 1591
