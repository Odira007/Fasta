#pragma checksum "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292f6a2011fe39a80b160044b998b1e83347e922"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CarCard), @"mvc.1.0.view", @"/Views/Shared/_CarCard.cshtml")]
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
#line 1 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\_ViewImports.cshtml"
using FastaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\_ViewImports.cshtml"
using FastaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\_ViewImports.cshtml"
using FastaApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292f6a2011fe39a80b160044b998b1e83347e922", @"/Views/Shared/_CarCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d34e71e9986e7fa807d74ccbd83f4990ca08574", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CarCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"slide-content container\">\r\n    <div class=\"card-wrapper\">\r\n        <img");
            BeginWriteAttribute("src", " src=", 97, "", 117, 1);
#nullable restore
#line 5 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
WriteAttributeValue("", 102, Model.ImageUrl, 102, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 117, "", 134, 1);
#nullable restore
#line 5 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
WriteAttributeValue("", 122, Model.Brand, 122, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" + ");
#nullable restore
#line 5 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
                                               Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"car-image\" />\r\n        <div class=\"car-details\">\r\n            <h3 class=\"car-title\">\r\n                <span>");
#nullable restore
#line 8 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
                 Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span>");
#nullable restore
#line 9 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
                 Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </h3>\r\n");
#nullable restore
#line 11 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
             foreach (string s in @Model.Features.Split(','))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"fs-2\"><span class=\"mr-sm-1\"><i class=\"fa-solid fa-circle-check\" style=\"color: #6be52a;\"></i></span><span>");
#nullable restore
#line 13 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
                                                                                                                              Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 14 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "292f6a2011fe39a80b160044b998b1e83347e9227004", async() => {
                WriteLiteral("Rent now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Shared\_CarCard.cshtml"
                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
