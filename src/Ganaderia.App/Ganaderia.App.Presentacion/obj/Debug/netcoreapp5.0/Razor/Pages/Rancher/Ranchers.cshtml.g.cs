#pragma checksum "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf75012ed1eb50dd06ae8cd71084a3360817752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ganaderia.App.Presentacion.Pages.Rancher.Pages_Rancher_Ranchers), @"mvc.1.0.razor-page", @"/Pages/Rancher/Ranchers.cshtml")]
namespace Ganaderia.App.Presentacion.Pages.Rancher
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
#line 1 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\_ViewImports.cshtml"
using Ganaderia.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf75012ed1eb50dd06ae8cd71084a3360817752", @"/Pages/Rancher/Ranchers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1717c2eb7bb98504efa8c0608ed0b9689cdbfa7f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rancher_Ranchers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Predio.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf75012ed1eb50dd06ae8cd71084a33608177525937", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Ganaderos</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5bf75012ed1eb50dd06ae8cd71084a33608177526410", async() => {
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
                WriteLiteral("\r\n    </link>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf75012ed1eb50dd06ae8cd71084a33608177528312", async() => {
                WriteLiteral(@"
    <h1>Lista de ganaderos</h1>

    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Apellido</th>
                <th scope=""col"">Teléfono</th>
                <th scope=""col"">Correo</th>
                <th scope=""col"">Cédula</th>
                <th scope=""col"">Residencia</th>
                <th scope=""col"">N° Predios</th>
                <th scope=""col"">Opciones</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
             foreach (var rancher in Model.Ranchers)
            {   

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf75012ed1eb50dd06ae8cd71084a33608177529590", async() => {
                    WriteLiteral("\r\n                    <td>");
#nullable restore
#line 38 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.Id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.LastName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.PhoneNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.CitizenID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.CityOfResidence);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
                   Write(rancher.AmountOfFarms);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                    <input style=\"display:none;\"");
                    BeginWriteAttribute("value", " value=", 1532, "", 1550, 1);
#nullable restore
#line 46 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
WriteAttributeValue("", 1539, rancher.Id, 1539, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"Id\">\r\n                    <td>\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf75012ed1eb50dd06ae8cd71084a336081775213603", async() => {
                        WriteLiteral(" Eliminar ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    </td>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 52 "D:\Users\Juan Diego\Desktop\JUANCHO\PROGRAMACION\MisionTIC2022\CICLO 3\Desarrollo de Software\SysGan\app-web-ganadera\src\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Rancher\Ranchers.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ganaderia.App.Presentacion.Pages.RanchersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.RanchersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.RanchersModel>)PageContext?.ViewData;
        public Ganaderia.App.Presentacion.Pages.RanchersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
