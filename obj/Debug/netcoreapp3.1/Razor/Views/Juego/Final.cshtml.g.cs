#pragma checksum "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dfce706f8258972280514c6b33020a10d2a83b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_Final), @"mvc.1.0.view", @"/Views/Juego/Final.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dfce706f8258972280514c6b33020a10d2a83b4", @"/Views/Juego/Final.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a68c50a50576327ec2b8dc926df438b371d73617", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_Final : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<proyecto1.Models.GameLogic.Tablero>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
  
    ViewData["Title"] = "Final";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Final Partida</h1>\r\n\r\n<div class=\"row text-center\">\r\n\r\n    <h2>\r\n        \r\n    </h2>\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
     using (Html.BeginForm("Final", "Juego"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label name=\"Piezas Negras\">#Piezas Negras: ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
                                               Write(Model.numeroPiezas[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> <br />\r\n        <label name=\"Piezas Blancas\">#Piezas Blancas: ");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
                                                 Write(Model.numeroPiezas[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dfce706f8258972280514c6b33020a10d2a83b44627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label name=\"Numero de Turnos\" class=\"control-label\">Numero de Turnos</label>\r\n            <input type=\"number\" name=\"turnos\"");
            BeginWriteAttribute("value", " value=\"", 667, "\"", 693, 1);
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
WriteAttributeValue("", 675, Model.numeroTurno, 675, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label name=\"Ganador\" class=\"control-label\">Ganador</label>\r\n            <input type=\"text\" name=\"ganador\"");
            BeginWriteAttribute("value", " value=\"", 890, "\"", 914, 1);
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
WriteAttributeValue("", 898, Model.Ganador(), 898, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div>\r\n            <label name=\"Tipo de Juego\" class=\"control-label\">Tipo de Juego</label>\r\n");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
             if (Model.vsMaquina)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"text\" name=\"retador\" value=\"Solitario\" class=\"form-control\" />\r\n");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"text\" name=\"retador\" value=\"Versus\" class=\"form-control\" />\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Lenovo\source\repos\proyecto1\Views\Juego\Final.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<proyecto1.Models.GameLogic.Tablero> Html { get; private set; }
    }
}
#pragma warning restore 1591
