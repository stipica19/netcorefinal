#pragma checksum "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3153e5c7f5d556a9edf389f875b689aeacf9275a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oprema_DetaljniPrikaz), @"mvc.1.0.view", @"/Views/Oprema/DetaljniPrikaz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Oprema/DetaljniPrikaz.cshtml", typeof(AspNetCore.Views_Oprema_DetaljniPrikaz))]
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
#line 1 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\_ViewImports.cshtml"
using ozo;

#line default
#line hidden
#line 2 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\_ViewImports.cshtml"
using ozo.Models;

#line default
#line hidden
#line 3 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\_ViewImports.cshtml"
using ozo.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3153e5c7f5d556a9edf389f875b689aeacf9275a", @"/Views/Oprema/DetaljniPrikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5027f94c9ac291bbe8329c7240a06caac19e7aee", @"/Views/_ViewImports.cshtml")]
    public class Views_Oprema_DetaljniPrikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ozo.Models.Oprema>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn colorBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Ažuriraj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(66, 112, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Oprema</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(179, 50, false);
#line 14 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayNameFor(model => model.InventarniBroj));

#line default
#line hidden
            EndContext();
            BeginContext(229, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(270, 46, false);
#line 17 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayFor(model => model.InventarniBroj));

#line default
#line hidden
            EndContext();
            BeginContext(316, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(357, 41, false);
#line 20 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(398, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(439, 37, false);
#line 23 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(476, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(517, 60, false);
#line 26 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayNameFor(model => model.KnjigovostvenaVrijednost));

#line default
#line hidden
            EndContext();
            BeginContext(577, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(618, 56, false);
#line 29 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayFor(model => model.KnjigovostvenaVrijednost));

#line default
#line hidden
            EndContext();
            BeginContext(674, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(715, 50, false);
#line 32 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayNameFor(model => model.LokacijaOpreme));

#line default
#line hidden
            EndContext();
            BeginContext(765, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(806, 63, false);
#line 35 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayFor(model => model.LokacijaOpreme.LokacijaOpremeId));

#line default
#line hidden
            EndContext();
            BeginContext(869, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(910, 55, false);
#line 38 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayNameFor(model => model.ReferentniTipOpreme));

#line default
#line hidden
            EndContext();
            BeginContext(965, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1006, 57, false);
#line 41 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayFor(model => model.ReferentniTipOpreme.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1104, 42, false);
#line 44 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1187, 44, false);
#line 47 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
       Write(Html.DisplayFor(model => model.Status.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1273, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91b74efbabf745a9a0213d468c6a2d9f", async() => {
                BeginContext(1363, 52, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-edit\"></span> Uredi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Oprema\DetaljniPrikaz.cshtml"
                           WriteLiteral(Model.OpremaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(1424, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a704728311d4d89b90d84315d2641c8", async() => {
                BeginContext(1466, 15, true);
                WriteLiteral("Nazad na Opremu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1485, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ozo.Models.Oprema> Html { get; private set; }
    }
}
#pragma warning restore 1591
