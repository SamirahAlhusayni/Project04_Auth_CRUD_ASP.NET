#pragma checksum "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5adef4e5bcad45e0da380734920cdf6c496ab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
#line 1 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\_ViewImports.cshtml"
using HealthChoice_Proj4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\_ViewImports.cshtml"
using HealthChoice_Proj4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5adef4e5bcad45e0da380734920cdf6c496ab7", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370a4b30f43f73c64c051c5a4e1f98ca3b631b65", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml"
  
    var Events = (List<EventsModel>)ViewData["Events"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1 style=\"text-align: center; color:#807b74 \">Events</h1>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml"
         foreach (var item in Events)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\" style=\"margin-top:10%; text-align:center\">\r\n                <div class=\"card mb-3\">\r\n                    <h3 class=\"card-header\">");
#nullable restore
#line 18 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"card-body\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 507, "\"", 524, 1);
#nullable restore
#line 20 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml"
WriteAttributeValue("", 513, item.Image, 513, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"200\" width=\"80\">\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 705, 2);
            WriteAttributeValue("", 681, "/Events/Details/", 681, 16, true);
#nullable restore
#line 24 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml"
WriteAttributeValue("", 697, item.Id, 697, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Read More</a>\r\n                    </div>\r\n                    \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Events\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
