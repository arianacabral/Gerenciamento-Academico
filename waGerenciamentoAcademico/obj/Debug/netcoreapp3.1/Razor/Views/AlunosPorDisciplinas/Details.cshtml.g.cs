#pragma checksum "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89fd90e308a4ee5e04fec89d04bba2d3261aaac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlunosPorDisciplinas_Details), @"mvc.1.0.view", @"/Views/AlunosPorDisciplinas/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fd90e308a4ee5e04fec89d04bba2d3261aaac8", @"/Views/AlunosPorDisciplinas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf4d10ed730721b4a1685b8b9ba6ddcf6245786", @"/Views/_ViewImports.cshtml")]
    public class Views_AlunosPorDisciplinas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<waGerenciamentoAcademico.Models.AlunoDisciplina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n<br/>\r\n<div>\r\n    <h4>Aluno por Disciplina</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id_matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayFor(model => model.id_matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayFor(model => model.curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.disciplina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayFor(model => model.disciplina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayFor(model => model.nota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 52 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\AlunosPorDisciplinas\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fd90e308a4ee5e04fec89d04bba2d3261aaac88429", async() => {
                WriteLiteral("Voltar");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<waGerenciamentoAcademico.Models.AlunoDisciplina> Html { get; private set; }
    }
}
#pragma warning restore 1591
