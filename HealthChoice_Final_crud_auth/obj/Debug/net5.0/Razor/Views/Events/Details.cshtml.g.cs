#pragma checksum "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c1dea0da67bb33107df8215e190d77a6978e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Details), @"mvc.1.0.view", @"/Views/Events/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c1dea0da67bb33107df8215e190d77a6978e02", @"/Views/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785ee62791b0b015afb5c7e4599724b1ccb95a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Details.cshtml"
  
    var Events = (EventsModel)ViewData["Events"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mb-5\" style=\"margin-bottom:20px; margin-top:20px; text-align:center\">\r\n    <div class=\"card mb-6\">\r\n        <h3 class=\"card-header\">");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Details.cshtml"
                           Write(Events.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n        <div class=\"card-body\">\r\n            <p> ");
#nullable restore
#line 11 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Details.cshtml"
           Write(Events.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p> ");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Details.cshtml"
           Write(Events.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"row\" style=\"align-content: center\">\r\n                <div class=\"col d-flex justify-content-center align-items-center\">\r\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 525, "\"", 544, 1);
#nullable restore
#line 15 "C:\Users\HP\Desktop\Tuwaiq_Bootcamp\ASP_NET_MVC\Project04_Auth_CRUD_ASP.NET\HealthChoice_Final_crud_auth\Views\Events\Details.cshtml"
WriteAttributeValue("", 531, Events.Image, 531, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card image cap"" height=""400"" width=""200"">
                </div>
            </div>
        </div>

        <div class=""card-body"">
            <div class=""card-body"">
                <a href=""/Events"" class=""btn btn-dark"">Back</a>
            </div>

        </div>
    </div>
</div>








");
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