#pragma checksum "C:\MisionTIC-2021-Ciclo3\Hospitalizacion\HospiEnCasa.App\HospiEncasa.App.Frontend\Pages\Personas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ecb341fa29de9d5a0fc1da3cdfc76ad9d90634e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hospiencasa.App.Frontend.Pages.Personas.Pages_Personas_List), @"mvc.1.0.razor-page", @"/Pages/Personas/List.cshtml")]
namespace Hospiencasa.App.Frontend.Pages.Personas
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
#line 1 "C:\MisionTIC-2021-Ciclo3\Hospitalizacion\HospiEnCasa.App\HospiEncasa.App.Frontend\Pages\_ViewImports.cshtml"
using Hospiencasa.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ecb341fa29de9d5a0fc1da3cdfc76ad9d90634e", @"/Pages/Personas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f648b33f5e83f9ad214f4adc011450767485568c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de de Personas</h1>\r\n<table class=\"table\">\r\n\r\n");
#nullable restore
#line 8 "C:\MisionTIC-2021-Ciclo3\Hospitalizacion\HospiEnCasa.App\HospiEncasa.App.Frontend\Pages\Personas\List.cshtml"
     foreach (var Personas in Model.ListPersonas)
      { 

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>  \r\n          <td>");
#nullable restore
#line 11 "C:\MisionTIC-2021-Ciclo3\Hospitalizacion\HospiEnCasa.App\HospiEncasa.App.Frontend\Pages\Personas\List.cshtml"
         Write(Personas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n      </tr>\r\n");
#nullable restore
#line 14 "C:\MisionTIC-2021-Ciclo3\Hospitalizacion\HospiEnCasa.App\HospiEncasa.App.Frontend\Pages\Personas\List.cshtml"

    
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hospiencasa.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hospiencasa.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hospiencasa.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public Hospiencasa.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
