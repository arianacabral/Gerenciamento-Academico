#pragma checksum "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce64165b8f5844b9a6770e41c2b0f739f3f977e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matriculas_Index), @"mvc.1.0.view", @"/Views/Matriculas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce64165b8f5844b9a6770e41c2b0f739f3f977e5", @"/Views/Matriculas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf4d10ed730721b4a1685b8b9ba6ddcf6245786", @"/Views/_ViewImports.cshtml")]
    public class Views_Matriculas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<waGerenciamentoAcademico.Models.Matricula>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce64165b8f5844b9a6770e41c2b0f739f3f977e53755", async() => {
                WriteLiteral("Cadastrar Nova");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.semestre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.semestre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 51 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.ActionLink("Ver Detalhes", "Details", new { id=item.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 52 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
               Write(Html.ActionLink("Deletar", "Delete", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\user\Documents\Projeto\waGerenciamentoAcademico24112021\Views\Matriculas\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<waGerenciamentoAcademico.Models.Matricula>> Html { get; private set; }
    }
}
#pragma warning restore 1591