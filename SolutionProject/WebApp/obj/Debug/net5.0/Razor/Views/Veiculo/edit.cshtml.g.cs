#pragma checksum "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03a600d2301c2ef4e6a99f1f66ba41565db337e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_edit), @"mvc.1.0.view", @"/Views/Veiculo/edit.cshtml")]
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
#line 1 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e03a600d2301c2ef4e6a99f1f66ba41565db337e", @"/Views/Veiculo/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BackEnd.Models.Veiculo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e03a600d2301c2ef4e6a99f1f66ba41565db337e3896", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<h1>EDITAR VEÍCULO</h1>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
 using (Html.BeginForm())
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
Write(Html.HiddenFor(model => model.VeiculoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-row justify-content-center\">\r\n        <div class=\"form-group col-md-3\" style=\"float: left; width: 65%; text-align: center;\">\r\n            <strong>");
#nullable restore
#line 20 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
               Write(Html.Label("Nome"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
#nullable restore
#line 21 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-3\" style=\"float: left; width: 65%; text-align: center;\">\r\n            <strong>");
#nullable restore
#line 25 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
               Write(Html.Label("Cor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
#nullable restore
#line 26 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.EditorFor(model => model.Cor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-3\" style=\"float: left; width: 65%; text-align: center;\">\r\n            <strong>");
#nullable restore
#line 30 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
               Write(Html.Label("Modelo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
#nullable restore
#line 31 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.EditorFor(model => model.Modelo, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-row justify-content-center\">\r\n        <div class=\"form-group col-md-3\" style=\"float: left; width: 65%; text-align: center;\">\r\n            <strong>");
#nullable restore
#line 38 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
               Write(Html.Label("Ano de Fabricação"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
#nullable restore
#line 39 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.EditorFor(model => model.AnoFabricacao, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 40 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnoFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-3\" style=\"float: left; width: 65%; text-align: center;\">\r\n            <strong>");
#nullable restore
#line 43 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
               Write(Html.Label("Placa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
#nullable restore
#line 44 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.EditorFor(model => model.Placa, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 45 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-3\" style=\"float: left; width: 65%; text-align: center;\">\r\n            <strong>");
#nullable restore
#line 48 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
               Write(Html.Label("Marca"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            ");
#nullable restore
#line 49 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.EditorFor(model => model.Marca, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 50 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <hr />\r\n    <div class=\"form-row justify-content-center\">\r\n        <div class=\"form-group col-md-3\">\r\n            <input type=\"submit\" value=\"ATUALIZAR VEÍCULO\" class=\"btn btn-primary\" />\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 60 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"
       Write(Html.ActionLink("Voltar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\gkarlos\source\repos\SolutionProject\WebApp\Views\Veiculo\edit.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackEnd.Models.Veiculo> Html { get; private set; }
    }
}
#pragma warning restore 1591