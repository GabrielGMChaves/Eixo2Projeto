#pragma checksum "C:\Users\bielz\Documents\GitHub\Eixo2Projeto\app-web-backend\app-web-backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4529063c5ec74b6079855e229fe02d641a3d1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\bielz\Documents\GitHub\Eixo2Projeto\app-web-backend\app-web-backend\Views\_ViewImports.cshtml"
using app_web_backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bielz\Documents\GitHub\Eixo2Projeto\app-web-backend\app-web-backend\Views\_ViewImports.cshtml"
using app_web_backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4529063c5ec74b6079855e229fe02d641a3d1d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582541bfc66b4d2bc6eb83de74e3b4b0c1778188", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bielz\Documents\GitHub\Eixo2Projeto\app-web-backend\app-web-backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4529063c5ec74b6079855e229fe02d641a3d1d03371", async() => {
                WriteLiteral("\r\n    <link href=\"/css/index.css\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""sellingpoints"">
    <br>
    <br>
    <h2>Segurança e transparência são a nossa prioridade</h2>
    <br>
    <ul>
        <li>
            <img src=""/css/family.png"">
            <h5> Praticidade para a família</h5>
        </li>
        <br>
        <li>
            <img src=""/css/security.png "">
            <h5> Segurança em primeiro lugar</h5>
        </li>
        <br>
        <li>
            <img src=""/css/review.png"">
            <h5> Referências e avaliações das babás</h5>
        </li>
    </ul>
</div>
<br>
<br>
<div>
    <br>
    <h2 class=""titulo"">Como funciona: </h2>
    <br>
    <br>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""row"">
                <div class=""col-3 col-md-12"">
                    <div class=""icon"">
                        <i class=""inner-icon far fa-search""></i>
                    </div>
                </div>
                <div class=""col-9 col-md-12"">
                    <div class=""title"">");
            WriteLiteral(@" <strong> 1. Pesquise </strong></div>
                    <br>
                    <p class=""description""> Leia os detalhes do perfil e as avaliações feitas por quem já contratou esse profissional. Busque por trabalhos ocasionais, meio período ou período integral.</p>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""row"">
                <div class=""col-3 col-md-12"">
                    <div class=""icon"">
                        <i class=""inner-icon far fa-comments""></i>
                    </div>
                </div>
                <div class=""col-9 col-md-12"">
                    <div class=""title""> <strong> 2. Envie uma mensagem</strong> </div>
                    <br>
                    <p class=""description""> Entre em contato com as babás que você gostou para agendar uma entrevista.</p>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""row"">
              ");
            WriteLiteral(@"  <div class=""col-3 col-md-12"">
                    <div class=""icon"">
                        <i class=""inner-icon far fa-calendar-check""></i>
                    </div>
                </div>
                <div class=""col-9 col-md-12"">
                    <div class=""title""> <strong> 3. Contrate  </strong></div>
                    <br>
                    <p class=""description"">Você pode contratar a babá por hora ou mensalmente, os créditos ficarão na sua conta e poderão ser utilizados a qualquer momento.</p>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
