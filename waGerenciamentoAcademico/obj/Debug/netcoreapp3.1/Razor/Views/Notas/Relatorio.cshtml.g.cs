#pragma checksum "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7306aa5f0889d31d5e9b1b9feb8fe2c82c0bc1cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notas_Relatorio), @"mvc.1.0.view", @"/Views/Notas/Relatorio.cshtml")]
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
#line 1 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\_ViewImports.cshtml"
using waGerenciamentoAcademico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\_ViewImports.cshtml"
using waGerenciamentoAcademico.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7306aa5f0889d31d5e9b1b9feb8fe2c82c0bc1cb", @"/Views/Notas/Relatorio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf4d10ed730721b4a1685b8b9ba6ddcf6245786", @"/Views/_ViewImports.cshtml")]
    public class Views_Notas_Relatorio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<waGerenciamentoAcademico.Models.Nota>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Relatorio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
  
    ViewData["Title"] = "Relatorio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7306aa5f0889d31d5e9b1b9feb8fe2c82c0bc1cb4188", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-md-1\">\r\n            <label for=\"name\">Ano</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"inputGroup-sizing-sm\" name=\"Ano\"");
                BeginWriteAttribute("value", " value=\"", 348, "\"", 382, 1);
#nullable restore
#line 11 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
WriteAttributeValue("", 356, ViewData["currentFilter"], 356, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-1\">\r\n            <label for=\"name\">Semestre</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"inputGroup-sizing-sm\" name=\"Semestre\"");
                BeginWriteAttribute("value", " value=\"", 588, "\"", 622, 1);
#nullable restore
#line 16 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
WriteAttributeValue("", 596, ViewData["currentFilter"], 596, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-5\">\r\n            <label for=\"name\">Aluno</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"inputGroup-sizing-sm\" name=\"Aluno\"");
                BeginWriteAttribute("value", " value=\"", 822, "\"", 856, 1);
#nullable restore
#line 21 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
WriteAttributeValue("", 830, ViewData["currentFilter"], 830, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-2\">\r\n            <label for=\"name\">Curso</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"inputGroup-sizing-sm\" name=\"Curso\"");
                BeginWriteAttribute("value", " value=\"", 1056, "\"", 1090, 1);
#nullable restore
#line 26 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
WriteAttributeValue("", 1064, ViewData["currentFilter"], 1064, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-3\">\r\n            <label for=\"name\">Disciplina</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"inputGroup-sizing-sm\" name=\"Disciplina\"");
                BeginWriteAttribute("value", " value=\"", 1300, "\"", 1334, 1);
#nullable restore
#line 31 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
WriteAttributeValue("", 1308, ViewData["currentFilter"], 1308, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n    </div> \r\n\r\n    <div class=\"col-lg-12\" style=\"text-align: right;\">\r\n        <input type=\"submit\" value=\"Pesquisar\" class=\"btn btn-outline-info btn-md\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br/>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.disciplina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.semestre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.nota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 69 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.disciplina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.semestre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.nota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>   \r\n                \r\n");
#nullable restore
#line 91 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
                  if (item.nota < 60){item.descricao = "REPROVADO";}else{item.descricao = "APROVADO";}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 93 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 96 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Notas\Relatorio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<waGerenciamentoAcademico.Models.Nota>> Html { get; private set; }
    }
}
#pragma warning restore 1591