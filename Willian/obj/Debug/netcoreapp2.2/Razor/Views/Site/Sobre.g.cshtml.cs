#pragma checksum "C:\Users\Lefisc\Documents\Will\Asp.Net\Willian\Views\Site\Sobre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e319cb18bde5b010289ec17dc4bc780447e0605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_Sobre), @"mvc.1.0.view", @"/Views/Site/Sobre.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Site/Sobre.cshtml", typeof(AspNetCore.Views_Site_Sobre))]
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
#line 1 "C:\Users\Lefisc\Documents\Will\Asp.Net\Willian\Views\_ViewImports.cshtml"
using Willian;

#line default
#line hidden
#line 2 "C:\Users\Lefisc\Documents\Will\Asp.Net\Willian\Views\_ViewImports.cshtml"
using Willian.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e319cb18bde5b010289ec17dc4bc780447e0605", @"/Views/Site/Sobre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc4132f888c745ef8e7f48e4748c1f4a0b69f16", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_Sobre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sobre.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/wire.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-img-pessoal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lefisc\Documents\Will\Asp.Net\Willian\Views\Site\Sobre.cshtml"
  
    ViewData["Title"] = "Sobre";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(43, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e319cb18bde5b010289ec17dc4bc780447e06054737", async() => {
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
            EndContext();
            BeginContext(90, 157, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"w-titulo\">\r\n                <h2 class=\"ml-2 mt-5\">");
            EndContext();
            BeginContext(248, 17, false);
#line 10 "C:\Users\Lefisc\Documents\Will\Asp.Net\Willian\Views\Site\Sobre.cshtml"
                                 Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(265, 196, true);
            WriteLiteral("</h2>\r\n                <p class=\"ml-2\">Principais informações sobre mim</p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(461, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e319cb18bde5b010289ec17dc4bc780447e06056728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(525, 1920, true);
            WriteLiteral(@"
        </div>
        <div class=""col-md-6"">
            <h2 class=""w-nome"">Eu sou Willian Bello e <span class=""w-cf-orange-3"">Desenvolvedor Web</span></h2>
            <p class=""w-paragrafo"">
                Olá, meu nome é Willian Bello, sou desenvolvedor web muito apaixonado e dedicado eu meu trabalho.
                Tenho mais ou menos 6 meses de experiência com desenvolvimento HTML5, CSS3, Bootstrap 4, Javascript e jQuery.
                Adquiri minhas habilidades trabalhando em projetos pessoais e contribuindo em diversos projetos de amigos.
                Me dedico a aprendizagem e aprimoramento de novas tecnologias buscando desafios a serem superados.
            </p>
            <div class=""row"">
                <div class=""col-md-6"">
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Aniversário: </span>10.12.1990</p>
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Cidade: </span>Gravataí - RS</p>
                    <p class=""w-paragrafo2""");
            WriteLiteral(@"><span class=""w-categoria"">Escolaridade: </span>Bacharel em Ciência da Computação (em andamento)</p>
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Telefone: </span>(51) 99456-5618</p>
                    <button class=""btn w-bg-orange-3 w-cf-white"">Enviar mensagem</button>
                </div>

                <div class=""col-md-6"">
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Idade: </span>28 anos</p>
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Interesses: </span>Musica, Artes Marciais</p>
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Email: </span>willianbello.s@gmail.com</p>
                    <p class=""w-paragrafo2""><span class=""w-categoria"">Página Facebook: </span>-------</p>
                </div>
            </div>
        </div>
    </div>

    

</div>


");
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