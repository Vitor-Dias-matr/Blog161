#pragma checksum "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9349ab48452068f948b9c4b6feca5f1d903d9527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mensagem_Index), @"mvc.1.0.view", @"/Views/Mensagem/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mensagem/Index.cshtml", typeof(AspNetCore.Views_Mensagem_Index))]
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
#line 1 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using Blog161;

#line default
#line hidden
#line 2 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using Blog161.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9349ab48452068f948b9c4b6feca5f1d903d9527", @"/Views/Mensagem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b2bc1a4d32acc3ecd4318143b0984a8b89dd74", @"/Views/_ViewImports.cshtml")]
    public class Views_Mensagem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog161.Models.Mensagem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comentario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
  
    ViewData["Title"] = "Mensagens";

#line default
#line hidden
            BeginContext(92, 32, true);
            WriteLiteral("\r\n<h1>Mensagem</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9349ab48452068f948b9c4b6feca5f1d903d95276248", async() => {
                BeginContext(147, 4, true);
                WriteLiteral("Novo");
                EndContext();
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
            EndContext();
            BeginContext(155, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(198, 40, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            <h1>");
            EndContext();
            BeginContext(239, 41, false);
#line 17 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(280, 113, true);
            WriteLiteral("</h1>\r\n        </td>\r\n        <td>\r\n            <div class=\"card-body\">\r\n                <h5>Descrição:</h5><p> \"");
            EndContext();
            BeginContext(394, 44, false);
#line 21 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(438, 99, true);
            WriteLiteral("\"</p>\r\n                <h5 class=\"card-title\">Comentários</h5>\r\n                <div class=\"row\">\r\n");
            EndContext();
#line 24 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                     foreach (var comentario in item.Comentario)
                    {
                        

#line default
#line hidden
#line 26 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                         if (comentario.MensagemId == item.MensagemId)
                        {

#line default
#line hidden
            BeginContext(725, 233, true);
            WriteLiteral("                            <div class=\"col-sm-6\">\r\n                                <div class=\"card mb-2\">\r\n                                    <div class=\"card-body\">\r\n                                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(959, 17, false);
#line 31 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                                          Write(comentario.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(976, 68, true);
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1045, 20, false);
#line 32 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                                        Write(comentario.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 89, true);
            WriteLiteral("</p>\r\n                                        <span class=\"blockquote-footer float-left\">");
            EndContext();
            BeginContext(1155, 16, false);
#line 33 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                                                              Write(comentario.Autor);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1175, 25, false);
#line 33 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                                                                                  Write(comentario.DataComentario);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 129, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 37 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                        }

#line default
#line hidden
#line 37 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1379, 40, true);
            WriteLiteral("                </div>\r\n                ");
            EndContext();
            BeginContext(1419, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9349ab48452068f948b9c4b6feca5f1d903d952712320", async() => {
                BeginContext(1514, 8, true);
                WriteLiteral("Comentar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1526, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1544, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9349ab48452068f948b9c4b6feca5f1d903d952714002", async() => {
                BeginContext(1667, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                                                 WriteLiteral(item.MensagemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1675, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1693, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9349ab48452068f948b9c4b6feca5f1d903d952716693", async() => {
                BeginContext(1817, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
                                                                   WriteLiteral(item.MensagemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1827, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Fabrica\Documents\Blog161\Blog161\WebApplication1\WebApplication1\Views\Mensagem\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog161.Models.Mensagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591