#pragma checksum "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc1e5f6848c0ee05c905c33fe56c94b7e4ca87d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TableroMovil_TableroMovil), @"mvc.1.0.view", @"/Views/Shared/Components/TableroMovil/TableroMovil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc1e5f6848c0ee05c905c33fe56c94b7e4ca87d", @"/Views/Shared/Components/TableroMovil/TableroMovil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a68c50a50576327ec2b8dc926df438b371d73617", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TableroMovil_TableroMovil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<proyecto1.Models.GameLogic.Tablero>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Juego", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarXml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Movimiento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<aside class=\"GameData\">\r\n    <h3>Mueve: ");
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
          Write(Model.colorTurno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>#Turno: ");
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
           Write(Model.numeroTurno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h4>#Piezas Negras: ");
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                   Write(Model.numeroPiezas[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>#Piezas Blancas: ");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                    Write(Model.numeroPiezas[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cc1e5f6848c0ee05c905c33fe56c94b7e4ca87d5555", async() => {
                WriteLiteral("<h4>GuardarXml</h4>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cc1e5f6848c0ee05c905c33fe56c94b7e4ca87d6933", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"FinJuego\" name=\"lugar\" />\r\n        <input type=\"submit\" value=\"SaltarTurno\" name=\"lugar\" />\r\n        <input type=\"submit\" value=\"AutoPlay\" name=\"lugar\" />\r\n        \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</aside>\r\n\r\n\r\n<div class=\"tabla\">\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
     for (int i = 0; i < 9; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
         if (i == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
             for (int j = 0; j < 9; j++)
            {
                switch (j)
                {
                    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>A</h2></div>\r\n");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>B</h2></div>\r\n");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>C</h2></div>\r\n");
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>D</h2></div>\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 5:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>E</h2></div>\r\n");
#nullable restore
#line 41 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 6:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>F</h2></div>\r\n");
#nullable restore
#line 44 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 7:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>G</h2></div>\r\n");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    case 8:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"><h2>H</h2></div>\r\n");
#nullable restore
#line 50 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bloque letras flotar\"></div>\r\n");
#nullable restore
#line 53 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                        break;
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
             
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
             for (int j = 0; j < 9; j++)

            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                 if (j == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"bloque letras flotar\"><h2>");
#nullable restore
#line 64 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n");
#nullable restore
#line 65 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                }
                else if (Model.cuadricula[i, j].estado == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"bloque blanco flotar\"></div>\r\n");
#nullable restore
#line 69 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                }
                else if (Model.cuadricula[i, j].estado == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"bloque negro flotar\"></div>\r\n");
#nullable restore
#line 73 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                }
                else if (Model.cuadricula[i, j].estado == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"bloque verde flotar\">\r\n                        \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cc1e5f6848c0ee05c905c33fe56c94b7e4ca87d14806", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"lugar\"");
                BeginWriteAttribute("value", " value=\"", 2898, "\"", 2944, 1);
#nullable restore
#line 79 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
WriteAttributeValue("", 2906, Model.cuadricula[i, j].identificacion, 2906, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"ficha\" value=\" \" name=\"aceptarMov\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 83 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                }
                else if (Model.cuadricula[i, j].estado == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"bloque verde flotar\"></div>\r\n");
#nullable restore
#line 87 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Lenovo\source\repos\proyecto1\Views\Shared\Components\TableroMovil\TableroMovil.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
