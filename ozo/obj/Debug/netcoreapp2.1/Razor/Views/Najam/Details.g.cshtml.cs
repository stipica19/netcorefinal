#pragma checksum "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4049da1bcf866ce5197ae02234810ae56eabe69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Najam_Details), @"mvc.1.0.view", @"/Views/Najam/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Najam/Details.cshtml", typeof(AspNetCore.Views_Najam_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4049da1bcf866ce5197ae02234810ae56eabe69", @"/Views/Najam/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5027f94c9ac291bbe8329c7240a06caac19e7aee", @"/Views/_ViewImports.cshtml")]
    public class Views_Najam_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ozo.Models.Najam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(65, 111, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Najam</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(177, 40, false);
#line 14 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(217, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(258, 36, false);
#line 17 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(294, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(335, 43, false);
#line 20 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumOd));

#line default
#line hidden
            EndContext();
            BeginContext(378, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(419, 39, false);
#line 23 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatumOd));

#line default
#line hidden
            EndContext();
            BeginContext(458, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(499, 43, false);
#line 26 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumDo));

#line default
#line hidden
            EndContext();
            BeginContext(542, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(583, 39, false);
#line 29 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatumDo));

#line default
#line hidden
            EndContext();
            BeginContext(622, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(663, 41, false);
#line 32 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Firma));

#line default
#line hidden
            EndContext();
            BeginContext(704, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(745, 43, false);
#line 35 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayFor(model => model.Firma.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(788, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(829, 46, false);
#line 38 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VrstaNajma));

#line default
#line hidden
            EndContext();
            BeginContext(875, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(916, 48, false);
#line 41 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
       Write(Html.DisplayFor(model => model.VrstaNajma.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(964, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1006, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f175d981ac8445418e328320f778e31b", async() => {
                BeginContext(1057, 4, true);
                WriteLiteral("Edit");
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
#line 46 "C:\Users\ACER NITRO\Desktop\PROGRAMSKO\Projekt\webapp-grupa1\ozo\Views\Najam\Details.cshtml"
                           WriteLiteral(Model.NajamId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1065, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1072, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84a9d84347a4fb2990abea49b6d0802", async() => {
                BeginContext(1094, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1110, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ozo.Models.Najam> Html { get; private set; }
    }
}
#pragma warning restore 1591
