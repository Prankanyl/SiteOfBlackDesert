#pragma checksum "/Users/Valera/Projects/SiteOfBlackDesert/SiteOfBlackDesert/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d29222ce7bfd5b29ebb1d9c54dcfc9382b424c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SiteOfBlackDesert.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SiteOfBlackDesert.Pages
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
#line 1 "/Users/Valera/Projects/SiteOfBlackDesert/SiteOfBlackDesert/Pages/_ViewImports.cshtml"
using SiteOfBlackDesert;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Valera/Projects/SiteOfBlackDesert/SiteOfBlackDesert/Pages/Index.cshtml"
using SiteOfBlackDesert.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d29222ce7bfd5b29ebb1d9c54dcfc9382b424c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b7acc0e76951b2eae6241db36401053a53c315", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/Valera/Projects/SiteOfBlackDesert/SiteOfBlackDesert/Pages/Index.cshtml"
  
    ViewData["Title"] = "Black Desert";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"" stylr=""backgrount: #FFFFFF"">
    <div class=""container"" stylr=""backgrount: #343A40"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h1 style=""color: #000000"">Остальное находится в стадии разработки!)</h1>

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
