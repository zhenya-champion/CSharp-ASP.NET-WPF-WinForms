#pragma checksum "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f200ad298f132da70e87c2e7262d6db6c5c3ce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllCars.cshtml", typeof(AspNetCore.Views_Shared_AllCars))]
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
#line 1 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f200ad298f132da70e87c2e7262d6db6c5c3ce7", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67d845e5371e4c720b943bf40f713afc7b23e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(12, 56, true);
            WriteLiteral("\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 68, "\"", 84, 1);
#line 4 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 74, Model.img, 74, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 85, "\"", 102, 1);
#line 4 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 91, Model.name, 91, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(103, 13, true);
            WriteLiteral(" />\r\n    <h2>");
            EndContext();
            BeginContext(117, 10, false);
#line 5 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml"
   Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(127, 14, true);
            WriteLiteral("</h2>\r\n    <p>");
            EndContext();
            BeginContext(142, 15, false);
#line 6 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml"
  Write(Model.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(157, 19, true);
            WriteLiteral("</p>\r\n    <p>Цена: ");
            EndContext();
            BeginContext(177, 25, false);
#line 7 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml"
        Write(Model.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(202, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(215, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f200ad298f132da70e87c2e7262d6db6c5c3ce76177", async() => {
                BeginContext(316, 18, true);
                WriteLiteral("Добавить в корзину");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "C:\Users\Zheny\OneDrive\Рабочий стол\Мои работы\Back-End\ASP.NET\Shop\Shop\Views\Shared\AllCars.cshtml"
                                                                                     WriteLiteral(Model.id);

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
            BeginContext(338, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
