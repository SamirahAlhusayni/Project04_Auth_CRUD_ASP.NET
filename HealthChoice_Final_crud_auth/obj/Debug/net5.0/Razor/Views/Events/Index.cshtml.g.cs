#pragma checksum "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5a1e6461e90ed107bfbe019656a2ddfd8d1730"
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
#line 1 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\_ViewImports.cshtml"
using HealthChoice_Final_crud_auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\_ViewImports.cshtml"
using HealthChoice_Final_crud_auth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5a1e6461e90ed107bfbe019656a2ddfd8d1730", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785ee62791b0b015afb5c7e4599724b1ccb95a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml"
  
    var Events = (List<EventsModel>)ViewData["Events"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1 style=\"text-align: center; color:#807b74 \">Events</h1>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml"
         foreach (var item in Events)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\" style=\"margin-top:10%; text-align:center\">\r\n                <div class=\"card mb-3\">\r\n                    <h3 class=\"card-header\">");
#nullable restore
#line 18 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"card-body\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 507, "\"", 524, 1);
#nullable restore
#line 20 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml"
WriteAttributeValue("", 513, item.Image, 513, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"200\" width=\"80\">\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 706, 2);
            WriteAttributeValue("", 681, "/Artists/Details/", 681, 17, true);
#nullable restore
#line 24 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml"
WriteAttributeValue("", 698, item.Id, 698, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Read More</a>\r\n                    </div>\r\n                    \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Index.cshtml"


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
