#pragma checksum "C:\Users\Паша\Desktop\SiteOfBlackDesert\SiteOfBlackDesert\Pages\ListItemsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab5d030d9386cda8ab7cd30646979161008b570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SiteOfBlackDesert.Pages.Pages_ListItemsPage), @"mvc.1.0.razor-page", @"/Pages/ListItemsPage.cshtml")]
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
#line 1 "C:\Users\Паша\Desktop\SiteOfBlackDesert\SiteOfBlackDesert\Pages\_ViewImports.cshtml"
using SiteOfBlackDesert;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Паша\Desktop\SiteOfBlackDesert\SiteOfBlackDesert\Pages\ListItemsPage.cshtml"
using SiteOfBlackDesert.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab5d030d9386cda8ab7cd30646979161008b570", @"/Pages/ListItemsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09ed777e2dee028107d52aaf781a4705b9a8aa6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ListItemsPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Паша\Desktop\SiteOfBlackDesert\SiteOfBlackDesert\Pages\ListItemsPage.cshtml"
  
    ViewData["Title"] = "Items";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3></h3>\r\n");
#nullable restore
#line 8 "C:\Users\Паша\Desktop\SiteOfBlackDesert\SiteOfBlackDesert\Pages\ListItemsPage.cshtml"
  
    foreach (var item in Model)
    {

    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Items>> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<Items>> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<Items>>)PageContext?.ViewData;
        public IEnumerable<Items> Model => ViewData.Model;
    }
}
#pragma warning restore 1591
