#pragma checksum "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a1ee6b4fba481c45cc81e227babc09db1c58d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a1ee6b4fba481c45cc81e227babc09db1c58d7", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d34e71e9986e7fa807d74ccbd83f4990ca08574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-fluid mt-5 d-cont\">\r\n    <div class=\"cust-dc mb-5\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 101, "\"", 109, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"detail-pg-car\"");
            BeginWriteAttribute("src", " src=\"", 151, "\"", 173, 1);
#nullable restore
#line 6 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
WriteAttributeValue("", 157, Model.RealImage, 157, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 174, "", 191, 1);
#nullable restore
#line 6 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
WriteAttributeValue("", 179, Model.Brand, 179, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                                                                          Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("/>\r\n        </div>\r\n        <div class=\"d-flex flex-column details-sect\">\r\n            <h2>");
#nullable restore
#line 9 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
           Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                        Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                                     Write(Model.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                                                       Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 10 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
          Write(Model.HorsepowerHP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 10 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                               Write(Model.HorsePowerKW);

#line default
#line hidden
#nullable disable
            WriteLiteral(") | ");
#nullable restore
#line 10 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                                                      Write(Model.Transmission);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Available from: ");
#nullable restore
#line 10 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                                                                                            Write(Model.AvailableFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"car-desc\">");
#nullable restore
#line 11 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p");
            BeginWriteAttribute("class", " class=\"", 550, "\"", 558, 0);
            EndWriteAttribute();
            WriteLiteral("><span class=\"price-per-day\">");
#nullable restore
#line 12 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
                                               Write(Model.PricePerDay.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span><span>Per Day</span></p>
            <button class=""d-rent-now"">rent now</button>
        </div>
    </div>

    <div class=""more-features mb-5"">
        <div class=""temp"">
            <div class=""single-feature"">
                <span class=""material-symbols-outlined"">acute</span>
                <h4>Mileage</h4>
                <p>");
#nullable restore
#line 22 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
              Write(Model.Mileage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mpg</p>\r\n            </div>\r\n            <div class=\"single-feature\">\r\n                <span class=\"material-symbols-outlined\">palette</span>\r\n                <h4>Color</h4>\r\n                <p>");
#nullable restore
#line 27 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
              Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"single-feature\">\r\n                <span class=\"material-symbols-outlined\">directions_car</span>\r\n                <h4>Body style</h4>\r\n                <p>");
#nullable restore
#line 32 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
              Write(Model.BodyStyle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"single-feature\">\r\n                <span class=\"material-symbols-outlined\">electric_car</span>\r\n                <h4>Condition</h4>\r\n                <p>");
#nullable restore
#line 37 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
              Write(Model.Condition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"single-feature no-right-border\">\r\n                <span class=\"material-symbols-outlined\">move_location</span>\r\n                <h4>GPS</h4>\r\n                <p>");
#nullable restore
#line 42 "C:\Users\ODIRA.DESKTOP-II4QM4T\source\repos\FastaApp\FastaApp\Views\Home\Details.cshtml"
              Write(Model.Gps);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>

    <div class=""d-flex flex-column justify-content-center align-content-center w-100 reservation-sect text-center"">
        <h2>Reserve this car today!</h2>
        <p class=""mb-4"">Seize the opportunity and secure your reservation now! Hurry, our cars are in high demand and booking quickly.</p>
        <button class=""d-save-now"">save now</button>
    </div>
</div>

");
            DefineSection("HideFooter", async() => {
            }
            );
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
