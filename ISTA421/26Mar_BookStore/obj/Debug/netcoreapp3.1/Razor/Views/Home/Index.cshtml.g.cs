#pragma checksum "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020efb908ad6c9d0d88d63aef8d602d38cbc742e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\_ViewImports.cshtml"
using _26Mar_BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\_ViewImports.cshtml"
using _26Mar_BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"020efb908ad6c9d0d88d63aef8d602d38cbc742e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da2a6861c80907aaee1e2de5dfe32ea24cbc191", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Carousel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Carousel";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"carousel slide\" data-ride=\"carousel\">\r\n   <div class=\"carousel-inner\">\r\n       <div class=\"carousel-item active\">\r\n           <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml"
                foreach (var item in Model)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col\"><figure><img");
            BeginWriteAttribute("src", " src=\"", 338, "\"", 363, 2);
            WriteAttributeValue("", 344, "/images/", 344, 8, true);
#nullable restore
#line 11 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 352, item.Image, 352, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"1 slide\" width=\"250\" height=\"400\"><figcaption><strong>");
#nullable restore
#line 11 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml"
                                                                                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>Description: ");
#nullable restore
#line 11 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml"
                                                                                                                                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption></figure></div>\r\n");
#nullable restore
#line 12 "C:\Users\Antho\Desktop\MSSA\ISTA421\26Mar_BookStore\Views\Home\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </div>\r\n       </div>\r\n   </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Carousel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
