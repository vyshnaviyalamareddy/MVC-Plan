#pragma checksum "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a99ebffce64af28b7d497e5b4194f2f96d6157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Degrees_Details), @"mvc.1.0.view", @"/Views/Degrees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Degrees/Details.cshtml", typeof(AspNetCore.Views_Degrees_Details))]
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
#line 1 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\_ViewImports.cshtml"
using MVC_Plan;

#line default
#line hidden
#line 2 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\_ViewImports.cshtml"
using MVC_Plan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a99ebffce64af28b7d497e5b4194f2f96d6157", @"/Views/Degrees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627b51f81b902ac78bf2ae18d4c9bed6805c723c", @"/Views/_ViewImports.cshtml")]
    public class Views_Degrees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Plan.Models.Degree>
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 106, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Degree</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
            EndContext();
            BeginContext(183, 48, false);
#line 13 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DegreeAbbrev));

#line default
#line hidden
            EndContext();
            BeginContext(231, 20, true);
            WriteLiteral(" </dt>\r\n        <dd>");
            EndContext();
            BeginContext(252, 44, false);
#line 14 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
       Write(Html.DisplayFor(model => model.DegreeAbbrev));

#line default
#line hidden
            EndContext();
            BeginContext(296, 20, true);
            WriteLiteral(" </dd>\r\n        <dt>");
            EndContext();
            BeginContext(317, 46, false);
#line 15 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DegreeName));

#line default
#line hidden
            EndContext();
            BeginContext(363, 20, true);
            WriteLiteral(" </dt>\r\n        <dd>");
            EndContext();
            BeginContext(384, 42, false);
#line 16 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
       Write(Html.DisplayFor(model => model.DegreeName));

#line default
#line hidden
            EndContext();
            BeginContext(426, 19, true);
            WriteLiteral("</dd>\r\n        <dt>");
            EndContext();
            BeginContext(446, 48, false);
#line 17 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(494, 224, true);
            WriteLiteral("  </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>Number</th>\r\n                    <th>Abbrev</th>\r\n                    <th>Requirement Name</th>\r\n                </tr>\r\n");
            EndContext();
#line 25 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
                 foreach (var item in Model.Requirements.OrderBy(r => r.RequirementID))
                {

#line default
#line hidden
            BeginContext(826, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(881, 48, false);
#line 28 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RequirementID));

#line default
#line hidden
            EndContext();
            BeginContext(929, 36, true);
            WriteLiteral(" </td>\r\n                        <td>");
            EndContext();
            BeginContext(966, 52, false);
#line 29 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RequirementAbbrev));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 36, true);
            WriteLiteral(" </td>\r\n                        <td>");
            EndContext();
            BeginContext(1055, 50, false);
#line 30 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RequirementName));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 37, true);
            WriteLiteral("   </td>\r\n                    </tr>\r\n");
            EndContext();
#line 32 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1161, 67, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1228, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a99ebffce64af28b7d497e5b4194f2f96d61578251", async() => {
                BeginContext(1280, 4, true);
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
#line 38 "C:\Users\s531383\Documents\44663\MVC-Plan\MVC-Plan\Views\Degrees\Details.cshtml"
                           WriteLiteral(Model.DegreeID);

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
            BeginContext(1288, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1296, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a99ebffce64af28b7d497e5b4194f2f96d615710578", async() => {
                BeginContext(1318, 12, true);
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
            BeginContext(1334, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Plan.Models.Degree> Html { get; private set; }
    }
}
#pragma warning restore 1591
